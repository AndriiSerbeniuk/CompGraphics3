using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace cg_lr3
{
    public partial class cg_lr3 : Form
    {

        int SideProjMinBorder = -10, SideProjMaxBorder = 11;
        int DimetricMinBorder = -6, DimetricMaxBorder = 11;
        PointF3D OldTransVals, TransVals;
        float ScalVal, OldScalVal;
        float XRotValue, OldXRotValue,
            YRotValue, OldYRotValue,
            ZRotValue, OldZRotValue;

        Polygon3D[] obj;
        Polygon3D[] InitObj;
        PointF3D objCentre;
        PointF3D InitObjCentre;

        BezierSurface bs;
        PointF3D[,] InitCntrlPoints;
        PointF3D SurfCentre;
        PointF3D InitSurfCentre;
        Point RedactCPIndex;

        Point[] NormalisedDimetricAxes;
        Point[] NormalisedXYAxes;
        Point[] NormalisedYZAxes;
        Point[] NormalisedZXAxes;

        static readonly PointF3D[] CoordinateLines = new PointF3D[]
        {
            new PointF3D(),
            new PointF3D(10f, 0f, 0f),
            new PointF3D(0f, 10, 0f),
            new PointF3D(0f, 0f, 10)
        };

        public cg_lr3()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            OldTransVals = new PointF3D();
            TransVals = new PointF3D();
            ScalVal = OldScalVal = 1;
            XRotValue = ZRotValue = YRotValue = OldXRotValue = OldYRotValue = OldZRotValue = 0;

            // Lower pentagon
            PointF3D LowerP1 = new PointF3D(1, 0, 0);
            PointF3D LowerP2 = new PointF3D(0, 0, 3);
            PointF3D LowerP3 = new PointF3D(2.5f, 0, 4.8f);
            PointF3D LowerP4 = new PointF3D(5, 0, 3);
            PointF3D LowerP5 = new PointF3D(4, 0, 0);

            // Upper pentagon
            PointF3D UpperP1 = new PointF3D(1.5f, 5, 1);
            PointF3D UpperP2 = new PointF3D(1.1f, 5, 2.6f);
            PointF3D UpperP3 = new PointF3D(2.5f, 5, 3.9f);
            PointF3D UpperP4 = new PointF3D(4.1f, 5, 2.6f);
            PointF3D UpperP5 = new PointF3D(3.5f, 5, 1f);

            InitObj = new Polygon3D[]   //pyramid
            {
                // lower pentagon
                new Polygon3D(new PointF3D[] { LowerP1, LowerP2, LowerP3, LowerP4, LowerP5 }),
                // lines connecting the pentagons
                new Polygon3D(new PointF3D[] { LowerP1, UpperP1 }),
                new Polygon3D(new PointF3D[] { LowerP2, UpperP2 }),
                new Polygon3D(new PointF3D[] { LowerP3, UpperP3 }),
                new Polygon3D(new PointF3D[] { LowerP4, UpperP4 }),
                new Polygon3D(new PointF3D[] { LowerP5, UpperP5 }),
                //upper pentagon
                new Polygon3D ( new PointF3D[] { UpperP1, UpperP2, UpperP3, UpperP4, UpperP5 } )
            };
            obj = (Polygon3D[])InitObj.Clone();

            InitObjCentre = new PointF3D(2, 2, 2);
            objCentre = InitObjCentre;

            InitCntrlPoints = new PointF3D[4, 4]
            {
                { new PointF3D(0, 0, 0), new PointF3D(1, 0, 0), new PointF3D(2, 0, 0), new PointF3D(3, 0, 0) },
                { new PointF3D(0, 0, 1), new PointF3D(1, 0, 1), new PointF3D(2, 0, 1), new PointF3D(3, 0, 1) },
                { new PointF3D(0, 0, 2), new PointF3D(1, 0, 2), new PointF3D(2, 0, 2), new PointF3D(3, 0, 2) },
                { new PointF3D(0, 0, 3), new PointF3D(1, 0, 3), new PointF3D(2, 0, 3), new PointF3D(3, 0, 3) }
            };

            bs = new BezierSurface(InitCntrlPoints, 0.2);
            InitSurfCentre = new PointF3D(1.5f, 0, 1.5f);
            SurfCentre = InitSurfCentre;
            RedactCPIndex = new Point(-1, -1);
            DefaultTransformVals();

            PointF[] ProjectedDimAxes = Affinity3D.ProjectDimetric(CoordinateLines);
            PointF[] ProjectedXYAxes = Affinity3D.ProjectToXY(CoordinateLines);
            PointF[] ProjectedYZAxes = Affinity3D.ProjectToYZ(CoordinateLines);
            PointF[] ProjectedZXAxes = Affinity3D.ProjectToZX(CoordinateLines);

            NormalisedDimetricAxes = new Point[ProjectedDimAxes.Length];
            NormalisedXYAxes = new Point[ProjectedXYAxes.Length];
            NormalisedYZAxes = new Point[ProjectedYZAxes.Length];
            NormalisedZXAxes = new Point[ProjectedZXAxes.Length];

            for (int i = 0; i < CoordinateLines.Length; i++)
            {
                NormalisedDimetricAxes[i].X = Normalisation.NormaliseX(ProjectedDimAxes[i].X, DimetricMinBorder, DimetricMaxBorder, paneldimetric.Width);
                NormalisedDimetricAxes[i].Y = Normalisation.NormaliseY(ProjectedDimAxes[i].Y, DimetricMinBorder, DimetricMaxBorder, paneldimetric.Height);
                NormalisedXYAxes[i].X = Normalisation.NormaliseX(ProjectedXYAxes[i].X, SideProjMinBorder, SideProjMaxBorder, panelxy.Width);
                NormalisedXYAxes[i].Y = Normalisation.NormaliseY(ProjectedXYAxes[i].Y, SideProjMinBorder, SideProjMaxBorder, panelxy.Height);
                NormalisedYZAxes[i].X = Normalisation.NormaliseX(ProjectedYZAxes[i].X, SideProjMinBorder, SideProjMaxBorder, panelyz.Width);
                NormalisedYZAxes[i].Y = Normalisation.NormaliseY(ProjectedYZAxes[i].Y, SideProjMinBorder, SideProjMaxBorder, panelyz.Height);
                NormalisedZXAxes[i].X = Normalisation.NormaliseX(ProjectedZXAxes[i].X, SideProjMinBorder, SideProjMaxBorder, panelzx.Width);
                NormalisedZXAxes[i].Y = Normalisation.NormaliseY(ProjectedZXAxes[i].Y, SideProjMinBorder, SideProjMaxBorder, panelzx.Height);
            }

        }

        // =================== Draw events
        private void paneldimetric_Paint(object sender, PaintEventArgs e)
        {
            Draw();
            DrawXYPanel();
            DrawZXPanel();
            DrawYZPanel();
        }

        void Draw()
        {
            TransformObject();

            Bitmap paneldim = new Bitmap(paneldimetric.Width, paneldimetric.Height);
            Graphics g = Graphics.FromImage(paneldim);
            g.Clear(Color.White);
            Pen gray = new Pen(Color.DarkGray);
            g.DrawLine(gray, NormalisedDimetricAxes[0], NormalisedDimetricAxes[1]);
            g.DrawLine(gray, NormalisedDimetricAxes[0], NormalisedDimetricAxes[2]);
            g.DrawLine(gray, NormalisedDimetricAxes[0], NormalisedDimetricAxes[3]);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString("X", Font, brush, NormalisedDimetricAxes[1]);
            g.DrawString("Y", Font, brush, NormalisedDimetricAxes[2]);
            g.DrawString("Z", Font, brush, NormalisedDimetricAxes[3]);
            // Determine what to draw
            if (PyramidRB.Checked)
                DrawPyramid(g, 0);
            else
                DrawSurface(g, 0);
            pictureBox1.Image = paneldim;
        }

        void DrawXYPanel()
        {
            Graphics g = panelxy.CreateGraphics();
            //Bitmap xypanel = new Bitmap(panelxy.Width, panelxy.Height);
            //Graphics g = Graphics.FromImage(xypanel);
            g.Clear(Color.White);
            Pen gray = new Pen(Color.DarkGray);
            g.DrawLine(gray, NormalisedXYAxes[0], NormalisedXYAxes[1]);
            g.DrawLine(gray, NormalisedXYAxes[0], NormalisedXYAxes[2]);
            g.DrawLine(gray, NormalisedXYAxes[0], NormalisedXYAxes[3]);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString("X", Font, brush, NormalisedXYAxes[1]);
            g.DrawString("Y", Font, brush, NormalisedXYAxes[2]);
            g.DrawString("Z", Font, brush, NormalisedXYAxes[3]);

            if (PyramidRB.Checked)
                DrawPyramid(g, 1);
            else
                DrawSurface(g, 1);
            //panelxy.BackgroundImage = xypanel;
            //DrawXY.Interrupt();
        }

        void DrawZXPanel()
        {
            Graphics g = panelzx.CreateGraphics();
            g.Clear(Color.White);
            Pen gray = new Pen(Color.DarkGray);
            g.DrawLine(gray, NormalisedZXAxes[0], NormalisedZXAxes[1]);
            g.DrawLine(gray, NormalisedZXAxes[0], NormalisedZXAxes[2]);
            g.DrawLine(gray, NormalisedZXAxes[0], NormalisedZXAxes[3]);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString("X", Font, brush, NormalisedZXAxes[1]);
            g.DrawString("Y", Font, brush, NormalisedZXAxes[2]);
            g.DrawString("Z", Font, brush, NormalisedZXAxes[3]);

            if (PyramidRB.Checked)
                DrawPyramid(g, 3);
            else
                DrawSurface(g, 3);
        }

        void DrawYZPanel()
        {
            Graphics g = panelyz.CreateGraphics();
            g.Clear(Color.White);
            Pen gray = new Pen(Color.DarkGray);
            g.DrawLine(gray, NormalisedYZAxes[0], NormalisedYZAxes[1]);
            g.DrawLine(gray, NormalisedYZAxes[0], NormalisedYZAxes[2]);
            g.DrawLine(gray, NormalisedYZAxes[0], NormalisedYZAxes[3]);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString("X", Font, brush, NormalisedYZAxes[1]);
            g.DrawString("Y", Font, brush, NormalisedYZAxes[2]);
            g.DrawString("Z", Font, brush, NormalisedYZAxes[3]);

            if (PyramidRB.Checked)
                DrawPyramid(g, 2);
            else
                DrawSurface(g, 2);
        }

        /// <summary>
        /// Draws Bezier surface to the Graphics object.
        /// </summary>
        /// <param name="g">0 - dimetric, 1 - xy, 2 - yz, 3 - zx</param>
        private void DrawSurface(Graphics g, int drawTo)
        {
            int PointCount = bs.DrawPoints.GetLength(0);
            PointF3D[] Surfpoints = new PointF3D[PointCount * PointCount];
            PointF[] prSurfPoints;
            Point[] nPrSurfPoints = new Point[Surfpoints.Length];

            switch (drawTo)
            {
                case 0:
                    prSurfPoints = bs.ProjectDimetric();
                    for (int i = 0; i < nPrSurfPoints.Length; i++)
                    {
                        nPrSurfPoints[i].X = Normalisation.NormaliseX(prSurfPoints[i].X, DimetricMinBorder, DimetricMaxBorder, paneldimetric.Width);
                        nPrSurfPoints[i].Y = Normalisation.NormaliseY(prSurfPoints[i].Y, DimetricMinBorder, DimetricMaxBorder, paneldimetric.Height);
                    }
                    break;
                case 1:
                    prSurfPoints = bs.ProjectXY();
                    for (int i = 0; i < nPrSurfPoints.Length; i++)
                    {
                        nPrSurfPoints[i].X = Normalisation.NormaliseX(prSurfPoints[i].X, SideProjMinBorder, SideProjMaxBorder, panelxy.Width);
                        nPrSurfPoints[i].Y = Normalisation.NormaliseY(prSurfPoints[i].Y, SideProjMinBorder, SideProjMaxBorder, panelxy.Height);
                    }
                    break;
                case 2:
                    prSurfPoints = bs.ProjectYZ();
                    for (int i = 0; i < nPrSurfPoints.Length; i++)
                    {
                        nPrSurfPoints[i].X = Normalisation.NormaliseX(prSurfPoints[i].X, SideProjMinBorder, SideProjMaxBorder, panelyz.Width);
                        nPrSurfPoints[i].Y = Normalisation.NormaliseY(prSurfPoints[i].Y, SideProjMinBorder, SideProjMaxBorder, panelyz.Height);
                    }
                    break;
                case 3:
                    prSurfPoints = bs.ProjectZX();
                    for (int i = 0; i < nPrSurfPoints.Length; i++)
                    {
                        nPrSurfPoints[i].X = Normalisation.NormaliseX(prSurfPoints[i].X, SideProjMinBorder, SideProjMaxBorder, panelzx.Width);
                        nPrSurfPoints[i].Y = Normalisation.NormaliseY(prSurfPoints[i].Y, SideProjMinBorder, SideProjMaxBorder, panelzx.Height);
                    }
                    break;
            }

            Point[,] nPrSP2Dim = new Point[PointCount, PointCount];
            for (int r = 0; r < PointCount; r++)
                for (int c = 0; c < PointCount; c++)
                    nPrSP2Dim[r, c] = nPrSurfPoints[r * PointCount + c];

            Pen pen = new Pen(Color.Red);
            for (int r = 0; r < PointCount - 1; r++)
                for (int c = 0; c < PointCount - 1; c++)
                {
                    g.DrawLine(pen, nPrSP2Dim[r, c], nPrSP2Dim[r, c + 1]);
                    g.DrawLine(pen, nPrSP2Dim[r, c], nPrSP2Dim[r + 1, c]);
                }
            for (int i = 0; i < PointCount - 1; i++)
            {
                g.DrawLine(pen, nPrSP2Dim[i, PointCount - 1], nPrSP2Dim[i + 1, PointCount - 1]);
                g.DrawLine(pen, nPrSP2Dim[PointCount - 1, i], nPrSP2Dim[PointCount - 1, i + 1]);
            }

            if (checkBox1.Checked)
            {
                PointF cp = new Point();
                SolidBrush brush = new SolidBrush(Color.Black);
                int circleRad = 3;
                for (int r = 0; r < 4; r++)
                    for (int c = 0; c < 4; c++)
                    {
                        cp = Affinity3D.ProjectDimetric(new PointF3D[] { bs.ControlPoints[r, c] })[0];
                        cp.X = Normalisation.NormaliseX(cp.X, DimetricMinBorder, DimetricMaxBorder, paneldimetric.Width);
                        cp.Y = Normalisation.NormaliseY(cp.Y, DimetricMinBorder, DimetricMaxBorder, paneldimetric.Height);

                        g.FillEllipse(brush, cp.X - circleRad, cp.Y - circleRad, circleRad * 2, circleRad * 2);
                        g.DrawString("P" + (r + 1) + (c + 1), Font, brush, cp);
                    }
            }

        }

        /// <summary>
        /// Draws pyramid to the Graphics object.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="drawTo">0 - dimetric, 1 - xy, 2 - yz, 3 - zx</param>
        private void DrawPyramid(Graphics g, int drawTo)
        {
            Polygon2D[] probj = new Polygon2D[obj.Length];
            Polygon2D[] nprobj = new Polygon2D[probj.Length];

            switch (drawTo)
            {
                case 0:
                    for (int i = 0; i < obj.Length; i++)
                    {
                        probj[i].Outline = obj[i].ProjectDimetric();
                        nprobj[i].Outline = probj[i].GetNormalisedOutline(DimetricMinBorder, DimetricMaxBorder, DimetricMinBorder, DimetricMaxBorder, paneldimetric.Size);
                    }
                    break;
                case 1:
                    for (int i = 0; i < obj.Length; i++)
                    {
                        probj[i].Outline = obj[i].ProjectXY();
                        nprobj[i].Outline = probj[i].GetNormalisedOutline(SideProjMinBorder, SideProjMaxBorder, SideProjMinBorder, SideProjMaxBorder, panelxy.Size);
                    }
                    break;
                case 2:
                    for (int i = 0; i < obj.Length; i++)
                    {
                        probj[i].Outline = obj[i].ProjectYZ();
                        nprobj[i].Outline = probj[i].GetNormalisedOutline(SideProjMinBorder, SideProjMaxBorder, SideProjMinBorder, SideProjMaxBorder, panelyz.Size);
                    }
                    break;
                case 3:
                    for (int i = 0; i < obj.Length; i++)
                    {
                        probj[i].Outline = obj[i].ProjectZX();
                        nprobj[i].Outline = probj[i].GetNormalisedOutline(SideProjMinBorder, SideProjMaxBorder, SideProjMinBorder, SideProjMaxBorder, panelzx.Size);
                    }
                    break;
            }

            Pen pen = new Pen(Color.Red);
            foreach (Polygon2D p in nprobj)
            {
                g.DrawPolygon(pen, p.Outline);
            }
        }

        private void TransformObject()
        {
            if (OldXRotValue != XRotValue)
            {
                if (PyramidRB.Checked)
                {
                    for (int i = 0; i < obj.Length; i++)
                    {
                        obj[i].Outline = obj[i].RotateX(XRotValue - OldXRotValue, objCentre);
                    }
                }
                else
                {
                    bs.ControlPoints = bs.RotateX(XRotValue - OldXRotValue, SurfCentre);
                }
                OldXRotValue = XRotValue;
            }
            if (OldYRotValue != YRotValue)
            {
                if (PyramidRB.Checked)
                {
                    for (int i = 0; i < obj.Length; i++)
                    {
                        obj[i].Outline = obj[i].RotateY(YRotValue - OldYRotValue, objCentre);
                    }
                }
                else
                {
                    bs.ControlPoints = bs.RotateY(YRotValue - OldYRotValue, SurfCentre);
                }
                OldYRotValue = YRotValue;
            }
            if (OldZRotValue != ZRotValue)
            {
                if (PyramidRB.Checked)
                {
                    for (int i = 0; i < obj.Length; i++)
                    {
                        obj[i].Outline = obj[i].RotateZ(ZRotValue - OldZRotValue, objCentre);
                    }
                }
                else
                {
                    bs.ControlPoints = bs.RotateZ(ZRotValue - OldZRotValue, SurfCentre);
                }
                OldZRotValue = ZRotValue;
            }
            if (OldTransVals != TransVals)
            {
                if (PyramidRB.Checked)
                {
                    for (int i = 0; i < obj.Length; i++)
                    {
                        obj[i].Outline = obj[i].Translate(new PointF3D(TransVals.X - OldTransVals.X, TransVals.Y - OldTransVals.Y, TransVals.Z - OldTransVals.Z));
                    }
                    objCentre.X += TransVals.X - OldTransVals.X;
                    objCentre.Y += TransVals.Y - OldTransVals.Y;
                    objCentre.Z += TransVals.Z - OldTransVals.Z;
                }
                else
                {
                    bs.ControlPoints = bs.Translate(new PointF3D(TransVals.X - OldTransVals.X, TransVals.Y - OldTransVals.Y, TransVals.Z - OldTransVals.Z));
                    SurfCentre.X += TransVals.X - OldTransVals.X;
                    SurfCentre.Y += TransVals.Y - OldTransVals.Y;
                    SurfCentre.Z += TransVals.Z - OldTransVals.Z;
                }

                OldTransVals = TransVals;
            }
            if (OldScalVal != ScalVal)
            {
                float curscalval = ScalVal / OldScalVal;
                if (PyramidRB.Checked)
                {
                    for (int i = 0; i < obj.Length; i++)
                    {
                        obj[i].Outline = obj[i].Scale(new PointF3D(curscalval, curscalval, curscalval), objCentre);
                    }
                }
                else
                {
                    bs.ControlPoints = bs.Scale(new PointF3D(curscalval, curscalval, curscalval), SurfCentre);
                }
                OldScalVal = ScalVal;
            }
        }


        private void DefaultTransformVals()
        {
            objCentre = InitObjCentre;
            SurfCentre = InitSurfCentre;
            OldScalVal = ScalVal = 1;
            ScalValBox.Value = 1;
            if (PyramidRB.Checked)
            {
                OldTransVals.X = TransVals.X = objCentre.X;
                OldTransVals.Y = TransVals.Y = objCentre.Y;
                OldTransVals.Z = TransVals.Z = objCentre.Z;
            }
            else
            {
                OldTransVals.X = TransVals.X = SurfCentre.X;
                OldTransVals.Y = TransVals.Y = SurfCentre.Y;
                OldTransVals.Z = TransVals.Z = SurfCentre.Z;
            }
            XTransBox.Value = (decimal)OldTransVals.X;
            YTransBox.Value = (decimal)OldTransVals.Y;
            ZTransBox.Value = (decimal)OldTransVals.Z;

            XRotValue = YRotValue = ZRotValue = OldXRotValue = OldYRotValue = OldZRotValue = 0;
            ZRotBox.Value = YRotBox.Value = XRotBox.Value = 0;
            obj = (Polygon3D[])InitObj.Clone();
            bs.ControlPoints = (PointF3D[,])InitCntrlPoints.Clone();
        }


        // ============== Other events
        private void YRotBox_ValueChanged(object sender, EventArgs e)
        {
            if (YRotBox.Value >= 360)
                YRotBox.Value -= 360;
            else if (YRotBox.Value < 0)
                YRotBox.Value += 360;
            if (OldYRotValue != (float)YRotBox.Value)
            {
                YRotValue = (float)YRotBox.Value;
                paneldimetric.Refresh();
                //Draw();
            }
        }

        private void ZRotBox_ValueChanged(object sender, EventArgs e)
        {
            if (ZRotBox.Value >= 360)
                ZRotBox.Value -= 360;
            else if (ZRotBox.Value < 0)
                ZRotBox.Value += 360;
            if (OldZRotValue != (float)ZRotBox.Value)
            {
                ZRotValue = (float)ZRotBox.Value;
                paneldimetric.Refresh();
                //Draw();
            }
        }

        private void XRotBox_ValueChanged(object sender, EventArgs e)
        {
            if (XRotBox.Value >= 360)
                XRotBox.Value -= 360;
            else if (XRotBox.Value < 0)
                XRotBox.Value += 360;
            if (OldXRotValue != (float)XRotBox.Value)
            {
                XRotValue = (float)XRotBox.Value;
                paneldimetric.Refresh();
                //Draw();
            }
        }

        private void PyramidRB_CheckedChanged(object sender, EventArgs e)
        {
            if (PyramidRB.Checked)
            {
                DefaultTransformVals();
                if (!AllSurfRB.Checked)
                    AllSurfRB.Checked = true;
                BSurfGB.Enabled = false;
            }
            paneldimetric.Refresh();
            //Draw();
        }

        private void SurfaceRB_CheckedChanged(object sender, EventArgs e)
        {
            if (SurfaceRB.Checked)
            {
                DefaultTransformVals();
                BSurfGB.Enabled = true;
            }
            //Draw();
            paneldimetric.Refresh();
        }
        private void AllSurfRB_CheckedChanged(object sender, EventArgs e)
        {
            if (AllSurfRB.Checked)
            {
                XRotBox.Enabled = YRotBox.Enabled = ZRotBox.Enabled = ScalValBox.Enabled = true;
                XTransBox.Value = (decimal)TransVals.X;
                YTransBox.Value = (decimal)TransVals.Y;
                ZTransBox.Value = (decimal)TransVals.Z;
                XTransBox.Minimum = -10;
                YTransBox.Minimum = -10;
                ZTransBox.Minimum = -10;
                XTransBox.Maximum = 10;
                YTransBox.Maximum = 10;
                ZTransBox.Maximum = 10;
            }
            else
            {
                XTransBox.Minimum = -10000;
                YTransBox.Minimum = -10000;
                ZTransBox.Minimum = -10000;
                XTransBox.Maximum = 10000;
                YTransBox.Maximum = 10000;
                ZTransBox.Maximum = 10000;
                XRotBox.Enabled = YRotBox.Enabled = ZRotBox.Enabled = ScalValBox.Enabled = false;
            }
        }
        private void p11rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p11rb.Checked)
            {
                RedactCPIndex.X = 0;
                RedactCPIndex.Y = 0;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p12rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p12rb.Checked)
            {
                RedactCPIndex.X = 0;
                RedactCPIndex.Y = 1;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p13rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p13rb.Checked)
            {
                RedactCPIndex.X = 0;
                RedactCPIndex.Y = 2;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }


        private void p14rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p14rb.Checked)
            {
                RedactCPIndex.X = 0;
                RedactCPIndex.Y = 3;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p22rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p22rb.Checked)
            {
                RedactCPIndex.X = 1;
                RedactCPIndex.Y = 1;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p23rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p23rb.Checked)
            {
                RedactCPIndex.X = 1;
                RedactCPIndex.Y = 2;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p24rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p24rb.Checked)
            {
                RedactCPIndex.X = 1;
                RedactCPIndex.Y = 3;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p31rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p31rb.Checked)
            {
                RedactCPIndex.X = 2;
                RedactCPIndex.Y = 0;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p32rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p32rb.Checked)
            {
                RedactCPIndex.X = 2;
                RedactCPIndex.Y = 1;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p33rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p33rb.Checked)
            {
                RedactCPIndex.X = 2;
                RedactCPIndex.Y = 2;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p34rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p34rb.Checked)
            {
                RedactCPIndex.X = 2;
                RedactCPIndex.Y = 3;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p41rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p41rb.Checked)
            {
                RedactCPIndex.X = 3;
                RedactCPIndex.Y = 0;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p42rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p42rb.Checked)
            {
                RedactCPIndex.X = 3;
                RedactCPIndex.Y = 1;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void TvalBox_ValueChanged(object sender, EventArgs e)
        {
            bs.DrawIncrement = (double)TvalBox.Value;
            paneldimetric.Refresh();
            //Draw();
        }



        private void p43rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p43rb.Checked)
            {
                RedactCPIndex.X = 3;
                RedactCPIndex.Y = 2;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p44rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p44rb.Checked)
            {
                RedactCPIndex.X = 3;
                RedactCPIndex.Y = 3;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }

        private void p21rb_CheckedChanged(object sender, EventArgs e)
        {
            if (p21rb.Checked)
            {
                RedactCPIndex.X = 1;
                RedactCPIndex.Y = 0;
                XTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                YTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                ZTransBox.Value = (decimal)bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            paneldimetric.Refresh();
        }

        private void ScalValBox_ValueChanged(object sender, EventArgs e)
        {
            if (OldScalVal != (float)ScalValBox.Value)
            {
                ScalVal = (float)ScalValBox.Value;
                paneldimetric.Refresh();
            }
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (AllSurfRB.Checked)
            {
                if ((decimal)TransVals.X != XTransBox.Value)
                {
                    TransVals.X = (float)XTransBox.Value;
                    paneldimetric.Refresh();
                }
            }
            else
            {
                if ((float)XTransBox.Value != bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X)
                {
                    bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X += (float)XTransBox.Value - bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].X;
                    bs.CountDrawPoints();
                    paneldimetric.Refresh();
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (AllSurfRB.Checked)
            {
                if ((decimal)TransVals.Y != YTransBox.Value)
                {
                    TransVals.Y = (float)YTransBox.Value;
                    paneldimetric.Refresh();
                }
            }
            else
            {
                if ((float)YTransBox.Value != bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y)
                {
                    bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y += (float)YTransBox.Value - bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Y;
                    bs.CountDrawPoints();
                    paneldimetric.Refresh();
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (AllSurfRB.Checked)
            {
                if ((decimal)TransVals.Z != ZTransBox.Value)
                {
                    TransVals.Z = (float)ZTransBox.Value;
                    paneldimetric.Refresh();
                }
            }
            else
            {
                if ((float)ZTransBox.Value != bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z)
                {
                    bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z += (float)ZTransBox.Value - bs.ControlPoints[RedactCPIndex.X, RedactCPIndex.Y].Z;
                    bs.CountDrawPoints();
                    paneldimetric.Refresh();
                }
            }
        }
    }
}

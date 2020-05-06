using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixLib;

namespace cg_lr3
{
    class BezierSurface
    {
        public static readonly Matrix BezierMatrix = new Matrix(
            new double[,]
            {
                { -1, 3,  -3, 1 },
                { 3,  -6, 3,  0 },
                { -3, 3,  0,  0 },
                { 1,  0,  0,  0 }
            }
            );

        private PointF3D[,] controlPoints;
        public PointF3D[,] ControlPoints 
        { 
            get => controlPoints; 
            set 
            { 
                if (value != null) 
                { 
                    controlPoints = value;
                    CountDrawPoints();
                } 
            } 
        }
        private double drawIncrement;
        public double DrawIncrement 
        { 
            get => drawIncrement; 
            set
            {
                if (value > 0 && value <= 1)
                {
                    drawIncrement = value;
                    CountDrawPoints();
                }
            }
        }

        private PointF3D[,] drawPoints;
        public PointF3D[,] DrawPoints { get => (PointF3D[,]) drawPoints.Clone(); }

        public BezierSurface(PointF3D[,] cntrlPoints, double increment = 0.1)
        {
            if (cntrlPoints.GetLength(0) != 4 || cntrlPoints.GetLength(1) != 4)
                throw new FormatException("Control points matrix must be 4*4");
            else
            {
                controlPoints = new PointF3D[4, 4];
                drawIncrement = increment;
                for (int r = 0; r < 4; r++)
                    for (int c = 0; c < 4; c++)
                    {
                        controlPoints[r, c] = cntrlPoints[r, c];
                    }
                CountDrawPoints();
            }
        }

        public void CountDrawPoints()
        {
            int pntCount = (int)Math.Ceiling(1 / drawIncrement) + 1;
            drawPoints = new PointF3D[pntCount, pntCount];

            Matrix S, T;

            Matrix Px = new Matrix(new double[4, 4]);
            Matrix Py = new Matrix(new double[4, 4]);
            Matrix Pz = new Matrix(new double[4, 4]);
            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                {
                    Px.SetElementValue((uint)r, (uint)c, controlPoints[r, c].X);
                    Py.SetElementValue((uint)r, (uint)c, controlPoints[r, c].Y);
                    Pz.SetElementValue((uint)r, (uint)c, controlPoints[r, c].Z);
                }
            Matrix TransBezier = BezierMatrix.Transposition();

            double t = 0, s = 0;
            for (int i = 0; i < pntCount; i++, t += drawIncrement)
            {
                T = FormTMatrix(t).Transposition();
                s = 0;
                for (int j = 0; j < pntCount; j++, s += drawIncrement)
                {
                    S = FormTMatrix(s);
                    drawPoints[i, j].X = (float)(S * BezierMatrix * Px * TransBezier * T).GetElementValue(0, 0);
                    drawPoints[i, j].Y = (float)(S * BezierMatrix * Py * TransBezier * T).GetElementValue(0, 0);
                    drawPoints[i, j].Z = (float)(S * BezierMatrix * Pz * TransBezier * T).GetElementValue(0, 0);
                }
            }

        }

        private Matrix FormTMatrix(double t)
        {
            if (t > 1)
                t = 1;
            else if (t < 0)
                t = 0;
            return new Matrix(new double[,] { { t * t * t, t * t, t, 1 } });
        }

        public PointF[] ProjectDimetric()
        {
            int PointCount = drawPoints.GetLength(0), curInd = 0;
            PointF3D[] Surfpoints = new PointF3D[PointCount * PointCount];

            for (int r = 0; r < PointCount; r++)
                for (int c = 0; c < PointCount; c++)
                {
                    curInd = r * PointCount + c;
                    Surfpoints[curInd] = drawPoints[r, c];
                }
            return Affinity3D.ProjectDimetric(Surfpoints);
        }

        public PointF[] ProjectXY()
        {
            int PointCount = drawPoints.GetLength(0), curInd = 0;
            PointF3D[] Surfpoints = new PointF3D[PointCount * PointCount];

            for (int r = 0; r < PointCount; r++)
                for (int c = 0; c < PointCount; c++)
                {
                    curInd = r * PointCount + c;
                    Surfpoints[curInd] = drawPoints[r, c];
                }

            return Affinity3D.ProjectToXY(Surfpoints);
        }

        public PointF[] ProjectYZ()
        {
            int PointCount = drawPoints.GetLength(0), curInd = 0;
            PointF3D[] Surfpoints = new PointF3D[PointCount * PointCount];

            for (int r = 0; r < PointCount; r++)
                for (int c = 0; c < PointCount; c++)
                {
                    curInd = r * PointCount + c;
                    Surfpoints[curInd] = drawPoints[r, c];
                }

            return Affinity3D.ProjectToYZ(Surfpoints);
        }

        public PointF[] ProjectZX()
        {
            int PointCount = drawPoints.GetLength(0), curInd = 0;
            PointF3D[] Surfpoints = new PointF3D[PointCount * PointCount];

            for (int r = 0; r < PointCount; r++)
                for (int c = 0; c < PointCount; c++)
                {
                    curInd = r * PointCount + c;
                    Surfpoints[curInd] = drawPoints[r, c];
                }

            return Affinity3D.ProjectToZX(Surfpoints);
        }

        public PointF3D[,] Translate(PointF3D translation)
        {
            PointF3D[] translated = new PointF3D[16];
            PointF3D[,] translatedTwoDim = new PointF3D[4, 4];

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    translated[r * 4 + c] = controlPoints[r, c];

            translated = Affinity3D.Translate3D(translated, translation.X, translation.Y, translation.Z);

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    translatedTwoDim[r, c] = translated[r * 4 + c];

            return translatedTwoDim;
        }

        public PointF3D[,] RotateX(float Angle, PointF3D RotCentre)
        {
            PointF3D[] rotated = new PointF3D[16];
            PointF3D[,] rotatedTwoDim = new PointF3D[4, 4];

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    rotated[r * 4 + c] = controlPoints[r, c];

            rotated = Affinity3D.RotateX3D(rotated, Angle, RotCentre);

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    rotatedTwoDim[r, c] = rotated[r * 4 + c];

            return rotatedTwoDim;
        }

        public PointF3D[,] RotateY(float Angle, PointF3D RotCentre)
        {
            PointF3D[] rotated = new PointF3D[16];
            PointF3D[,] rotatedTwoDim = new PointF3D[4, 4];

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    rotated[r * 4 + c] = controlPoints[r, c];

            rotated = Affinity3D.RotateY3D(rotated, Angle, RotCentre);

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    rotatedTwoDim[r, c] = rotated[r * 4 + c];

            return rotatedTwoDim;
        }

        public PointF3D[,] RotateZ(float Angle, PointF3D RotCentre)
        {
            PointF3D[] rotated = new PointF3D[16];
            PointF3D[,] rotatedTwoDim = new PointF3D[4, 4];

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    rotated[r * 4 + c] = controlPoints[r, c];

            rotated = Affinity3D.RotateZ3D(rotated, Angle, RotCentre);

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    rotatedTwoDim[r, c] = rotated[r * 4 + c];

            return rotatedTwoDim;
        }

        public PointF3D[,] Scale(PointF3D ScalVals, PointF3D ScalCentre)
        {
            PointF3D[] scaled = new PointF3D[16];
            PointF3D[,] scaledTwoDim = new PointF3D[4, 4];

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    scaled[r * 4 + c] = controlPoints[r, c];

            scaled = Affinity3D.Scale3D(scaled, ScalVals.X, ScalVals.Y, ScalVals.Z, ScalCentre);

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    scaledTwoDim[r, c] = scaled[r * 4 + c];

            return scaledTwoDim;
        }
    }
}

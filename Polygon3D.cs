using System.Drawing;

namespace cg_lr3
{
    struct Polygon3D
    {
        public PointF3D[] Outline { get; set; }

        public Polygon3D(PointF3D[] _outline)
        {
            Outline = _outline;
        }

        public PointF[] ProjectDimetric()
        {
            return Affinity3D.ProjectDimetric(Outline);
        }

        public PointF[] ProjectXY()
        {
            return Affinity3D.ProjectToXY(Outline);
        }

        public PointF[] ProjectYZ()
        {
            return Affinity3D.ProjectToYZ(Outline);
        }

        public PointF[] ProjectZX()
        {
            return Affinity3D.ProjectToZX(Outline);
        }

        public PointF3D[] Translate(PointF3D translation)
        {
            return Affinity3D.Translate3D(Outline, translation.X, translation.Y, translation.Z);
        }

        public PointF3D[] RotateX(float Angle, PointF3D RotCentre)
        {
            return Affinity3D.RotateX3D(Outline, Angle, RotCentre);
        }

        public PointF3D[] RotateY(float Angle, PointF3D RotCentre)
        {
            return Affinity3D.RotateY3D(Outline, Angle, RotCentre);
        }

        public PointF3D[] RotateZ(float Angle, PointF3D RotCentre)
        {
            return Affinity3D.RotateZ3D(Outline, Angle, RotCentre);
        }

        public PointF3D[] Scale(PointF3D ScalVals, PointF3D ScalCentre)
        {
            return Affinity3D.Scale3D(Outline, ScalVals.X, ScalVals.Y, ScalVals.Z, ScalCentre);
        }
    }
}

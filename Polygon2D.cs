using System.Drawing;

namespace cg_lr3
{
    struct Polygon2D
    {
        public PointF[] Outline { get; set; }

        public Polygon2D(PointF[] outline)
        {
            Outline = outline;
        }

        public PointF[] GetNormalisedOutline(float xmin, float xmax, float ymin, float ymax, Size screensize)
        {
            PointF[] normoutline = new PointF[Outline.Length];

            for (int i = 0; i < Outline.Length; i++)
            {
                normoutline[i].X = Normalisation.NormaliseX(Outline[i].X, xmin, xmax, screensize.Width);
                normoutline[i].Y = Normalisation.NormaliseY(Outline[i].Y, ymin, ymax, screensize.Height);
            }

            return normoutline;
        }

        
    }
}

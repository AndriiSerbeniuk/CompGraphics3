using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_lr3
{
    struct PointF3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }



        public PointF3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator == (PointF3D p1, PointF3D p2)
        {
            return (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z) ? true : false;
        }

        public static bool operator != (PointF3D p1, PointF3D p2)
        {
            return (p1.X != p2.X || p1.Y != p2.Y || p1.Z != p2.Z) ? true : false;
        }

    }
}

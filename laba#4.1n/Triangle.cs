using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class Triangle : Base
    {
        
        private float radius;
        
        private PointF[] pts = new PointF[3];

       
        public Triangle(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.radius = 30;
            pts[0] = new PointF(x, y - radius);
            pts[1] = new PointF(x - radius * MathF.Sqrt(3) / 2, y + radius / 2);
            pts[2] = new PointF(x + radius * MathF.Sqrt(3) / 2, y + radius / 2);
        }
        
        public override void draw(Graphics gr)
        {
            gr.FillPolygon(GetBrush(), pts);

            if (marked == true)
                gr.DrawPolygon(Pens.Orange, pts);
           
        }
        public override bool touched(int x, int y)
        {
            float m1 = (pts[0].X - x) * (pts[1].Y - pts[0].Y) - (pts[0].Y - y) * (pts[1].X - pts[0].X);
            float m2 = (pts[1].X - x) * (pts[2].Y - pts[1].Y) - (pts[1].Y - y) * (pts[2].X - pts[1].X);
            float m3 = (pts[2].X - x) * (pts[0].Y - pts[2].Y) - (pts[2].Y - y) * (pts[0].X - pts[2].X);
            return (m1 >= 0 && m2 >= 0 && m3 >= 0) || (m1 <= 0 && m2 <= 0 && m3 <= 0);

        }
        public override void move(int x, int y, int width, int height)
        {
            if (pts[1].X + x > 3 && pts[2].X + x < width - 15 && pts[0].Y + y > 3 && pts[1].Y + y < height - 25) 
            { 
            if(pts[1].X + x > 180 || pts[0].Y + y > 180) { 

            pts[0].X += x;
            pts[0].Y += y;
            pts[1].X += x;
            pts[1].Y += y;
            pts[2].X += x;
            pts[2].Y += y;
            }
            
            }
        }
        public override void changeSize(int num)
        {
            if(num == 1)
            {
                pts[0].Y -= 10;
                pts[1].X -= 10;
                pts[2].X += 10;
            }
            else if(num == -1) 
            {
                pts[0].Y += 10;
                pts[1].X += 10;
                pts[2].X -= 10;

            }
        }
    }
}

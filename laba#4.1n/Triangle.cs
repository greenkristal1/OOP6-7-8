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
        private float x;
        private float y;

        private PointF[] pts = new PointF[3];
        private SolidBrush brush = new SolidBrush(Color.Gray);
        protected bool marked = false;
        public Triangle(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.radius = 30;
            pts[0] = new PointF(x, y - radius);
            pts[1] = new PointF(x - radius * MathF.Sqrt(3) / 2, y + radius / 2);
            pts[2] = new PointF(x + radius * MathF.Sqrt(3) / 2, y + radius / 2);
            this.Name = "Triangle";
        }
        public override SolidBrush GetBrush()
        { return brush; }
        public override void draw(Graphics gr)
        {
            gr.FillPolygon(GetBrush(), pts);

            if (marked == true)
                gr.DrawPolygon(Pens.Orange, pts);
           
        }
        public override void mark()
        {
            marked = true;
        }
        public override void unmark()
        {
            marked = false;
        }
        public override bool is_marked()
        {
            if (marked == true) return true;
            else return false;
        }
        public override void setColor(Color color)
        {
            brush.Color = color;
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
        public override void save(StreamWriter st)
        {
            st.Write("Triangle\n");
            st.Write("The X is " + this.x + "\n");
            st.Write("The Y is " + this.y + "\n");
            st.Write("The Color is " + this.brush.Color + "\n");
            
        }
        public override void load(StreamReader st)
        {
            
            int x_s = Int32.Parse(st.ReadLine().Substring(9).Trim()); ;
            this.x = x_s;
            int y_s = Int32.Parse(st.ReadLine().Substring(9).Trim()); ;
            this.y = y_s;
            string color_s = (st.ReadLine().Substring(13).Trim());
            switch (color_s)
            {
                case "Blue]":
                    brush.Color = Color.Blue;
                    break;
                case "Green]":
                    brush.Color = Color.Green;
                    break;
                case "Pink]":
                    brush.Color = Color.Pink;
                    break;
                case "Gold]":
                    brush.Color = Color.Gold;
                    break;


            }

            this.x = x_s;
            this.y = y_s;
            pts[0] = new PointF(x, y - radius);
            pts[1] = new PointF(x - radius * MathF.Sqrt(3) / 2, y + radius / 2);
            pts[2] = new PointF(x + radius * MathF.Sqrt(3) / 2, y + radius / 2);

        }
    }
}

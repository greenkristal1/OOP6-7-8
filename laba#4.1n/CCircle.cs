using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class CCircle : Base
    {




        private int Radius;



        private int x;
        private int y;
        

        
        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Radius = 50;
            this.Name = "Circle";
            
            
        }

        public CCircle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.Radius = r;
            this.Name = "Circle";

        }


        public override void draw(Graphics gr)
        {
            
            gr.FillEllipse(GetBrush(), this.x - Radius / 2, this.y - Radius / 2, Radius, Radius);
            if (marked == true)
                gr.DrawEllipse(Pens.Orange, this.x - Radius / 2, this.y - Radius / 2, Radius, Radius);
           
            
        }

        public override bool touched(int x, int y)
        {
            if (x >= this.x - Radius / 2 && x <= this.x + Radius / 2 && y >= this.y - Radius / 2 && y <= this.y + Radius / 2)
                return true;
            else return false;

        }
        public override void move(int x, int y, int width, int height)
        {
            int chx = this.x + x;
            int chy = this.y + y;
            if (chx - Radius / 2 > 0 && chx + Radius / 2 < width && chy - Radius / 2 > 0 && chy + Radius / 2 < height) 
            { 
            if (chx > 200 || chy > 200)
            {
               this.x += x;
               this.y += y;
            }
           }
        }

        public override void changeSize(int num)
        {
            if(num == 1)
            {
                this.Radius += 10;
            }
            else if( num == -1)
            {
                this.Radius -= 10;
            }
        }

    }
}

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
        
      

       
        

        
        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Radius = 50;
            
            
        }

        public CCircle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.Radius = r;
           
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
            if (chx > 20 && chx < width-80 && chy > 25 && chy < height-100) 
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

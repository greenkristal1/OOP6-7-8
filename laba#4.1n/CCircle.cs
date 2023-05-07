using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class CCircle : Base
    {
       

       
        private int X { init; get; }
        private int Y { init; get; }
        private int Radius { init; get; }
        
      

       
        

        
        public CCircle(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Radius = 50;
            
            
        }

        public CCircle(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.Radius = r;
           
        }


        public override void draw(Graphics gr)
        {
            
            gr.FillEllipse(GetBrush(), X - Radius / 2, Y - Radius / 2, Radius, Radius);
            if (marked == true)
                gr.DrawEllipse(Pens.Orange, X - Radius / 2, Y - Radius / 2, Radius, Radius);
           
            
        }

        public override bool touched(int x, int y)
        {
            if (x >= this.X - Radius / 2 && x <= this.X + Radius / 2 && y >= this.Y - Radius / 2 && y <= this.Y + Radius / 2)
                return true;
            else return false;

        }

       


    }
}

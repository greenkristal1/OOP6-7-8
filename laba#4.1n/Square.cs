using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class Square : Base
    {
        private int X { init; get; }
        private int Y { init; get; }

        public Square(int x, int y) 
        { 
            this.X = x;
            this.Y = y;
                
        
        }

        public override void draw(Graphics gr)
        {
            gr.FillRectangle(GetBrush(), this.X - 25, this.Y - 25, 50, 50);
            if (marked == true)
                 gr.DrawRectangle(Pens.Orange, this.X-25, this.Y - 25, 50, 50);

            
        }

        //float x, float y, width, height
        public override bool touched(int x, int y)
        {
            if (x >= this.X-25 && x <= this.X + 25 && y >= this.Y -25 && y <= this.Y + 25) return true;
            else return false;
        }
    }
}

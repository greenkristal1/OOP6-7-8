using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class Section : Base
    {
       

        private int X { init; get; }

        private int Y { init; get; }

        public Section(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override void draw(Graphics gr)
        {
            
            if (marked == true)
                gr.FillRectangle(Brushes.Orange, X-75, Y, 150, 1 );
             gr.FillRectangle(GetBrush(), X-75, Y, 150, 1);//исправить здесь

        }
        public override bool touched(int x, int y)
        {
            if (x >= this.X - 75 && x <= this.X + 75 && y >= this.Y - 10 && y <= this.Y + 10)
            {
                return true;
                
            }
                
            else return false;
           
        }

        //float x, float y, width, height


    }
}

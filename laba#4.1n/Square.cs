using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class Square : Base
    {
        private int len;
       

        public Square(int x, int y) 
        { 
            this.x = x;
            this.y = y;
            this.len = 50;
        
        }

        public override void draw(Graphics gr)
        {
            gr.FillRectangle(GetBrush(), this.x - 25, this.y - 25, len, len);
            if (marked == true)
                 gr.DrawRectangle(Pens.Orange, this.x-25, this.y - 25, len, len);

            
        }

        //float x, float y, width, height
        public override bool touched(int x, int y)
        {
            if (x >= this.x-25 && x <= this.x + 25 && y >= this.y -25 && y <= this.y + 25) return true;
            else return false;
        }
        public override void move(int x, int y, int width, int height)
        {
            int chx = this.x + x;
            int chy = this.y + y;
            if (chx > 20 && chx < width - 80 && chy > 25 && chy < height - 100)
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
            if (num == 1)
                this.len += 10;
            else if(num == -1)
                this.len -= 10;
        }
    }
}

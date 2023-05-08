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
        private int x;
        private int y;
        private SolidBrush brush = new SolidBrush(Color.Gray);
        protected bool marked = false;
        public Square(int x, int y) 
        { 
            this.x = x;
            this.y = y;
            this.len = 50;
            this.Name = "Square";
        
        }
        public override SolidBrush GetBrush()
        { return brush; }

        public override void draw(Graphics gr)
        {
            gr.FillRectangle(GetBrush(), this.x - 25, this.y - 25, len, len);
            if (marked == true)
                 gr.DrawRectangle(Pens.Orange, this.x-25, this.y - 25, len, len);

            
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
            if (chx - 25 > 5 && chx + len < width - 5 && chy - 25 > 0 && chy + len < height )
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
        public override void save(StreamWriter st)
        {
            st.Write("Square\n");
            st.Write("Length = " + this.len.ToString() + "\n");
            st.Write("The X is " + this.x + "\n");
            st.Write("The Y is " + this.y + "\n");
            st.Write("The Color is " + this.brush.Color + "\n");

        }
        public override void load(StreamReader st)
        {
            
            int len_s = Int32.Parse(st.ReadLine().Substring(9).Trim());
            this.len = len_s;
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
        }
    }
}

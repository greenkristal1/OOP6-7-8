using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    abstract class Base
    {

        public string Name { get; init; }
        public void printName()
        {
            Console.WriteLine(Name);
        }
        private SolidBrush brush = new SolidBrush(Color.Gray);


        public SolidBrush GetBrush() { return brush; }
        protected bool marked = false;
        public abstract void draw(Graphics g);

        public void mark()
        {
            marked = true;
        }
        public  void unmark()
        {
            marked = false;
        }

        public abstract bool touched(int x, int y);
        public  bool is_marked()
        {
            if (marked == true) return true;
            else return false;
        }
        public void setColor(Color color)
        {
            brush.Color = color;
        }

        ~Base()
        {

        }
    }
}

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

       
    /*    public void printName()
        {
            Console.WriteLine(Name);
        }*/



        public abstract SolidBrush GetBrush(); 
        
        public abstract void draw(Graphics g);

        public abstract void mark();

        public abstract void unmark();
      

        public abstract bool touched(int x, int y);
        public abstract bool is_marked();
      
        public abstract void move(int x, int y, int width, int height);
       
        public abstract void changeSize(int num);

        public abstract void setColor(Color color);

        public abstract void save(StreamWriter st);
        public abstract void load(StreamReader st);
        ~Base()
        {

        }
    }
}

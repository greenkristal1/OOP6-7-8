using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    abstract class Base
    {

        private Observer obs = new Observer();
        public string Name { get; init; }

        public abstract int returnX();
        public abstract int returnY();
        public string returnName()
        {
            return Name;
            
        }
        public void onSubjectChanged(Graphics gr)
        {
            obs.notifyMarked(this, gr);
        }



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

        public abstract void drawArr(Graphics g, int a_x, int a_y);
        ~Base()
        {

        }
    }
}

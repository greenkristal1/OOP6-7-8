using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace laba_4._1n
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        bool ctrl_pressed = false;
        Storage st = new Storage(100);
        Graphics g;
        Color[] colors = new Color[] { Color.Blue, Color.Green, Color.Pink, Color.Gold, Color.Gray };
        int color_count = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (st.countRealObjects() > 0)
            {
                g = CreateGraphics();
                int i;
                for (i = 0; i < st.countRealObjects(); i++)
                {
                    Base t = st.getObject(i);
                    if (t != null)
                    {
                        t.unmark();
                        t.draw(g);
                    }
                }
                st.getObject(i - 1).mark();
                st.getObject(i - 1).draw(g);
            }
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < st.countRealObjects(); i++)
            {
                Base t = st.getObject(i);
                if (t != null)
                {


                    t.draw(g);
                }
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            this.Paint -= Form1_Paint;
            this.Paint += Form2_Paint;
            if (!ctrl_pressed)
            {
                for (int j = 0; j < st.countRealObjects(); j++)
                {

                    st.getObject(j).unmark();

                }
            }
            bool is_touched = false;
            for (int i = 0; i < st.countRealObjects(); i++)
            {

                Base t = st.getObject(i);
                if (t.touched(e.X, e.Y))
                {
                    t.mark();
                    is_touched = true;
                    if (!mark_more.Checked) break;


                }

            }
           
            if (is_touched) return;
            this.Paint -= Form2_Paint;
            this.Paint += Form1_Paint;

            if (rad_circle.Checked)
                st.setObject(new CCircle(e.X, e.Y));
            else if (rad_square.Checked)
                st.setObject(new Square(e.X, e.Y));
            else st.setObject(new Triangle(e.X, e.Y));




            this.Refresh();




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (ctrl_enabled.Checked)
            {
                if (e.Control) ctrl_pressed = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < st.countRealObjects(); i++)
                {
                    if (st.getObject(i).is_marked())
                    {

                        st.deleteObject(i);
                        --i;
                    }
                }
                if (st.countRealObjects() > 0)
                {
                    for (int i = st.getCount() - 1; i >= 0; i--)
                    {
                        if (st.getObject(i) != null)
                        {
                            st.getObject(i).mark();
                            break;
                        }
                    }
                }

                


            }
            if (e.KeyCode == Keys.F1)
            {

                for (int i = 0; i < st.countRealObjects(); i++)
                {
                    if (st.getObject(i).is_marked())
                    {
                        st.getObject(i).setColor(colors[color_count % 5]);
                    }
                }
               
                color_count++;

            }
            if (e.KeyCode == Keys.D)
            {

                for (int i = 0; i < st.countRealObjects(); i++)
                {

                    if (st.getObject(i).is_marked())
                    {
                        st.getObject(i).move(30, 0, this.Width, this.Height);
                    }
                }

            }
            if (e.KeyCode == Keys.W)
            {
                for (int i = 0; i < st.countRealObjects(); i++)
                {

                    if (st.getObject(i).is_marked())
                    {
                        st.getObject(i).move(0, -30, this.Width, this.Height);
                    }
                }

            }
            if (e.KeyCode == Keys.A)
            {

                for (int i = 0; i < st.countRealObjects(); i++)
                {

                    if (st.getObject(i).is_marked())
                    {
                        st.getObject(i).move(-30, 0, this.Width, this.Height);
                    }
                }

            }
            if (e.KeyCode == Keys.S)
            {
                for (int i = 0; i < st.countRealObjects(); i++)
                {

                    if (st.getObject(i).is_marked())
                    {
                        st.getObject(i).move(0, 30, this.Width, this.Height);
                    }
                }

            }
            if (e.KeyCode == Keys.Z)
            {
                for (int i = 0; i < st.countRealObjects(); i++)
                {

                    if (st.getObject(i).is_marked())
                    {
                        st.getObject(i).changeSize(1);
                    }
                }
            }
            if (e.KeyCode == Keys.X)
            {
                for (int i = 0; i < st.countRealObjects(); i++)
                {

                    if (st.getObject(i).is_marked())
                    {
                        st.getObject(i).changeSize(-1);
                    }
                }
            }
            this.Refresh();
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            ctrl_pressed = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
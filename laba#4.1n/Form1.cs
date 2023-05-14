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
            g = CreateGraphics();
            treeView1.CheckBoxes = true;
        }
        bool ctrl_pressed = false;
        Storage st = new Storage(100);
        Graphics g;
        int ind_a = -1;
        int ind_b = -1;

        Color[] colors = new Color[] { Color.Blue, Color.Green, Color.Pink, Color.Gold, Color.Gray };
        int color_count = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (st.countRealObjects() > 0)
            {

                int i;
                for (i = 0; i < st.countRealObjects(); i++)
                {
                    Base t = st.getObject(i);
                    if (t != null)
                    {
                        t.unmark();
                        treeView1.Nodes[i].Checked = false;
                        t.draw(g);

                    }
                }
               
                st.getObject(i - 1).mark();
                treeView1.Nodes[i - 1].Checked = true;
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
                    treeView1.Nodes[j].Checked = false;

                }
            }
            bool is_touched = false;
            for (int i = 0; i < st.countRealObjects(); i++)
            {

                Base t = st.getObject(i);
                if (t.touched(e.X, e.Y))
                {
                    t.mark();
                    treeView1.Nodes[i].Checked = true;
                    is_touched = true;
                    if (!mark_more.Checked) break;


                }

            }
            this.Refresh();
            if (is_touched) return;
            this.Paint -= Form2_Paint;
            this.Paint += Form1_Paint;

            if (rad_circle.Checked)
            {
                st.setObject(new CCircle(e.X, e.Y));
                treeView1.Nodes.Add("Circle");

            }
            else if (rad_square.Checked)
            {
                st.setObject(new Square(e.X, e.Y));
                treeView1.Nodes.Add("Square");
            }

            else
            {
                st.setObject(new Triangle(e.X, e.Y));
                treeView1.Nodes.Add("Triangle");

            }




            this.Refresh();




        }
        private void Form1_Arr_Paint(object sender, PaintEventArgs e)
        {
            if (st.countRealObjects() > 1)
            {
                if(ind_a != -1 && ind_b != -1)
                st.getObject(ind_b).drawArr(g, st.getObject(ind_a).returnX(), st.getObject(ind_a).returnY());
            }
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
                        if (i == ind_a) ind_a = -1;
                        if (i == ind_b) ind_b = -1;

                    }



                    }
                    for (int i = 0; i < st.countRealObjects(); i++)
                {
                    if (st.getObject(i).is_marked())
                    {
                        
                        st.deleteObject(i);
                        treeView1.Nodes[i].Remove();
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
            if(e.KeyCode == Keys.F2)
            {
                
                for(int i = 0; i < st.countRealObjects(); i++)
                {
                    if(st.getObject(i).is_marked()) {
                        ind_a = i;
                        break;
                    }
                }
            }
            if(e.KeyCode == Keys.F3)
            {
                
                for (int i = 0; i < st.countRealObjects(); i++)
                {
                    if (st.getObject(i).is_marked())
                    {
                        ind_b = i;
                        break;
                    }
                }
                if(ind_a != -1)
                this.Paint += Form1_Arr_Paint;
                





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
                        if (i == ind_a)
                        {
                            if (ind_b != -1) st.getObject(ind_b).move(30, 0, this.Width, this.Height);
                        }
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
                        if (i == ind_a)
                        {
                            if (ind_b != -1) st.getObject(ind_b).move(0, -30, this.Width, this.Height);
                        }
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
                        if(i == ind_a)
                        {
                            if (ind_b != -1) st.getObject(ind_b).move(-30, 0, this.Width, this.Height);
                        }
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
                        if (i == ind_a)
                        {
                            if (ind_b != -1) st.getObject(ind_b).move(0, 30, this.Width, this.Height);
                        }
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
            if (e.KeyCode == Keys.G)
            {
                Group gr = new Group();
                treeView1.Nodes.Add("Group");
                for (int i = 0, j = 0; i < st.countRealObjects(); i++)
                {
                    if (st.getObject(i).is_marked())
                    {
                       TreeNode tr_cl =  treeView1.Nodes[i].Clone() as TreeNode;
                        treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Add(tr_cl);
                        gr.addShape(st.getObject(i));
                    }


                }
                int del_count = 0;
                int real_count = st.countRealObjects();
                int item = 0;
                while (item < st.countRealObjects())
                {
                    if (st.getObject(item).is_marked())
                    {
                        treeView1.Nodes[item].Remove();
                        st.deleteObject(item);
                        continue;
                    }
                    item++;
                }

                /*for (int i = 0; i < real_count; i++)
                {
                    if (st.getObject(i).is_marked())
                    {
                        st.deleteObject(i - del_count);
                        del_count++;
                        
                    }


                }*/

                st.setObject(gr);
            }
            if (e.KeyCode == Keys.O)
            {

                StreamWriter wr = new StreamWriter("../../../../Figures.txt", false);
                st.saveShapes(wr);
                wr.Close();
            }
            if (e.KeyCode == Keys.L)
            {
                int init_c = st.countRealObjects();
                StreamReader rd = new StreamReader("../../../../Figures.txt");
                st.loadShape(rd);
                for(int i = init_c; i < st.countRealObjects(); i++)
                {
                    treeView1.Nodes.Add(st.getObject(i).returnName());
                    treeView1.Nodes[i].Checked = true;
                }
                rd.Close();
            }
            this.Refresh();
            mark_more.Text = st.countRealObjects().ToString();
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            ctrl_pressed = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            

        }
        public void nodeCh(TreeNode tn, int gr_ind)
        {
            for(int i = 0; i < tn.Nodes.Count; i++)
            {
                if (tn.Nodes[i].Text == "Group") nodeCh(tn.Nodes[i], gr_ind);
                if (tn.Nodes[i].Checked)
                {
                    st.getObject(gr_ind).onSubjectChanged(g);
                }
            }
        }
        public void treeCh(TreeView tr)
        {
            for(int i = 0; i < tr.Nodes.Count; i++)
            {
                TreeNode node = tr.Nodes[i];
                /*if(node.Text == "Group") treeCh(node);*/
                if (node.Text == "Group")
                {
                    nodeCh(node, i);
                }
                if (node.Checked)
                {
                    
                    st.getObject(i).onSubjectChanged(g);
                }
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < st.countRealObjects(); i++)
            {
                st.getObject(i).unmark();
            }
            g.Clear(Form.DefaultBackColor);
            for(int i = 0; i < treeView1.Nodes.Count - 1; i++)
            {
                treeCh(treeView1);

            }

            Form2_Paint(null, null);

        }
    }
}
namespace laba_4._1n
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Узел1");
            TreeNode treeNode2 = new TreeNode("Узел2");
            TreeNode treeNode3 = new TreeNode("Узел0", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Узел4");
            TreeNode treeNode5 = new TreeNode("Узел3", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Узел5");
            TreeNode treeNode7 = new TreeNode("Узел6");
            TreeNode treeNode8 = new TreeNode("Узел8");
            TreeNode treeNode9 = new TreeNode("Узел9");
            TreeNode treeNode10 = new TreeNode("Узел14");
            TreeNode treeNode11 = new TreeNode("круг", new TreeNode[] { treeNode10 });
            TreeNode treeNode12 = new TreeNode("Узел10", new TreeNode[] { treeNode11 });
            TreeNode treeNode13 = new TreeNode("Узел11");
            TreeNode treeNode14 = new TreeNode("Узел7", new TreeNode[] { treeNode8, treeNode9, treeNode12, treeNode13 });
            TreeNode treeNode15 = new TreeNode("Узел13");
            mark_more = new CheckBox();
            ctrl_enabled = new CheckBox();
            group_figures = new GroupBox();
            rad_square = new RadioButton();
            rad_triangle = new RadioButton();
            rad_circle = new RadioButton();
            treeView1 = new TreeView();
            group_figures.SuspendLayout();
            SuspendLayout();
            // 
            // mark_more
            // 
            mark_more.AutoSize = true;
            mark_more.Location = new Point(5, 131);
            mark_more.Name = "mark_more";
            mark_more.Size = new Size(101, 24);
            mark_more.TabIndex = 0;
            mark_more.Text = "Mul circles";
            mark_more.UseVisualStyleBackColor = true;
            // 
            // ctrl_enabled
            // 
            ctrl_enabled.AutoSize = true;
            ctrl_enabled.Location = new Point(5, 152);
            ctrl_enabled.Name = "ctrl_enabled";
            ctrl_enabled.Size = new Size(138, 24);
            ctrl_enabled.TabIndex = 1;
            ctrl_enabled.Text = "Control Enabled";
            ctrl_enabled.UseVisualStyleBackColor = true;
            // 
            // group_figures
            // 
            group_figures.Controls.Add(rad_square);
            group_figures.Controls.Add(rad_triangle);
            group_figures.Controls.Add(rad_circle);
            group_figures.Location = new Point(1, 2);
            group_figures.Name = "group_figures";
            group_figures.Size = new Size(160, 123);
            group_figures.TabIndex = 2;
            group_figures.TabStop = false;
            group_figures.Text = "Figures";
            // 
            // rad_square
            // 
            rad_square.AutoSize = true;
            rad_square.Location = new Point(22, 86);
            rad_square.Name = "rad_square";
            rad_square.Size = new Size(76, 24);
            rad_square.TabIndex = 3;
            rad_square.Text = "Square";
            rad_square.UseVisualStyleBackColor = true;
            // 
            // rad_triangle
            // 
            rad_triangle.AutoSize = true;
            rad_triangle.Location = new Point(22, 56);
            rad_triangle.Name = "rad_triangle";
            rad_triangle.Size = new Size(83, 24);
            rad_triangle.TabIndex = 2;
            rad_triangle.Text = "Triangle";
            rad_triangle.UseVisualStyleBackColor = true;
            // 
            // rad_circle
            // 
            rad_circle.AutoSize = true;
            rad_circle.Checked = true;
            rad_circle.Location = new Point(22, 26);
            rad_circle.Name = "rad_circle";
            rad_circle.Size = new Size(67, 24);
            rad_circle.TabIndex = 0;
            rad_circle.TabStop = true;
            rad_circle.Text = "Circle";
            rad_circle.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(953, 173);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Узел1";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Узел2";
            treeNode3.Name = "Узел0";
            treeNode3.Text = "Узел0";
            treeNode4.Name = "Узел4";
            treeNode4.Text = "Узел4";
            treeNode5.Name = "Узел3";
            treeNode5.Text = "Узел3";
            treeNode6.Name = "Узел5";
            treeNode6.Text = "Узел5";
            treeNode7.Name = "Узел6";
            treeNode7.Text = "Узел6";
            treeNode8.Name = "Узел8";
            treeNode8.Text = "Узел8";
            treeNode9.Name = "Узел9";
            treeNode9.Text = "Узел9";
            treeNode10.Name = "Узел14";
            treeNode10.Text = "Узел14";
            treeNode11.Name = "Узел12";
            treeNode11.Text = "круг";
            treeNode12.Name = "Узел10";
            treeNode12.Text = "Узел10";
            treeNode13.Name = "Узел11";
            treeNode13.Text = "Узел11";
            treeNode14.Name = "Узел7";
            treeNode14.Text = "Узел7";
            treeNode15.Name = "Узел13";
            treeNode15.Text = "Узел13";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode5, treeNode6, treeNode7, treeNode14, treeNode15 });
            treeView1.Size = new Size(151, 121);
            treeView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 715);
            Controls.Add(treeView1);
            Controls.Add(group_figures);
            Controls.Add(ctrl_enabled);
            Controls.Add(mark_more);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            MouseClick += Form1_MouseClick;
            group_figures.ResumeLayout(false);
            group_figures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox mark_more;
        private CheckBox ctrl_enabled;
        private GroupBox group_figures;
        private RadioButton rad_square;
        private RadioButton rad_triangle;
        private RadioButton rad_circle;
        private TreeView treeView1;
    }
}
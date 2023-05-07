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
            mark_more = new CheckBox();
            ctrl_enabled = new CheckBox();
            group_figures = new GroupBox();
            rad_section = new RadioButton();
            rad_square = new RadioButton();
            rad_triangle = new RadioButton();
            rad_circle = new RadioButton();
            group_figures.SuspendLayout();
            SuspendLayout();
            // 
            // mark_more
            // 
            mark_more.AutoSize = true;
            mark_more.Location = new Point(1111, 51);
            mark_more.Name = "mark_more";
            mark_more.Size = new Size(101, 24);
            mark_more.TabIndex = 0;
            mark_more.Text = "Mul circles";
            mark_more.UseVisualStyleBackColor = true;
            // 
            // ctrl_enabled
            // 
            ctrl_enabled.AutoSize = true;
            ctrl_enabled.Location = new Point(1111, 111);
            ctrl_enabled.Name = "ctrl_enabled";
            ctrl_enabled.Size = new Size(138, 24);
            ctrl_enabled.TabIndex = 1;
            ctrl_enabled.Text = "Control Enabled";
            ctrl_enabled.UseVisualStyleBackColor = true;
            // 
            // group_figures
            // 
            group_figures.Controls.Add(rad_section);
            group_figures.Controls.Add(rad_square);
            group_figures.Controls.Add(rad_triangle);
            group_figures.Controls.Add(rad_circle);
            group_figures.Location = new Point(1089, 174);
            group_figures.Name = "group_figures";
            group_figures.Size = new Size(160, 160);
            group_figures.TabIndex = 2;
            group_figures.TabStop = false;
            group_figures.Text = "Figures";
            // 
            // rad_section
            // 
            rad_section.AutoSize = true;
            rad_section.Location = new Point(20, 56);
            rad_section.Name = "rad_section";
            rad_section.Size = new Size(79, 24);
            rad_section.TabIndex = 1;
            rad_section.Text = "Section";
            rad_section.UseVisualStyleBackColor = true;
            // 
            // rad_square
            // 
            rad_square.AutoSize = true;
            rad_square.Location = new Point(20, 116);
            rad_square.Name = "rad_square";
            rad_square.Size = new Size(76, 24);
            rad_square.TabIndex = 3;
            rad_square.Text = "Square";
            rad_square.UseVisualStyleBackColor = true;
            // 
            // rad_triangle
            // 
            rad_triangle.AutoSize = true;
            rad_triangle.Location = new Point(20, 86);
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
            rad_circle.Location = new Point(20, 26);
            rad_circle.Name = "rad_circle";
            rad_circle.Size = new Size(67, 24);
            rad_circle.TabIndex = 0;
            rad_circle.TabStop = true;
            rad_circle.Text = "Circle";
            rad_circle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 715);
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
        private RadioButton rad_section;
        private RadioButton rad_square;
        private RadioButton rad_triangle;
        private RadioButton rad_circle;
    }
}
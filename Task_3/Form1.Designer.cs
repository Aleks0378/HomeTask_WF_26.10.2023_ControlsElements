namespace Task_3
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
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            yearTextBox = new TextBox();
            monthTextBox = new TextBox();
            dayTextBox = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(257, 27);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 261);
            button1.Name = "button1";
            button1.Size = new Size(474, 40);
            button1.TabIndex = 3;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 261);
            panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(yearTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(monthTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dayTextBox);
            groupBox1.Location = new Point(26, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 207);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Birthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 120);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 5;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Month";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Day";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(68, 117);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(94, 27);
            yearTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(68, 75);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(94, 27);
            monthTextBox.TabIndex = 2;
            // 
            // dayTextBox
            // 
            dayTextBox.Location = new Point(68, 32);
            dayTextBox.Name = "dayTextBox";
            dayTextBox.Size = new Size(94, 27);
            dayTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 301);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox yearTextBox;
        private TextBox monthTextBox;
        private TextBox dayTextBox;
    }
}
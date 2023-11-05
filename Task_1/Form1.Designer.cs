namespace Task_1
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
            panel1 = new Panel();
            button1 = new Button();
            matrixCombobox = new ComboBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 320);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 324);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // matrixCombobox
            // 
            matrixCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            matrixCombobox.FormattingEnabled = true;
            matrixCombobox.Location = new Point(308, 324);
            matrixCombobox.Name = "matrixCombobox";
            matrixCombobox.Size = new Size(151, 28);
            matrixCombobox.TabIndex = 2;
            matrixCombobox.SelectedIndexChanged += matrixCombobox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 353);
            Controls.Add(matrixCombobox);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private ComboBox matrixCombobox;
    }
}
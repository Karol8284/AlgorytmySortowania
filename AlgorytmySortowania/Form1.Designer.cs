namespace AlgorytmySortowania
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
            components = new System.ComponentModel.Container();
            B_Add = new Button();
            textBox1 = new TextBox();
            L_ToSort = new ListBox();
            numericUpDown1 = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            B_Sort = new Button();
            L_Sorted = new ListBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // B_Add
            // 
            B_Add.Location = new Point(411, 423);
            B_Add.Name = "B_Add";
            B_Add.Size = new Size(149, 87);
            B_Add.TabIndex = 0;
            B_Add.Text = "Dodaj";
            B_Add.UseVisualStyleBackColor = true;
            B_Add.Click += B_Add_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 177);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // L_ToSort
            // 
            L_ToSort.FormattingEnabled = true;
            L_ToSort.Location = new Point(24, 20);
            L_ToSort.Margin = new Padding(4, 5, 4, 5);
            L_ToSort.Name = "L_ToSort";
            L_ToSort.Size = new Size(231, 1104);
            L_ToSort.TabIndex = 2;
            L_ToSort.SelectedIndexChanged += L_ToSort_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(409, 218);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(387, 31);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // B_Sort
            // 
            B_Sort.Location = new Point(650, 423);
            B_Sort.Name = "B_Sort";
            B_Sort.Size = new Size(149, 87);
            B_Sort.TabIndex = 5;
            B_Sort.Text = "Sortuj";
            B_Sort.UseVisualStyleBackColor = true;
            B_Sort.Click += B_Sort_Click;
            // 
            // L_Sorted
            // 
            L_Sorted.FormattingEnabled = true;
            L_Sorted.Location = new Point(983, 20);
            L_Sorted.Margin = new Padding(4, 5, 4, 5);
            L_Sorted.Name = "L_Sorted";
            L_Sorted.Size = new Size(231, 1104);
            L_Sorted.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 25);
            label1.TabIndex = 7;
            label1.Text = "Podaj wartość nowego elementu do listy";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(614, 257);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 1188);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(L_Sorted);
            Controls.Add(B_Sort);
            Controls.Add(numericUpDown1);
            Controls.Add(L_ToSort);
            Controls.Add(textBox1);
            Controls.Add(B_Add);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button B_Add;
        private TextBox textBox1;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
        private ContextMenuStrip contextMenuStrip1;
        private Button B_Sort;
        private ListBox L_Sorted;
        private ListBox L_ToSort;
        private Label label1;
        private ComboBox comboBox1;
    }
}

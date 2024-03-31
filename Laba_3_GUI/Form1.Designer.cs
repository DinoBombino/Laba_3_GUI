namespace Laba_3_GUI
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtResult = new TextBox();
            cmbOperation = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            buttonClear = new Button();
            cmBox1 = new ComboBox();
            cmBox2 = new ComboBox();
            cmBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(611, 90);
            label1.TabIndex = 0;
            label1.Text = "Мера объема, задаваемая в виде пары (значение, тип), допустимые типы: м^3, миллилитры, литры, баррель\r\n-сложение\r\n-вычитание\r\n-умножение на число\r\n-сравнение двух объемов\r\n-вывод значения в любом типе";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += onValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += onValueChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(80, 203);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 3;
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperation.Location = new Point(131, 107);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(49, 23);
            cmbOperation.TabIndex = 4;
            cmbOperation.Text = "+";
            cmbOperation.SelectedIndexChanged += onValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 5;
            label2.Text = "Выбирете действие";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 206);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Ответ";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ControlDark;
            buttonClear.Location = new Point(80, 232);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(100, 23);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Clear All";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // cmBox1
            // 
            cmBox1.FormattingEnabled = true;
            cmBox1.Location = new Point(186, 145);
            cmBox1.Name = "cmBox1";
            cmBox1.Size = new Size(51, 23);
            cmBox1.TabIndex = 8;
            cmBox1.SelectedIndexChanged += onValueChanged;
            // 
            // cmBox2
            // 
            cmBox2.FormattingEnabled = true;
            cmBox2.Location = new Point(186, 174);
            cmBox2.Name = "cmBox2";
            cmBox2.Size = new Size(51, 23);
            cmBox2.TabIndex = 9;
            cmBox2.SelectedIndexChanged += onValueChanged;
            // 
            // cmBox3
            // 
            cmBox3.FormattingEnabled = true;
            cmBox3.Location = new Point(186, 203);
            cmBox3.Name = "cmBox3";
            cmBox3.Size = new Size(51, 23);
            cmBox3.TabIndex = 10;
            cmBox3.SelectedIndexChanged += onValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 266);
            Controls.Add(cmBox3);
            Controls.Add(cmBox2);
            Controls.Add(cmBox1);
            Controls.Add(buttonClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbOperation);
            Controls.Add(txtResult);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtResult;
        private ComboBox cmbOperation;
        private Label label2;
        private Label label3;
        private Button buttonClear;
        private ComboBox cmBox1;
        private ComboBox cmBox2;
        private ComboBox cmBox3;
    }
}

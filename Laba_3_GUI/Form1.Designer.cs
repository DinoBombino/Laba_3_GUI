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
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ComparisonBox1 = new ComboBox();
            ComparisonBox2 = new ComboBox();
            label5 = new Label();
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
            cmbOperation.Items.AddRange(new object[] { "+", "-", "* на число" });
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
            // textBox3
            // 
            textBox3.Location = new Point(186, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(51, 23);
            textBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 110);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "<-- Число";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(350, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(49, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += onCompareValues;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(462, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(42, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += onCompareValues;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(510, 157);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(49, 23);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += onCompareValues;
            // 
            // ComparisonBox1
            // 
            ComparisonBox1.FormattingEnabled = true;
            ComparisonBox1.Items.AddRange(new object[] { "м3", "мл", "л", "б" });
            ComparisonBox1.Location = new Point(405, 157);
            ComparisonBox1.Name = "ComparisonBox1";
            ComparisonBox1.Size = new Size(51, 23);
            ComparisonBox1.TabIndex = 16;
            ComparisonBox1.SelectedIndexChanged += onCompareValues;
            // 
            // ComparisonBox2
            // 
            ComparisonBox2.FormattingEnabled = true;
            ComparisonBox2.Items.AddRange(new object[] { "м3", "мл", "л", "б" });
            ComparisonBox2.Location = new Point(565, 157);
            ComparisonBox2.Name = "ComparisonBox2";
            ComparisonBox2.Size = new Size(51, 23);
            ComparisonBox2.TabIndex = 17;
            ComparisonBox2.SelectedIndexChanged += onCompareValues;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 130);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 18;
            label5.Text = "Сравнение чисел";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 266);
            Controls.Add(label5);
            Controls.Add(ComparisonBox2);
            Controls.Add(ComparisonBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
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
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox ComparisonBox1;
        private ComboBox ComparisonBox2;
        private Label label5;
    }
}

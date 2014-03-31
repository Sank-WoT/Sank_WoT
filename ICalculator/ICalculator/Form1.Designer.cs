namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.firstField = new System.Windows.Forms.TextBox();
            this.secondField = new System.Windows.Forms.TextBox();
            this.resultField = new System.Windows.Forms.Label();
            this.involution = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.Napierian = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.logx = new System.Windows.Forms.Button();
            this.arctg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(21, 184);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(34, 30);
            this.subtraction.TabIndex = 0;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.substraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(21, 220);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(34, 30);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(72, 184);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(34, 30);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(72, 220);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(34, 30);
            this.division.TabIndex = 4;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // firstField
            // 
            this.firstField.Location = new System.Drawing.Point(21, 37);
            this.firstField.Name = "firstField";
            this.firstField.Size = new System.Drawing.Size(212, 20);
            this.firstField.TabIndex = 5;
            // 
            // secondField
            // 
            this.secondField.Location = new System.Drawing.Point(21, 82);
            this.secondField.Name = "secondField";
            this.secondField.Size = new System.Drawing.Size(212, 20);
            this.secondField.TabIndex = 6;
            // 
            // resultField
            // 
            this.resultField.AutoSize = true;
            this.resultField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultField.Location = new System.Drawing.Point(17, 127);
            this.resultField.Name = "resultField";
            this.resultField.Size = new System.Drawing.Size(48, 20);
            this.resultField.TabIndex = 7;
            this.resultField.Text = "result";
            // 
            // involution
            // 
            this.involution.Location = new System.Drawing.Point(125, 184);
            this.involution.Name = "involution";
            this.involution.Size = new System.Drawing.Size(34, 30);
            this.involution.TabIndex = 8;
            this.involution.Text = "^";
            this.involution.UseVisualStyleBackColor = true;
            this.involution.Click += new System.EventHandler(this.involution_Click_1);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(125, 220);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(34, 30);
            this.sqrt.TabIndex = 9;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // Napierian
            // 
            this.Napierian.Location = new System.Drawing.Point(183, 184);
            this.Napierian.Name = "Napierian";
            this.Napierian.Size = new System.Drawing.Size(34, 30);
            this.Napierian.TabIndex = 10;
            this.Napierian.Text = "e^x";
            this.Napierian.UseVisualStyleBackColor = true;
            this.Napierian.Click += new System.EventHandler(this.Napierian_Click);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(241, 184);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(70, 30);
            this.arcsin.TabIndex = 11;
            this.arcsin.Text = "arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.arcsin_Click);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(241, 220);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(70, 30);
            this.arccos.TabIndex = 12;
            this.arccos.Text = "arccos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.arccos_Click);
            // 
            // logx
            // 
            this.logx.Location = new System.Drawing.Point(241, 256);
            this.logx.Name = "logx";
            this.logx.Size = new System.Drawing.Size(70, 30);
            this.logx.TabIndex = 13;
            this.logx.Text = "log2(x)";
            this.logx.UseVisualStyleBackColor = true;
            this.logx.Click += new System.EventHandler(this.logx_Click);
            // 
            // arctg
            // 
            this.arctg.Location = new System.Drawing.Point(241, 292);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(70, 30);
            this.arctg.TabIndex = 14;
            this.arctg.Text = "arctg(x)";
            this.arctg.UseVisualStyleBackColor = true;
            this.arctg.Click += new System.EventHandler(this.arctg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 340);
            this.Controls.Add(this.arctg);
            this.Controls.Add(this.logx);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.Napierian);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.involution);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.secondField);
            this.Controls.Add(this.firstField);
            this.Controls.Add(this.division);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.MenuHighlight;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox firstField;
        private System.Windows.Forms.TextBox secondField;
        private System.Windows.Forms.Label resultField;
        private System.Windows.Forms.Button involution;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button Napierian;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button logx;
        private System.Windows.Forms.Button arctg;

    }
}


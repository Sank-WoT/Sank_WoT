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
            this.multiplication.Location = new System.Drawing.Point(21, 229);
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
            this.division.Location = new System.Drawing.Point(72, 229);
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
            this.firstField.Size = new System.Drawing.Size(127, 20);
            this.firstField.TabIndex = 5;
            // 
            // secondField
            // 
            this.secondField.Location = new System.Drawing.Point(21, 82);
            this.secondField.Name = "secondField";
            this.secondField.Size = new System.Drawing.Size(127, 20);
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
            this.sqrt.Location = new System.Drawing.Point(125, 229);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(33, 29);
            this.sqrt.TabIndex = 9;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 290);
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

    }
}


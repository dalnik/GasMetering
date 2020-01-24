namespace GasMetering
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtGasPoint = new System.Windows.Forms.TextBox();
            this.txtMetering = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(191, 35);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(273, 22);
            this.txtMonth.TabIndex = 0;
            this.txtMonth.Text = "Input Month";
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            // 
            // txtGasPoint
            // 
            this.txtGasPoint.Location = new System.Drawing.Point(191, 81);
            this.txtGasPoint.Name = "txtGasPoint";
            this.txtGasPoint.Size = new System.Drawing.Size(273, 22);
            this.txtGasPoint.TabIndex = 1;
            this.txtGasPoint.Text = "Input Metering";
            this.txtGasPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGasPoint.TextChanged += new System.EventHandler(this.txtGasPoint_TextChanged);
            // 
            // txtMetering
            // 
            this.txtMetering.Location = new System.Drawing.Point(191, 123);
            this.txtMetering.Name = "txtMetering";
            this.txtMetering.Size = new System.Drawing.Size(273, 22);
            this.txtMetering.TabIndex = 2;
            this.txtMetering.TextChanged += new System.EventHandler(this.txtMetering_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 107);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMetering);
            this.Controls.Add(this.txtGasPoint);
            this.Controls.Add(this.txtMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtGasPoint;
        private System.Windows.Forms.TextBox txtMetering;
        private System.Windows.Forms.Button btnSave;
    }
}


namespace MessageBox
{
    partial class WinAPIClass
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
            this.btnABORTRETRYIGNORE = new System.Windows.Forms.Button();
            this.btnYESNOCANCEL = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnYESNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABORTRETRYIGNORE
            // 
            this.btnABORTRETRYIGNORE.Location = new System.Drawing.Point(24, 25);
            this.btnABORTRETRYIGNORE.Name = "btnABORTRETRYIGNORE";
            this.btnABORTRETRYIGNORE.Size = new System.Drawing.Size(239, 23);
            this.btnABORTRETRYIGNORE.TabIndex = 0;
            this.btnABORTRETRYIGNORE.Text = "Прервать Повторить Пропустить";
            this.btnABORTRETRYIGNORE.UseVisualStyleBackColor = true;
            this.btnABORTRETRYIGNORE.Click += new System.EventHandler(this.btnABORTRETRYIGNORE_Click);
            // 
            // btnYESNOCANCEL
            // 
            this.btnYESNOCANCEL.Location = new System.Drawing.Point(24, 73);
            this.btnYESNOCANCEL.Name = "btnYESNOCANCEL";
            this.btnYESNOCANCEL.Size = new System.Drawing.Size(239, 23);
            this.btnYESNOCANCEL.TabIndex = 1;
            this.btnYESNOCANCEL.Text = "Да Нет Отмена";
            this.btnYESNOCANCEL.UseVisualStyleBackColor = true;
            this.btnYESNOCANCEL.Click += new System.EventHandler(this.btnYESNOCANCEL_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(24, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(239, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnYESNO
            // 
            this.btnYESNO.Location = new System.Drawing.Point(24, 170);
            this.btnYESNO.Name = "btnYESNO";
            this.btnYESNO.Size = new System.Drawing.Size(239, 23);
            this.btnYESNO.TabIndex = 3;
            this.btnYESNO.Text = "Да Нет";
            this.btnYESNO.UseVisualStyleBackColor = true;
            this.btnYESNO.Click += new System.EventHandler(this.btnYESNO_Click);
            // 
            // WinAPIClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.btnYESNO);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnYESNOCANCEL);
            this.Controls.Add(this.btnABORTRETRYIGNORE);
            this.Name = "WinAPIClass";
            this.Text = "Message Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABORTRETRYIGNORE;
        private System.Windows.Forms.Button btnYESNOCANCEL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnYESNO;
    }
}


namespace PodyglomAxis
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
            this.components = new System.ComponentModel.Container();
            this.axis1 = new myUCLib.Axis();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // axis1
            // 
            this.axis1.axis_bkcolor = System.Drawing.Color.White;
            this.axis1.axis_color = System.Drawing.Color.Gray;
            this.axis1.Axis_Type = ((byte)(1));
            this.axis1.E_x = 0;
            this.axis1.E_y = 0;
            this.axis1.Location = new System.Drawing.Point(36, 134);
            this.axis1.Name = "axis1";
            this.axis1.Pix_color = System.Drawing.Color.Black;
            this.axis1.Pix_Size = 2F;
            this.axis1.Pix_type = ((byte)(1));
            this.axis1.Size = new System.Drawing.Size(715, 289);
            this.axis1.TabIndex = 0;
            this.axis1.x_Base = 1F;
            this.axis1.x_Name = "X";
            this.axis1.y_Base = 1F;
            this.axis1.y_Name = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axis1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private myUCLib.Axis axis1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}


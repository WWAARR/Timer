namespace DZ
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
            this.btnStart = new System.Windows.Forms.Button();
            this.TimeTable = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.MoreH = new System.Windows.Forms.Button();
            this.MoreM = new System.Windows.Forms.Button();
            this.MoreS = new System.Windows.Forms.Button();
            this.Dead = new System.Windows.Forms.Button();
            this.MinTimeTable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(12, 82);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 53);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TimeTable
            // 
            this.TimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTable.Location = new System.Drawing.Point(12, 12);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.ReadOnly = true;
            this.TimeTable.Size = new System.Drawing.Size(336, 53);
            this.TimeTable.TabIndex = 1;
            this.TimeTable.Text = "00:00:00";
            this.TimeTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(128, 82);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 53);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(249, 82);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 53);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MoreH
            // 
            this.MoreH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreH.Location = new System.Drawing.Point(12, 236);
            this.MoreH.Name = "MoreH";
            this.MoreH.Size = new System.Drawing.Size(99, 53);
            this.MoreH.TabIndex = 2;
            this.MoreH.Text = "H++";
            this.MoreH.UseVisualStyleBackColor = true;
            this.MoreH.Click += new System.EventHandler(this.MoreH_Click);
            // 
            // MoreM
            // 
            this.MoreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreM.Location = new System.Drawing.Point(128, 236);
            this.MoreM.Name = "MoreM";
            this.MoreM.Size = new System.Drawing.Size(99, 53);
            this.MoreM.TabIndex = 3;
            this.MoreM.Text = "M++";
            this.MoreM.UseVisualStyleBackColor = true;
            this.MoreM.Click += new System.EventHandler(this.MoreM_Click);
            // 
            // MoreS
            // 
            this.MoreS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreS.Location = new System.Drawing.Point(249, 236);
            this.MoreS.Name = "MoreS";
            this.MoreS.Size = new System.Drawing.Size(99, 53);
            this.MoreS.TabIndex = 4;
            this.MoreS.Text = "S++";
            this.MoreS.UseVisualStyleBackColor = true;
            this.MoreS.Click += new System.EventHandler(this.MoreS_Click);
            // 
            // Dead
            // 
            this.Dead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dead.Location = new System.Drawing.Point(249, 156);
            this.Dead.Name = "Dead";
            this.Dead.Size = new System.Drawing.Size(99, 53);
            this.Dead.TabIndex = 5;
            this.Dead.Text = "Timer start";
            this.Dead.UseVisualStyleBackColor = true;
            this.Dead.Click += new System.EventHandler(this.Dead_Click);
            // 
            // MinTimeTable
            // 
            this.MinTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinTimeTable.Location = new System.Drawing.Point(12, 156);
            this.MinTimeTable.Name = "MinTimeTable";
            this.MinTimeTable.ReadOnly = true;
            this.MinTimeTable.Size = new System.Drawing.Size(215, 53);
            this.MinTimeTable.TabIndex = 6;
            this.MinTimeTable.Text = "00:00:00";
            this.MinTimeTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 301);
            this.Controls.Add(this.MinTimeTable);
            this.Controls.Add(this.Dead);
            this.Controls.Add(this.MoreS);
            this.Controls.Add(this.MoreM);
            this.Controls.Add(this.MoreH);
            this.Controls.Add(this.TimeTable);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Something";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox TimeTable;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button MoreH;
        private System.Windows.Forms.Button MoreM;
        private System.Windows.Forms.Button MoreS;
        private System.Windows.Forms.Button Dead;
        private System.Windows.Forms.TextBox MinTimeTable;
    }
}


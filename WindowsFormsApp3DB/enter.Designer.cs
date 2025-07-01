namespace WindowsFormsApp3DB
{
    partial class enter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dolg = new System.Windows.Forms.NumericUpDown();
            this.sotr = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dolg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(150, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход для сотрудников:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(34, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите ваш уникальный код:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(34, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код вашей должности:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(249, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dolg
            // 
            this.dolg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dolg.Location = new System.Drawing.Point(440, 276);
            this.dolg.Name = "dolg";
            this.dolg.Size = new System.Drawing.Size(110, 38);
            this.dolg.TabIndex = 3;
            this.dolg.ValueChanged += new System.EventHandler(this.dolg_ValueChanged);
            // 
            // sotr
            // 
            this.sotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sotr.Location = new System.Drawing.Point(552, 167);
            this.sotr.Name = "sotr";
            this.sotr.Size = new System.Drawing.Size(120, 38);
            this.sotr.TabIndex = 4;
            this.sotr.ValueChanged += new System.EventHandler(this.sotr_ValueChanged);
            // 
            // enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sotr);
            this.Controls.Add(this.dolg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "enter";
            this.Text = "enter";
            this.Load += new System.EventHandler(this.enter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dolg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown dolg;
        private System.Windows.Forms.NumericUpDown sotr;
    }
}
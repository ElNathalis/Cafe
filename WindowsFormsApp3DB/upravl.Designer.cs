namespace WindowsFormsApp3DB
{
    partial class upravl
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
            this.upravlsotr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insertsotr = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vsepost = new System.Windows.Forms.Button();
            this.newpost = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.audit = new System.Windows.Forms.Button();
            this.anal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // upravlsotr
            // 
            this.upravlsotr.BackColor = System.Drawing.Color.SaddleBrown;
            this.upravlsotr.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upravlsotr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.upravlsotr.Location = new System.Drawing.Point(360, 49);
            this.upravlsotr.Name = "upravlsotr";
            this.upravlsotr.Size = new System.Drawing.Size(162, 60);
            this.upravlsotr.TabIndex = 0;
            this.upravlsotr.Text = "Список сотрудников";
            this.upravlsotr.UseVisualStyleBackColor = false;
            this.upravlsotr.Click += new System.EventHandler(this.upravlsotr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insertsotr);
            this.groupBox1.Controls.Add(this.upravlsotr);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление персоналом";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // insertsotr
            // 
            this.insertsotr.BackColor = System.Drawing.Color.SaddleBrown;
            this.insertsotr.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertsotr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insertsotr.Location = new System.Drawing.Point(171, 49);
            this.insertsotr.Name = "insertsotr";
            this.insertsotr.Size = new System.Drawing.Size(171, 62);
            this.insertsotr.TabIndex = 1;
            this.insertsotr.Text = "добавить сотрудника";
            this.insertsotr.UseVisualStyleBackColor = false;
            this.insertsotr.Click += new System.EventHandler(this.insertsotr_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.vsepost);
            this.groupBox2.Controls.Add(this.newpost);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(70, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поставки";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(19, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "редактор";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vsepost
            // 
            this.vsepost.BackColor = System.Drawing.Color.SaddleBrown;
            this.vsepost.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsepost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vsepost.Location = new System.Drawing.Point(172, 32);
            this.vsepost.Name = "vsepost";
            this.vsepost.Size = new System.Drawing.Size(170, 62);
            this.vsepost.TabIndex = 1;
            this.vsepost.Text = "все поставки";
            this.vsepost.UseVisualStyleBackColor = false;
            this.vsepost.Click += new System.EventHandler(this.vsepost_Click);
            // 
            // newpost
            // 
            this.newpost.BackColor = System.Drawing.Color.SaddleBrown;
            this.newpost.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpost.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.newpost.Location = new System.Drawing.Point(360, 32);
            this.newpost.Name = "newpost";
            this.newpost.Size = new System.Drawing.Size(162, 62);
            this.newpost.TabIndex = 0;
            this.newpost.Text = "новая поставка";
            this.newpost.UseVisualStyleBackColor = false;
            this.newpost.Click += new System.EventHandler(this.newpost_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.audit);
            this.groupBox3.Controls.Add(this.anal);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(70, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 118);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Аналитика";
            // 
            // audit
            // 
            this.audit.BackColor = System.Drawing.Color.SaddleBrown;
            this.audit.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.audit.Location = new System.Drawing.Point(172, 39);
            this.audit.Name = "audit";
            this.audit.Size = new System.Drawing.Size(170, 61);
            this.audit.TabIndex = 5;
            this.audit.Text = "средние цены по категориям ";
            this.audit.UseVisualStyleBackColor = false;
            this.audit.Click += new System.EventHandler(this.audit_Click);
            // 
            // anal
            // 
            this.anal.BackColor = System.Drawing.Color.SaddleBrown;
            this.anal.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anal.Location = new System.Drawing.Point(360, 39);
            this.anal.Name = "anal";
            this.anal.Size = new System.Drawing.Size(162, 61);
            this.anal.TabIndex = 4;
            this.anal.Text = "диаграмма зарплат";
            this.anal.UseVisualStyleBackColor = false;
            this.anal.Click += new System.EventHandler(this.anal_Click);
            // 
            // upravl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(676, 469);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "upravl";
            this.Text = "upravl";
            this.Load += new System.EventHandler(this.upravl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upravlsotr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insertsotr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button vsepost;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button anal;
        private System.Windows.Forms.Button audit;
        private System.Windows.Forms.Button newpost;
        private System.Windows.Forms.Button button1;
    }
}
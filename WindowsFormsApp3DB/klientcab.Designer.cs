namespace WindowsFormsApp3DB
{
    partial class klientcab
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
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblnameKlient = new System.Windows.Forms.Label();
            this.recom = new System.Windows.Forms.Label();
            this.elpochta = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.skidka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCardNumber.Location = new System.Drawing.Point(31, 101);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(79, 36);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "karta";
            this.lblCardNumber.Click += new System.EventHandler(this.lblcardNumber_Click);
            // 
            // lblnameKlient
            // 
            this.lblnameKlient.AutoSize = true;
            this.lblnameKlient.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameKlient.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblnameKlient.Location = new System.Drawing.Point(143, 46);
            this.lblnameKlient.Name = "lblnameKlient";
            this.lblnameKlient.Size = new System.Drawing.Size(102, 46);
            this.lblnameKlient.TabIndex = 5;
            this.lblnameKlient.Text = "name";
            this.lblnameKlient.Click += new System.EventHandler(this.lblnameKlient_Click);
            // 
            // recom
            // 
            this.recom.AutoSize = true;
            this.recom.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recom.ForeColor = System.Drawing.Color.SaddleBrown;
            this.recom.Location = new System.Drawing.Point(31, 331);
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(45, 32);
            this.recom.TabIndex = 6;
            this.recom.Text = "rec";
            this.recom.Click += new System.EventHandler(this.recom_Click);
            // 
            // elpochta
            // 
            this.elpochta.AutoSize = true;
            this.elpochta.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elpochta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.elpochta.Location = new System.Drawing.Point(31, 137);
            this.elpochta.Name = "elpochta";
            this.elpochta.Size = new System.Drawing.Size(117, 36);
            this.elpochta.TabIndex = 7;
            this.elpochta.Text = "elpochta";
            this.elpochta.Click += new System.EventHandler(this.elpochta_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.SaddleBrown;
            this.phone.Location = new System.Drawing.Point(37, 173);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(92, 36);
            this.phone.TabIndex = 8;
            this.phone.Text = "phone";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.SaddleBrown;
            this.date.Location = new System.Drawing.Point(37, 209);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(68, 36);
            this.date.TabIndex = 9;
            this.date.Text = "date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // skidka
            // 
            this.skidka.AutoSize = true;
            this.skidka.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skidka.ForeColor = System.Drawing.Color.SaddleBrown;
            this.skidka.Location = new System.Drawing.Point(84, 271);
            this.skidka.Name = "skidka";
            this.skidka.Size = new System.Drawing.Size(99, 38);
            this.skidka.TabIndex = 10;
            this.skidka.Text = "skidka";
            this.skidka.Click += new System.EventHandler(this.skidka_Click);
            // 
            // klientcab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skidka);
            this.Controls.Add(this.date);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.elpochta);
            this.Controls.Add(this.recom);
            this.Controls.Add(this.lblnameKlient);
            this.Controls.Add(this.lblCardNumber);
            this.Name = "klientcab";
            this.Text = "klientcab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblnameKlient;
        private System.Windows.Forms.Label recom;
        private System.Windows.Forms.Label elpochta;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label skidka;
    }
}
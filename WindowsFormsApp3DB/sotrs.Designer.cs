namespace WindowsFormsApp3DB
{
    partial class sotrs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uvolit = new System.Windows.Forms.Button();
            this.deletephoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spuvol = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uvolit
            // 
            this.uvolit.BackColor = System.Drawing.Color.SaddleBrown;
            this.uvolit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uvolit.Location = new System.Drawing.Point(422, 399);
            this.uvolit.Name = "uvolit";
            this.uvolit.Size = new System.Drawing.Size(180, 39);
            this.uvolit.TabIndex = 1;
            this.uvolit.Text = "уволить";
            this.uvolit.UseVisualStyleBackColor = false;
            this.uvolit.Click += new System.EventHandler(this.uvolit_Click);
            // 
            // deletephoto
            // 
            this.deletephoto.BackColor = System.Drawing.Color.SaddleBrown;
            this.deletephoto.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletephoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletephoto.Location = new System.Drawing.Point(236, 399);
            this.deletephoto.Name = "deletephoto";
            this.deletephoto.Size = new System.Drawing.Size(180, 39);
            this.deletephoto.TabIndex = 2;
            this.deletephoto.Text = "удалить фото";
            this.deletephoto.UseVisualStyleBackColor = false;
            this.deletephoto.Click += new System.EventHandler(this.deletephoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "id s";
            // 
            // spuvol
            // 
            this.spuvol.BackColor = System.Drawing.Color.SaddleBrown;
            this.spuvol.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spuvol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spuvol.Location = new System.Drawing.Point(608, 399);
            this.spuvol.Name = "spuvol";
            this.spuvol.Size = new System.Drawing.Size(180, 39);
            this.spuvol.TabIndex = 5;
            this.spuvol.Text = "spisok uvol";
            this.spuvol.UseVisualStyleBackColor = false;
            this.spuvol.Click += new System.EventHandler(this.spuvol_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 400);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // sotrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.spuvol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletephoto);
            this.Controls.Add(this.uvolit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sotrs";
            this.Text = "sotrs";
            this.Load += new System.EventHandler(this.sotrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uvolit;
        private System.Windows.Forms.Button deletephoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spuvol;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
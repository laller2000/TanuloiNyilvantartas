namespace TanuloiNyilvantartas
{
    partial class form_lekerdezes
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
            this.dataGridView1_Tanulok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Tanulok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Tanulok
            // 
            this.dataGridView1_Tanulok.AllowUserToAddRows = false;
            this.dataGridView1_Tanulok.AllowUserToDeleteRows = false;
            this.dataGridView1_Tanulok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Tanulok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1_Tanulok.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1_Tanulok.Name = "dataGridView1_Tanulok";
            this.dataGridView1_Tanulok.ReadOnly = true;
            this.dataGridView1_Tanulok.RowHeadersWidth = 51;
            this.dataGridView1_Tanulok.RowTemplate.Height = 24;
            this.dataGridView1_Tanulok.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1_Tanulok.TabIndex = 0;
            // 
            // form_lekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1_Tanulok);
            this.Name = "form_lekerdezes";
            this.Text = "form_lekerdezes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_lekerdezes_FormClosing);
            this.Load += new System.EventHandler(this.form_lekerdezes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Tanulok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Tanulok;
    }
}
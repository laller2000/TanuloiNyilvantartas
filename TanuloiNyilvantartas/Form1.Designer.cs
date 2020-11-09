namespace TanuloiNyilvantartas
{
    partial class form_nyito
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
            this.button1_Bevitel = new System.Windows.Forms.Button();
            this.button2_Lekerdezes = new System.Windows.Forms.Button();
            this.button3_Modositas = new System.Windows.Forms.Button();
            this.button4_Torles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Bevitel
            // 
            this.button1_Bevitel.Location = new System.Drawing.Point(357, 29);
            this.button1_Bevitel.Name = "button1_Bevitel";
            this.button1_Bevitel.Size = new System.Drawing.Size(92, 55);
            this.button1_Bevitel.TabIndex = 0;
            this.button1_Bevitel.Text = "Bevitel";
            this.button1_Bevitel.UseVisualStyleBackColor = true;
            this.button1_Bevitel.Click += new System.EventHandler(this.button1_Bevitel_Click);
            // 
            // button2_Lekerdezes
            // 
            this.button2_Lekerdezes.Location = new System.Drawing.Point(357, 119);
            this.button2_Lekerdezes.Name = "button2_Lekerdezes";
            this.button2_Lekerdezes.Size = new System.Drawing.Size(92, 69);
            this.button2_Lekerdezes.TabIndex = 1;
            this.button2_Lekerdezes.Text = "Lekérdezés";
            this.button2_Lekerdezes.UseVisualStyleBackColor = true;
            this.button2_Lekerdezes.Click += new System.EventHandler(this.button2_Lekerdezes_Click);
            // 
            // button3_Modositas
            // 
            this.button3_Modositas.Location = new System.Drawing.Point(357, 221);
            this.button3_Modositas.Name = "button3_Modositas";
            this.button3_Modositas.Size = new System.Drawing.Size(104, 74);
            this.button3_Modositas.TabIndex = 2;
            this.button3_Modositas.Text = "Módosítás";
            this.button3_Modositas.UseVisualStyleBackColor = true;
            // 
            // button4_Torles
            // 
            this.button4_Torles.Location = new System.Drawing.Point(357, 320);
            this.button4_Torles.Name = "button4_Torles";
            this.button4_Torles.Size = new System.Drawing.Size(92, 78);
            this.button4_Torles.TabIndex = 3;
            this.button4_Torles.Text = "Törlés";
            this.button4_Torles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4_Torles);
            this.Controls.Add(this.button3_Modositas);
            this.Controls.Add(this.button2_Lekerdezes);
            this.Controls.Add(this.button1_Bevitel);
            this.Name = "Form1";
            this.Text = "Tanulói nyílvántartás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Bevitel;
        private System.Windows.Forms.Button button2_Lekerdezes;
        private System.Windows.Forms.Button button3_Modositas;
        private System.Windows.Forms.Button button4_Torles;
    }
}


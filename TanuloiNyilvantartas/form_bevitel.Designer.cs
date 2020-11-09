namespace TanuloiNyilvantartas
{
    partial class form_bevitel
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
            this.button1_Vissza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2_Kiiras = new System.Windows.Forms.Button();
            this.textBox1_Nev = new System.Windows.Forms.TextBox();
            this.comboBox1_Osztaly = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1_Vissza
            // 
            this.button1_Vissza.Location = new System.Drawing.Point(591, 40);
            this.button1_Vissza.Name = "button1_Vissza";
            this.button1_Vissza.Size = new System.Drawing.Size(132, 60);
            this.button1_Vissza.TabIndex = 0;
            this.button1_Vissza.Text = "Vissza";
            this.button1_Vissza.UseVisualStyleBackColor = true;
            this.button1_Vissza.Click += new System.EventHandler(this.button1_Vissza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Osztály:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Született:";
            // 
            // button2_Kiiras
            // 
            this.button2_Kiiras.Location = new System.Drawing.Point(345, 252);
            this.button2_Kiiras.Name = "button2_Kiiras";
            this.button2_Kiiras.Size = new System.Drawing.Size(101, 62);
            this.button2_Kiiras.TabIndex = 4;
            this.button2_Kiiras.Text = "Kiiras";
            this.button2_Kiiras.UseVisualStyleBackColor = true;
            this.button2_Kiiras.Click += new System.EventHandler(this.button2_Kiiras_Click);
            // 
            // textBox1_Nev
            // 
            this.textBox1_Nev.Location = new System.Drawing.Point(169, 40);
            this.textBox1_Nev.Name = "textBox1_Nev";
            this.textBox1_Nev.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Nev.TabIndex = 5;
            // 
            // comboBox1_Osztaly
            // 
            this.comboBox1_Osztaly.FormattingEnabled = true;
            this.comboBox1_Osztaly.Items.AddRange(new object[] {
            "12A",
            "12B",
            "12C",
            "12D",
            "13",
            "14"});
            this.comboBox1_Osztaly.Location = new System.Drawing.Point(169, 91);
            this.comboBox1_Osztaly.Name = "comboBox1_Osztaly";
            this.comboBox1_Osztaly.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_Osztaly.TabIndex = 6;
            // 
            // dateTimePicker1_Szuletett
            // 
            this.dateTimePicker1_Szuletett.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1_Szuletett.Location = new System.Drawing.Point(169, 136);
            this.dateTimePicker1_Szuletett.Name = "dateTimePicker1_Szuletett";
            this.dateTimePicker1_Szuletett.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1_Szuletett.TabIndex = 7;
            // 
            // form_bevitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1_Szuletett);
            this.Controls.Add(this.comboBox1_Osztaly);
            this.Controls.Add(this.textBox1_Nev);
            this.Controls.Add(this.button2_Kiiras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_Vissza);
            this.Name = "form_bevitel";
            this.Text = "form_bevitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Vissza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2_Kiiras;
        private System.Windows.Forms.TextBox textBox1_Nev;
        private System.Windows.Forms.ComboBox comboBox1_Osztaly;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_Szuletett;
    }
}
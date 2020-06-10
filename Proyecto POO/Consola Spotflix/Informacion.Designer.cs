namespace Consola_Spotflix
{
    partial class Informacion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.UsPer = new System.Windows.Forms.Button();
            this.Multimedia = new System.Windows.Forms.Button();
            this.People = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(342, 250);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 199);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(345, 252);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(500, 199);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(342, 252);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(500, 199);
            this.listBox3.TabIndex = 2;
            // 
            // UsPer
            // 
            this.UsPer.Location = new System.Drawing.Point(323, 167);
            this.UsPer.Name = "UsPer";
            this.UsPer.Size = new System.Drawing.Size(169, 54);
            this.UsPer.TabIndex = 3;
            this.UsPer.Text = "Usuarios/Perfiles";
            this.UsPer.UseVisualStyleBackColor = true;
            this.UsPer.Click += new System.EventHandler(this.UsPer_Click_1);
            // 
            // Multimedia
            // 
            this.Multimedia.Location = new System.Drawing.Point(498, 167);
            this.Multimedia.Name = "Multimedia";
            this.Multimedia.Size = new System.Drawing.Size(169, 54);
            this.Multimedia.TabIndex = 4;
            this.Multimedia.Text = "Multimedia";
            this.Multimedia.UseVisualStyleBackColor = true;
            this.Multimedia.Click += new System.EventHandler(this.Multimedia_Click_1);
            // 
            // People
            // 
            this.People.Location = new System.Drawing.Point(673, 167);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(169, 54);
            this.People.TabIndex = 5;
            this.People.Text = "Personas";
            this.People.UseVisualStyleBackColor = true;
            this.People.Click += new System.EventHandler(this.People_Click_1);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(739, 457);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(169, 54);
            this.Atras.TabIndex = 6;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(499, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informacion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Atras);
            this.panel1.Controls.Add(this.People);
            this.panel1.Controls.Add(this.Multimedia);
            this.panel1.Controls.Add(this.UsPer);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 8;
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.panel1);
            this.Name = "Informacion";
            this.Size = new System.Drawing.Size(1264, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button UsPer;
        private System.Windows.Forms.Button Multimedia;
        private System.Windows.Forms.Button People;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

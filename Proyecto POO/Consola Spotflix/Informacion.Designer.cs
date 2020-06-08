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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(138, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 199);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(141, 179);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(305, 199);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(138, 177);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(305, 199);
            this.listBox3.TabIndex = 2;
            // 
            // UsPer
            // 
            this.UsPer.Location = new System.Drawing.Point(60, 91);
            this.UsPer.Name = "UsPer";
            this.UsPer.Size = new System.Drawing.Size(169, 54);
            this.UsPer.TabIndex = 3;
            this.UsPer.Text = "button1";
            this.UsPer.UseVisualStyleBackColor = true;
            this.UsPer.Click += new System.EventHandler(this.UsPer_Click_1);
            // 
            // Multimedia
            // 
            this.Multimedia.Location = new System.Drawing.Point(235, 91);
            this.Multimedia.Name = "Multimedia";
            this.Multimedia.Size = new System.Drawing.Size(169, 54);
            this.Multimedia.TabIndex = 4;
            this.Multimedia.Text = "Multimedia";
            this.Multimedia.UseVisualStyleBackColor = true;
            this.Multimedia.Click += new System.EventHandler(this.Multimedia_Click_1);
            // 
            // People
            // 
            this.People.Location = new System.Drawing.Point(410, 91);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(169, 54);
            this.People.TabIndex = 5;
            this.People.Text = "Personas";
            this.People.UseVisualStyleBackColor = true;
            this.People.Click += new System.EventHandler(this.People_Click_1);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(476, 381);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(169, 54);
            this.Atras.TabIndex = 6;
            this.Atras.Text = "button4";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(236, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informacion";
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.People);
            this.Controls.Add(this.Multimedia);
            this.Controls.Add(this.UsPer);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Informacion";
            this.Size = new System.Drawing.Size(687, 473);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

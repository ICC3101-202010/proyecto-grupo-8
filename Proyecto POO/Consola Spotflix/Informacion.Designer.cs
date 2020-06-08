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
            this.UsPer = new System.Windows.Forms.Button();
            this.People = new System.Windows.Forms.Button();
            this.Multimedia = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsPer
            // 
            this.UsPer.Location = new System.Drawing.Point(183, 66);
            this.UsPer.Name = "UsPer";
            this.UsPer.Size = new System.Drawing.Size(171, 54);
            this.UsPer.TabIndex = 0;
            this.UsPer.Text = "Usuarios/Perfiles";
            this.UsPer.UseVisualStyleBackColor = true;
            this.UsPer.Click += new System.EventHandler(this.UsPer_Click);
            // 
            // People
            // 
            this.People.Location = new System.Drawing.Point(566, 66);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(171, 54);
            this.People.TabIndex = 1;
            this.People.Text = "Personas";
            this.People.UseVisualStyleBackColor = true;
            this.People.Click += new System.EventHandler(this.People_Click);
            // 
            // Multimedia
            // 
            this.Multimedia.Location = new System.Drawing.Point(375, 66);
            this.Multimedia.Name = "Multimedia";
            this.Multimedia.Size = new System.Drawing.Size(171, 54);
            this.Multimedia.TabIndex = 2;
            this.Multimedia.Text = "Multimedia";
            this.Multimedia.UseVisualStyleBackColor = true;
            this.Multimedia.Click += new System.EventHandler(this.Multimedia_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(71, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(702, 329);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(71, 142);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(702, 329);
            this.listBox2.TabIndex = 5;
            this.listBox2.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(71, 142);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(702, 329);
            this.listBox3.TabIndex = 6;
            this.listBox3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Informacion General";
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(772, 483);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(89, 47);
            this.Atras.TabIndex = 9;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Multimedia);
            this.Controls.Add(this.People);
            this.Controls.Add(this.UsPer);
            this.Name = "Informacion";
            this.Size = new System.Drawing.Size(876, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UsPer;
        private System.Windows.Forms.Button People;
        private System.Windows.Forms.Button Multimedia;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Atras;
    }
}

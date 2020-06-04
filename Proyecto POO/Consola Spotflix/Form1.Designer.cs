namespace Consola_Spotflix
{
    partial class Main_Spotflix
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Minimizar = new System.Windows.Forms.Button();
            this.button_Maximizar = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.main_menu1 = new Consola_Spotflix.Main_menu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.main_menu1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 681);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button_Minimizar);
            this.panel3.Controls.Add(this.button_Maximizar);
            this.panel3.Controls.Add(this.button_Close);
            this.panel3.Location = new System.Drawing.Point(1127, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 30);
            this.panel3.TabIndex = 5;
            // 
            // button_Minimizar
            // 
            this.button_Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Minimizar.FlatAppearance.BorderSize = 0;
            this.button_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Minimizar.Location = new System.Drawing.Point(0, 0);
            this.button_Minimizar.Name = "button_Minimizar";
            this.button_Minimizar.Size = new System.Drawing.Size(45, 30);
            this.button_Minimizar.TabIndex = 3;
            this.button_Minimizar.Text = "−";
            this.button_Minimizar.UseVisualStyleBackColor = true;
            this.button_Minimizar.Click += new System.EventHandler(this.button_Minimizar_Click);
            // 
            // button_Maximizar
            // 
            this.button_Maximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Maximizar.FlatAppearance.BorderSize = 0;
            this.button_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Maximizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Maximizar.Location = new System.Drawing.Point(45, 0);
            this.button_Maximizar.Name = "button_Maximizar";
            this.button_Maximizar.Size = new System.Drawing.Size(45, 30);
            this.button_Maximizar.TabIndex = 2;
            this.button_Maximizar.Text = "☐";
            this.button_Maximizar.UseVisualStyleBackColor = true;
            this.button_Maximizar.Click += new System.EventHandler(this.button_Maximizar_Click);
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Close.Location = new System.Drawing.Point(90, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(45, 30);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // main_menu1
            // 
            this.main_menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.main_menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_menu1.Location = new System.Drawing.Point(0, 0);
            this.main_menu1.Margin = new System.Windows.Forms.Padding(0);
            this.main_menu1.MinimumSize = new System.Drawing.Size(100, 100);
            this.main_menu1.Name = "main_menu1";
            this.main_menu1.Size = new System.Drawing.Size(1264, 681);
            this.main_menu1.TabIndex = 0;
            // 
            // Main_Spotflix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Main_Spotflix";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consola Spotflix";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Main_menu main_menu1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Minimizar;
        private System.Windows.Forms.Button button_Maximizar;
        private System.Windows.Forms.Button button_Close;
    }
}


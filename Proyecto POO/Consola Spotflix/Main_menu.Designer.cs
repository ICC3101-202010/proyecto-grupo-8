namespace Consola_Spotflix
{
    partial class Main_menu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.playlist_Perfil_En_Linea1 = new Consola_Spotflix.Playlist_Perfil_En_Linea();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button_Adelantar = new System.Windows.Forms.Button();
            this.button_Retroceder = new System.Windows.Forms.Button();
            this.button_PlayPausa = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_Tiempo_Inicio = new System.Windows.Forms.Label();
            this.trackBar_Duracion = new System.Windows.Forms.TrackBar();
            this.label_Tiempo_Fin = new System.Windows.Forms.Label();
            this.Button_Perfil_En_Linea = new System.Windows.Forms.Button();
            this.tmSlider = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Duracion)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_Perfil_En_Linea, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 720);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(150, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 624);
            this.panel1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(980, 431);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.playlist_Perfil_En_Linea1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 193);
            this.panel3.TabIndex = 1;
            // 
            // playlist_Perfil_En_Linea1
            // 
            this.playlist_Perfil_En_Linea1.AutoScroll = true;
            this.playlist_Perfil_En_Linea1.AutoSize = true;
            this.playlist_Perfil_En_Linea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.playlist_Perfil_En_Linea1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playlist_Perfil_En_Linea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlist_Perfil_En_Linea1.Location = new System.Drawing.Point(0, 0);
            this.playlist_Perfil_En_Linea1.Name = "playlist_Perfil_En_Linea1";
            this.playlist_Perfil_En_Linea1.Size = new System.Drawing.Size(980, 193);
            this.playlist_Perfil_En_Linea1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.button21);
            this.panel4.Controls.Add(this.button22);
            this.panel4.Controls.Add(this.button18);
            this.panel4.Controls.Add(this.button19);
            this.panel4.Controls.Add(this.button17);
            this.panel4.Controls.Add(this.button20);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 33);
            this.panel4.MaximumSize = new System.Drawing.Size(186, 10000);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 624);
            this.panel4.TabIndex = 1;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(14, 431);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(102, 101);
            this.button21.TabIndex = 7;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(14, 538);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(102, 101);
            this.button22.TabIndex = 6;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(14, 324);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(102, 101);
            this.button18.TabIndex = 5;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(14, 217);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(102, 101);
            this.button19.TabIndex = 4;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(14, 110);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(102, 101);
            this.button17.TabIndex = 3;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(14, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(102, 101);
            this.button20.TabIndex = 2;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.button25);
            this.panel5.Controls.Add(this.button27);
            this.panel5.Controls.Add(this.button28);
            this.panel5.Controls.Add(this.button26);
            this.panel5.Controls.Add(this.button24);
            this.panel5.Controls.Add(this.button23);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1136, 33);
            this.panel5.MaximumSize = new System.Drawing.Size(186, 10000);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 624);
            this.panel5.TabIndex = 2;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(3, 628);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(114, 119);
            this.button25.TabIndex = 8;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(3, 503);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(114, 119);
            this.button27.TabIndex = 7;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(3, 378);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(114, 119);
            this.button28.TabIndex = 6;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(3, 253);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(114, 119);
            this.button26.TabIndex = 5;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(3, 128);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(114, 119);
            this.button24.TabIndex = 4;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(3, 3);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(114, 119);
            this.button23.TabIndex = 3;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(150, 663);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 54);
            this.panel2.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.button31);
            this.panel6.Controls.Add(this.button30);
            this.panel6.Controls.Add(this.button_Adelantar);
            this.panel6.Controls.Add(this.button_Retroceder);
            this.panel6.Controls.Add(this.button_PlayPausa);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(56, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(875, 57);
            this.panel6.TabIndex = 7;
            // 
            // button31
            // 
            this.button31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button31.Location = new System.Drawing.Point(558, 0);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(71, 31);
            this.button31.TabIndex = 9;
            this.button31.Text = "button31";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button30.Location = new System.Drawing.Point(250, 0);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(71, 31);
            this.button30.TabIndex = 0;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button_Adelantar
            // 
            this.button_Adelantar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Adelantar.Location = new System.Drawing.Point(481, 0);
            this.button_Adelantar.Name = "button_Adelantar";
            this.button_Adelantar.Size = new System.Drawing.Size(71, 31);
            this.button_Adelantar.TabIndex = 3;
            this.button_Adelantar.Text = "Adelantar";
            this.button_Adelantar.UseVisualStyleBackColor = true;
            this.button_Adelantar.Click += new System.EventHandler(this.button33_Click);
            // 
            // button_Retroceder
            // 
            this.button_Retroceder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Retroceder.Location = new System.Drawing.Point(327, 0);
            this.button_Retroceder.Name = "button_Retroceder";
            this.button_Retroceder.Size = new System.Drawing.Size(71, 31);
            this.button_Retroceder.TabIndex = 4;
            this.button_Retroceder.Text = "Retroceder";
            this.button_Retroceder.UseVisualStyleBackColor = true;
            // 
            // button_PlayPausa
            // 
            this.button_PlayPausa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_PlayPausa.Location = new System.Drawing.Point(404, 0);
            this.button_PlayPausa.Name = "button_PlayPausa";
            this.button_PlayPausa.Size = new System.Drawing.Size(71, 31);
            this.button_PlayPausa.TabIndex = 8;
            this.button_PlayPausa.Text = "Play";
            this.button_PlayPausa.UseVisualStyleBackColor = true;
            this.button_PlayPausa.Click += new System.EventHandler(this.button_PlayPausa_Click);
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.label_Tiempo_Inicio);
            this.panel7.Controls.Add(this.trackBar_Duracion);
            this.panel7.Controls.Add(this.label_Tiempo_Fin);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(875, 25);
            this.panel7.TabIndex = 8;
            // 
            // label_Tiempo_Inicio
            // 
            this.label_Tiempo_Inicio.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_Tiempo_Inicio.Location = new System.Drawing.Point(3, 10);
            this.label_Tiempo_Inicio.Name = "label_Tiempo_Inicio";
            this.label_Tiempo_Inicio.Size = new System.Drawing.Size(48, 15);
            this.label_Tiempo_Inicio.TabIndex = 6;
            this.label_Tiempo_Inicio.Text = "0:00";
            // 
            // trackBar_Duracion
            // 
            this.trackBar_Duracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Duracion.LargeChange = 0;
            this.trackBar_Duracion.Location = new System.Drawing.Point(54, 5);
            this.trackBar_Duracion.Maximum = 100;
            this.trackBar_Duracion.MaximumSize = new System.Drawing.Size(10000, 24);
            this.trackBar_Duracion.MinimumSize = new System.Drawing.Size(549, 24);
            this.trackBar_Duracion.Name = "trackBar_Duracion";
            this.trackBar_Duracion.Size = new System.Drawing.Size(764, 24);
            this.trackBar_Duracion.TabIndex = 0;
            this.trackBar_Duracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Duracion.ValueChanged += new System.EventHandler(this.trackBar_Duracion_ValueChanged);
            // 
            // label_Tiempo_Fin
            // 
            this.label_Tiempo_Fin.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_Tiempo_Fin.Location = new System.Drawing.Point(725, 10);
            this.label_Tiempo_Fin.Name = "label_Tiempo_Fin";
            this.label_Tiempo_Fin.Size = new System.Drawing.Size(57, 12);
            this.label_Tiempo_Fin.TabIndex = 7;
            this.label_Tiempo_Fin.Text = "0:00";
            // 
            // Button_Perfil_En_Linea
            // 
            this.Button_Perfil_En_Linea.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Perfil_En_Linea.FlatAppearance.BorderSize = 0;
            this.Button_Perfil_En_Linea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Perfil_En_Linea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Perfil_En_Linea.ForeColor = System.Drawing.SystemColors.Menu;
            this.Button_Perfil_En_Linea.Location = new System.Drawing.Point(951, 3);
            this.Button_Perfil_En_Linea.Name = "Button_Perfil_En_Linea";
            this.Button_Perfil_En_Linea.Size = new System.Drawing.Size(179, 24);
            this.Button_Perfil_En_Linea.TabIndex = 6;
            this.Button_Perfil_En_Linea.UseVisualStyleBackColor = true;
            this.Button_Perfil_En_Linea.Click += new System.EventHandler(this.Button_Perfil_En_Linea_Click);
            // 
            // tmSlider
            // 
            this.tmSlider.Tick += new System.EventHandler(this.tmSlider_Tick);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Main_menu";
            this.Size = new System.Drawing.Size(1280, 720);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Duracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Retroceder;
        private System.Windows.Forms.Button button_Adelantar;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.TrackBar trackBar_Duracion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label_Tiempo_Fin;
        private System.Windows.Forms.Label label_Tiempo_Inicio;
        private System.Windows.Forms.Timer tmSlider;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_PlayPausa;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button Button_Perfil_En_Linea;
        private Playlist_Perfil_En_Linea playlist_Perfil_En_Linea1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

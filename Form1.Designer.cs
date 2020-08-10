namespace Catan_Junior
{
    partial class Catan
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catan));
            this.PB_NuevaP = new System.Windows.Forms.PictureBox();
            this.PB_Instrucciones = new System.Windows.Forms.PictureBox();
            this.PB_Salir = new System.Windows.Forms.PictureBox();
            this.PB_2J = new System.Windows.Forms.PictureBox();
            this.PB_3J = new System.Windows.Forms.PictureBox();
            this.PB_4J = new System.Windows.Forms.PictureBox();
            this.Lbl_J = new System.Windows.Forms.Label();
            this.PB_Atras = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.AbrirPdf = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.PB_NuevaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Instrucciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_2J)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_3J)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_4J)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_NuevaP
            // 
            this.PB_NuevaP.BackColor = System.Drawing.Color.Transparent;
            this.PB_NuevaP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_NuevaP.BackgroundImage")));
            this.PB_NuevaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_NuevaP.Location = new System.Drawing.Point(348, 243);
            this.PB_NuevaP.Name = "PB_NuevaP";
            this.PB_NuevaP.Size = new System.Drawing.Size(108, 47);
            this.PB_NuevaP.TabIndex = 0;
            this.PB_NuevaP.TabStop = false;
            this.PB_NuevaP.Click += new System.EventHandler(this.PB_NuevaP_Click);
            this.PB_NuevaP.MouseLeave += new System.EventHandler(this.PB_NuevaP_MouseLeave);
            this.PB_NuevaP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_NuevaP_MouseMove);
            // 
            // PB_Instrucciones
            // 
            this.PB_Instrucciones.BackColor = System.Drawing.Color.Transparent;
            this.PB_Instrucciones.BackgroundImage = global::Catan_Junior.Properties.Resources.Instrucciones;
            this.PB_Instrucciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Instrucciones.Location = new System.Drawing.Point(348, 296);
            this.PB_Instrucciones.Name = "PB_Instrucciones";
            this.PB_Instrucciones.Size = new System.Drawing.Size(108, 47);
            this.PB_Instrucciones.TabIndex = 1;
            this.PB_Instrucciones.TabStop = false;
            this.PB_Instrucciones.Click += new System.EventHandler(this.PB_Instrucciones_Click);
            this.PB_Instrucciones.MouseLeave += new System.EventHandler(this.PB_Instrucciones_MouseLeave);
            this.PB_Instrucciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_Instrucciones_MouseMove);
            // 
            // PB_Salir
            // 
            this.PB_Salir.BackColor = System.Drawing.Color.Transparent;
            this.PB_Salir.BackgroundImage = global::Catan_Junior.Properties.Resources.Salir;
            this.PB_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Salir.Location = new System.Drawing.Point(348, 349);
            this.PB_Salir.Name = "PB_Salir";
            this.PB_Salir.Size = new System.Drawing.Size(108, 47);
            this.PB_Salir.TabIndex = 2;
            this.PB_Salir.TabStop = false;
            this.PB_Salir.Click += new System.EventHandler(this.PB_Salir_Click);
            this.PB_Salir.MouseLeave += new System.EventHandler(this.PB_Salir_MouseLeave);
            this.PB_Salir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_Salir_MouseMove);
            // 
            // PB_2J
            // 
            this.PB_2J.BackColor = System.Drawing.Color.Transparent;
            this.PB_2J.BackgroundImage = global::Catan_Junior.Properties.Resources.Jugadores_2;
            this.PB_2J.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_2J.Location = new System.Drawing.Point(234, 309);
            this.PB_2J.Name = "PB_2J";
            this.PB_2J.Size = new System.Drawing.Size(108, 47);
            this.PB_2J.TabIndex = 3;
            this.PB_2J.TabStop = false;
            this.PB_2J.Click += new System.EventHandler(this.PB_2J_Click);
            this.PB_2J.MouseLeave += new System.EventHandler(this.PB_2J_MouseLeave);
            this.PB_2J.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_2J_MouseMove);
            // 
            // PB_3J
            // 
            this.PB_3J.BackColor = System.Drawing.Color.Transparent;
            this.PB_3J.BackgroundImage = global::Catan_Junior.Properties.Resources.Jugadores_3;
            this.PB_3J.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_3J.Location = new System.Drawing.Point(348, 309);
            this.PB_3J.Name = "PB_3J";
            this.PB_3J.Size = new System.Drawing.Size(108, 47);
            this.PB_3J.TabIndex = 4;
            this.PB_3J.TabStop = false;
            this.PB_3J.Click += new System.EventHandler(this.PB_3J_Click);
            this.PB_3J.MouseLeave += new System.EventHandler(this.PB_3J_MouseLeave);
            this.PB_3J.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_3J_MouseMove);
            // 
            // PB_4J
            // 
            this.PB_4J.BackColor = System.Drawing.Color.Transparent;
            this.PB_4J.BackgroundImage = global::Catan_Junior.Properties.Resources.Jugadores_4;
            this.PB_4J.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_4J.Location = new System.Drawing.Point(462, 309);
            this.PB_4J.Name = "PB_4J";
            this.PB_4J.Size = new System.Drawing.Size(108, 47);
            this.PB_4J.TabIndex = 5;
            this.PB_4J.TabStop = false;
            this.PB_4J.Click += new System.EventHandler(this.PB_4J_Click);
            this.PB_4J.MouseLeave += new System.EventHandler(this.PB_4J_MouseLeave);
            this.PB_4J.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_4J_MouseMove);
            // 
            // Lbl_J
            // 
            this.Lbl_J.AutoSize = true;
            this.Lbl_J.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_J.Font = new System.Drawing.Font("Bradley Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_J.Location = new System.Drawing.Point(216, 267);
            this.Lbl_J.Name = "Lbl_J";
            this.Lbl_J.Size = new System.Drawing.Size(365, 26);
            this.Lbl_J.TabIndex = 6;
            this.Lbl_J.Text = "¿Cuantas personas jugaran esta vez?";
            // 
            // PB_Atras
            // 
            this.PB_Atras.BackColor = System.Drawing.Color.Transparent;
            this.PB_Atras.BackgroundImage = global::Catan_Junior.Properties.Resources.Atras;
            this.PB_Atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Atras.Location = new System.Drawing.Point(12, 503);
            this.PB_Atras.Name = "PB_Atras";
            this.PB_Atras.Size = new System.Drawing.Size(108, 47);
            this.PB_Atras.TabIndex = 7;
            this.PB_Atras.TabStop = false;
            this.PB_Atras.Click += new System.EventHandler(this.PB_Atras_Click);
            this.PB_Atras.MouseLeave += new System.EventHandler(this.PB_Atras_MouseLeave);
            this.PB_Atras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_Atras_MouseMove);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(735, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(37, 33);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            // 
            // AbrirPdf
            // 
            this.AbrirPdf.StartInfo.Domain = "";
            this.AbrirPdf.StartInfo.FileName = "C:\\Users\\Andres Ramirez\\Documents\\Universidad\\UNIMAR\\TRIMESTRES\\5to Trimestre\\Pro" +
                "gramacion II\\Proyecto Final\\Catan Junior\\Catan Junior\\bin\\Debug\\CatanJunior_Manu" +
                "al_Devir_ES.pdf";
            this.AbrirPdf.StartInfo.LoadUserProfile = false;
            this.AbrirPdf.StartInfo.Password = null;
            this.AbrirPdf.StartInfo.StandardErrorEncoding = null;
            this.AbrirPdf.StartInfo.StandardOutputEncoding = null;
            this.AbrirPdf.StartInfo.UserName = "";
            this.AbrirPdf.SynchronizingObject = this;
            // 
            // Catan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Catan_Junior.Properties.Resources.Inicio;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.PB_Atras);
            this.Controls.Add(this.Lbl_J);
            this.Controls.Add(this.PB_4J);
            this.Controls.Add(this.PB_3J);
            this.Controls.Add(this.PB_2J);
            this.Controls.Add(this.PB_Salir);
            this.Controls.Add(this.PB_Instrucciones);
            this.Controls.Add(this.PB_NuevaP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Catan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catan Junior";
            ((System.ComponentModel.ISupportInitialize)(this.PB_NuevaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Instrucciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_2J)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_3J)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_4J)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_NuevaP;
        private System.Windows.Forms.PictureBox PB_Instrucciones;
        private System.Windows.Forms.PictureBox PB_Salir;
        private System.Windows.Forms.PictureBox PB_2J;
        private System.Windows.Forms.PictureBox PB_3J;
        private System.Windows.Forms.PictureBox PB_4J;
        private System.Windows.Forms.Label Lbl_J;
        private System.Windows.Forms.PictureBox PB_Atras;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Diagnostics.Process AbrirPdf;
    }
}


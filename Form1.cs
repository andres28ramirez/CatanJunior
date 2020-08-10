using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Catan_Junior
{
    public partial class Catan : Form
    {
        Tablero_1 objeto;
        Tablero_2 obj;
        public Catan()
        {
            InitializeComponent();
            Ocultar_J();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Ocultar_J()
        {
            PB_2J.Hide();
            PB_3J.Hide();
            PB_4J.Hide();
            Lbl_J.Hide();
            PB_Atras.Hide();
        }

        //Boton de Nueva Partida
        private void PB_NuevaP_MouseMove(object sender, MouseEventArgs e)
        {
            PB_NuevaP.BackgroundImage = Catan_Junior.Properties.Resources.Nueva_Partida_Brillo; 
        }

        private void PB_NuevaP_MouseLeave(object sender, EventArgs e)
        {
            PB_NuevaP.BackgroundImage = Catan_Junior.Properties.Resources.Nueva_Partida;
        }

        private void PB_NuevaP_Click(object sender, EventArgs e)
        {
            PB_NuevaP.Hide();
            PB_Instrucciones.Hide();
            PB_Salir.Hide();
            PB_2J.Show();
            PB_3J.Show();
            PB_4J.Show();
            Lbl_J.Show();
            PB_Atras.Show();
        }

        //Boton de instrucciones
        private void PB_Instrucciones_MouseMove(object sender, MouseEventArgs e)
        {
            PB_Instrucciones.BackgroundImage = Catan_Junior.Properties.Resources.Instrucciones_Brillo;
        }

        private void PB_Instrucciones_MouseLeave(object sender, EventArgs e)
        {
            PB_Instrucciones.BackgroundImage = Catan_Junior.Properties.Resources.Instrucciones;
        }

        private void PB_Instrucciones_Click(object sender, EventArgs e)
        {
            AbrirPdf.StartInfo.FileName = Application.StartupPath + "\\CatanJunior_Manual_Devir_ES.pdf";
            AbrirPdf.StartInfo.WorkingDirectory = Application.StartupPath;
            AbrirPdf.EnableRaisingEvents = true;
            AbrirPdf.Start();
        }

        //Boton de salir
        private void PB_Salir_MouseMove(object sender, MouseEventArgs e)
        {
            PB_Salir.BackgroundImage = Catan_Junior.Properties.Resources.Salir_Brillo;
        }

        private void PB_Salir_MouseLeave(object sender, EventArgs e)
        {
            PB_Salir.BackgroundImage = Catan_Junior.Properties.Resources.Salir;
        }

        private void PB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton 2J
        private void PB_2J_MouseMove(object sender, MouseEventArgs e)
        {
            PB_2J.BackgroundImage = Catan_Junior.Properties.Resources.Jugadores_2_Brillo;
        }

        private void PB_2J_MouseLeave(object sender, EventArgs e)
        {
            PB_2J.BackgroundImage = Catan_Junior.Properties.Resources.Jugadores_2;
        }

        private void PB_2J_Click(object sender, EventArgs e)
        {
            this.Hide();
            objeto = new Tablero_1();
            //PONERLE UNA PANTALLA DE CARGA PARA QUE SE CARGUE EL TABLERO DE FORMA CORRECTA, DIMELO PAAAAAAAAAAA
            objeto.ShowDialog();
            this.Show();
        }

        //Boton 3J
        private void PB_3J_MouseMove(object sender, MouseEventArgs e)
        {
            PB_3J.BackgroundImage = Catan_Junior.Properties.Resources.Jugadores_3_Brillo;
        }

        private void PB_3J_MouseLeave(object sender, EventArgs e)
        {
            PB_3J.BackgroundImage = Catan_Junior.Properties.Resources.Jugadores_3;
        }

        private void PB_3J_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj = new Tablero_2(3);
            obj.ShowDialog();
            this.Show();
        }

        //Boton 4J
        private void PB_4J_MouseMove(object sender, MouseEventArgs e)
        {
            PB_4J.BackgroundImage = Catan_Junior.Properties.Resources.Jugadores_4_Brillo;
        }

        private void PB_4J_MouseLeave(object sender, EventArgs e)
        {
            PB_4J.BackgroundImage = Catan_Junior.Properties.Resources.Jugadores_4;
        }

        private void PB_4J_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj = new Tablero_2(4);
            obj.ShowDialog();
            this.Show();
        }

        //Boton atras
        private void PB_Atras_MouseMove(object sender, MouseEventArgs e)
        {
            PB_Atras.BackgroundImage = Catan_Junior.Properties.Resources.Atras_Brillo;
        }

        private void PB_Atras_MouseLeave(object sender, EventArgs e)
        {
            PB_Atras.BackgroundImage = Catan_Junior.Properties.Resources.Atras;
        }

        private void PB_Atras_Click(object sender, EventArgs e)
        {
            Ocultar_J();
            PB_NuevaP.Show();
            PB_Instrucciones.Show();
            PB_Salir.Show();
        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }



    }
}

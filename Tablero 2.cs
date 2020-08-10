using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Catan_Junior
{
    public partial class Tablero_2 : Form
    {
        int n; //Simbolizara si son 3 o 4 jugadores
        int inter;  //1.-Salvavidas intercambio, 2.-Intercambio Banco
        int a; //recurso que cambia el jugador
        int b; //validar la colocacion del pirata si fue con carta
        Tablero partida = new Tablero();

        public Tablero_2(int n)
        {
            this.n = n;
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(PC));
            t.Start();
            Thread.Sleep(6000);
            t.Abort();
        }

        public void PC()
        {
            Application.Run(new Carga());
        }

        private void PB_Fin_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Cerrando el Juego, Se Finalizara la partida\n¿Esta de acuerdo?", "Finalizando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void PB_BANCO_MouseMove(object sender, MouseEventArgs e)
        {
            PB_BANCO.BackgroundImage = Catan_Junior.Properties.Resources.Banco_Render_Brillo;
            PBanco.Visible = true;
            lbBanco1.Text = partida.recursos[4].ToString();
            lbBanco2.Text = partida.recursos[1].ToString();
            lbBanco3.Text = partida.recursos[3].ToString();
            lbBanco4.Text = partida.recursos[0].ToString();
            lbBanco5.Text = partida.recursos[2].ToString();
        }

        private void PB_BANCO_MouseLeave(object sender, EventArgs e)
        {
            PB_BANCO.BackgroundImage = Catan_Junior.Properties.Resources.Banco_render;
            PBanco.Visible = false;
        }

        private void PB_R1J_Click(object sender, EventArgs e)
        {
            RestaurarI();
            a = 4;
            if (inter == 1)
            {
                MessageBox.Show("Seleccione un recurso del salvavida");
                PB_S1.Enabled = true;
                PB_S2.Enabled = true;
                PB_S3.Enabled = true;
                PB_S4.Enabled = true;
                PB_S5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un recurso del banco");
                PBanco.Visible = true;
                PB_B1.Enabled = true;
                PB_B2.Enabled = true;
                PB_B3.Enabled = true;
                PB_B4.Enabled = true;
                PB_B5.Enabled = true;
            }

        }

        private void PB_R2J_Click(object sender, EventArgs e)
        {
            RestaurarI();
            a = 1;
            if (inter == 1)
            {
                MessageBox.Show("Seleccione un recurso del salvavida");
                PB_S1.Enabled = true;
                PB_S2.Enabled = true;
                PB_S3.Enabled = true;
                PB_S4.Enabled = true;
                PB_S5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un recurso del banco");
                PBanco.Visible = true;
                PB_B1.Enabled = true;
                PB_B2.Enabled = true;
                PB_B3.Enabled = true;
                PB_B4.Enabled = true;
                PB_B5.Enabled = true;
            }
        }

        private void PB_R3J_Click(object sender, EventArgs e)
        {
            RestaurarI();
            a = 3;
            if (inter == 1)
            {
                MessageBox.Show("Seleccione un recurso del salvavida");
                PB_S1.Enabled = true;
                PB_S2.Enabled = true;
                PB_S3.Enabled = true;
                PB_S4.Enabled = true;
                PB_S5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un recurso del banco");
                PBanco.Visible = true;
                PB_B1.Enabled = true;
                PB_B2.Enabled = true;
                PB_B3.Enabled = true;
                PB_B4.Enabled = true;
                PB_B5.Enabled = true;
            }
        }

        private void PB_R4J_Click(object sender, EventArgs e)
        {
            RestaurarI();
            a = 0;
            if (inter == 1)
            {
                MessageBox.Show("Seleccione un recurso del salvavida");
                PB_S1.Enabled = true;
                PB_S2.Enabled = true;
                PB_S3.Enabled = true;
                PB_S4.Enabled = true;
                PB_S5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un recurso del banco");
                PBanco.Visible = true;
                PB_B1.Enabled = true;
                PB_B2.Enabled = true;
                PB_B3.Enabled = true;
                PB_B4.Enabled = true;
                PB_B5.Enabled = true;
            }
        }

        private void PB_R5J_Click(object sender, EventArgs e)
        {
            RestaurarI();
            a = 2;
            if (inter == 1)
            {
                MessageBox.Show("Seleccione un recurso del salvavida");
                PB_S1.Enabled = true;
                PB_S2.Enabled = true;
                PB_S3.Enabled = true;
                PB_S4.Enabled = true;
                PB_S5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un recurso del banco");
                PBanco.Visible = true;
                PB_B1.Enabled = true;
                PB_B2.Enabled = true;
                PB_B3.Enabled = true;
                PB_B4.Enabled = true;
                PB_B5.Enabled = true;
            }
        }

        private void PB_P1_MouseMove(object sender, MouseEventArgs e)
        {
            PRecusosJ.Visible = true;
            if (sender == PB_P1)
            {
                PB_P1.BackgroundImage = Catan_Junior.Properties.Resources.Jugador_Morado1_Brillo;
                lbR1J.Text = partida.Player[0].recursos[4].ToString();
                lbR2J.Text = partida.Player[0].recursos[1].ToString();
                lbR3J.Text = partida.Player[0].recursos[3].ToString();
                lbR4J.Text = partida.Player[0].recursos[0].ToString();
                lbR5J.Text = partida.Player[0].recursos[2].ToString();
                lbAC.Text = partida.Player[0].cartas.ToString();
            }
            if (sender == PB_P2)
            {
                PB_P2.BackgroundImage = Catan_Junior.Properties.Resources.Jugador_Rojo1_Brillo;
                lbR1J.Text = partida.Player[1].recursos[4].ToString();
                lbR2J.Text = partida.Player[1].recursos[1].ToString();
                lbR3J.Text = partida.Player[1].recursos[3].ToString();
                lbR4J.Text = partida.Player[1].recursos[0].ToString();
                lbR5J.Text = partida.Player[1].recursos[2].ToString();
                lbAC.Text = partida.Player[1].cartas.ToString();
            }
            if (sender == PB_P3)
            {
                PB_P3.BackgroundImage = Catan_Junior.Properties.Resources.Jugador_Amarillo2_Brillo;
                lbR1J.Text = partida.Player[2].recursos[4].ToString();
                lbR2J.Text = partida.Player[2].recursos[1].ToString();
                lbR3J.Text = partida.Player[2].recursos[3].ToString();
                lbR4J.Text = partida.Player[2].recursos[0].ToString();
                lbR5J.Text = partida.Player[2].recursos[2].ToString();
                lbAC.Text = partida.Player[2].cartas.ToString();
            }
            if (sender == PB_P4)
            {
                PB_P4.BackgroundImage = Catan_Junior.Properties.Resources.Jugador_Azul_1_Brillo;
                lbR1J.Text = partida.Player[3].recursos[4].ToString();
                lbR2J.Text = partida.Player[3].recursos[1].ToString();
                lbR3J.Text = partida.Player[3].recursos[3].ToString();
                lbR4J.Text = partida.Player[3].recursos[0].ToString();
                lbR5J.Text = partida.Player[3].recursos[2].ToString();
                lbAC.Text = partida.Player[3].cartas.ToString();
            }
        }

        private void PB_P1_MouseLeave(object sender, EventArgs e)
        {
            if (sender == PB_P1)
                PB_P1.BackgroundImage = Catan_Junior.Properties.Resources.Jugador_Morado1;
            if (sender == PB_P2)
                PB_P2.BackgroundImage = Catan_Junior.Properties.Resources.Jugador_Rojo1;
            if (sender == PB_P3)
                PB_P3.BackgroundImage = Catan_Junior.Properties.Resources.Jugador_Amarillo2;
            if (sender == PB_P4)
                PB_P3.BackgroundImage = Catan_Junior.Properties.Resources.Jugador_Azul_1;
            PRecusosJ.Visible = false;
        }

        private void PB_B1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de hacer el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PBanco.Visible = false;
                partida.Intercambio(inter, a, 4);
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
                PB_B1.Enabled = false;
                PB_B2.Enabled = false;
                PB_B3.Enabled = false;
                PB_B4.Enabled = false;
                PB_B5.Enabled = false;
            }
        }

        private void PB_B2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de hacer el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                partida.Intercambio(inter, a, 1);
                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PBanco.Visible = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
                PB_B1.Enabled = false;
                PB_B2.Enabled = false;
                PB_B3.Enabled = false;
                PB_B4.Enabled = false;
                PB_B5.Enabled = false;
            }
        }

        private void PB_B3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de hacer el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                partida.Intercambio(inter, a, 3);
                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PBanco.Visible = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
                PB_B1.Enabled = false;
                PB_B2.Enabled = false;
                PB_B3.Enabled = false;
                PB_B4.Enabled = false;
                PB_B5.Enabled = false;
            }
        }

        private void PB_B4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de hacer el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                partida.Intercambio(inter, a, 0);
                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PBanco.Visible = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
                PB_B1.Enabled = false;
                PB_B2.Enabled = false;
                PB_B3.Enabled = false;
                PB_B4.Enabled = false;
                PB_B5.Enabled = false;
            }
        }

        private void PB_B5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de hacer el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                partida.Intercambio(inter, a, 2);
                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PBanco.Visible = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
                PB_B1.Enabled = false;
                PB_B2.Enabled = false;
                PB_B3.Enabled = false;
                PB_B4.Enabled = false;
                PB_B5.Enabled = false;
            }
        }

        private void btLanzar_Click(object sender, EventArgs e)
        {
            b = 0;
            Habilitar();
            Random rnd = new Random();
            int valor;
            valor = rnd.Next(1, 7);
            //MUESTRA EL VALOR DEL DADO QUE SALIO
            switch (valor)
            {
                case 1: PB_Dado.BackgroundImage = Catan_Junior.Properties.Resources.D1; break;
                case 2: PB_Dado.BackgroundImage = Catan_Junior.Properties.Resources.D2; break;
                case 3: PB_Dado.BackgroundImage = Catan_Junior.Properties.Resources.D3; break;
                case 4: PB_Dado.BackgroundImage = Catan_Junior.Properties.Resources.D4; break;
                case 5: PB_Dado.BackgroundImage = Catan_Junior.Properties.Resources.D5; break;
                case 6: PB_Dado.BackgroundImage = Catan_Junior.Properties.Resources.D6; break;
            }
            if (valor == 6)
            {
                Deshabilitar();
                RapazIsla.BackgroundImage = null;
                BorrarRapaz();
                EnabledIsla();
                MessageBox.Show("Selecciona la isla donde desees colocar el pirata!!");
            }
            else
                partida.Lanzamiento(valor, 0);
            btLanzar.Enabled = false;
        }

        private void PB_S1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Realizar el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                partida.Intercambio(inter, a, 0);

                switch (a)
                {
                    case 0: PB_S1.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable;
                        break;
                    case 1: PB_S1.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja;
                        break;
                    case 2: PB_S1.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera;
                        break;
                    case 3: PB_S1.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña;
                        break;
                    case 4: PB_S1.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro;
                        break;
                }

                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PB_S1.Enabled = false;
                PB_S2.Enabled = false;
                PB_S3.Enabled = false;
                PB_S4.Enabled = false;
                PB_S5.Enabled = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
            }
        }

        private void PB_S2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Realizar el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                partida.Intercambio(inter, a, 1);

                switch (a)
                {
                    case 0: PB_S2.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable;
                        break;
                    case 1: PB_S2.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja;
                        break;
                    case 2: PB_S2.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera;
                        break;
                    case 3: PB_S2.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña;
                        break;
                    case 4: PB_S2.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro;
                        break;
                }

                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PB_S1.Enabled = false;
                PB_S2.Enabled = false;
                PB_S3.Enabled = false;
                PB_S4.Enabled = false;
                PB_S5.Enabled = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
            }
        }

        private void PB_S3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Realizar el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                partida.Intercambio(inter, a, 2);

                switch (a)
                {
                    case 0: PB_S3.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable;
                        break;
                    case 1: PB_S3.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja;
                        break;
                    case 2: PB_S3.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera;
                        break;
                    case 3: PB_S3.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña;
                        break;
                    case 4: PB_S3.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro;
                        break;
                }

                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PB_S1.Enabled = false;
                PB_S2.Enabled = false;
                PB_S3.Enabled = false;
                PB_S4.Enabled = false;
                PB_S5.Enabled = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
            }
        }

        private void PB_S4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Realizar el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                partida.Intercambio(inter, a, 3);

                switch (a)
                {
                    case 0: PB_S4.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable;
                        break;
                    case 1: PB_S4.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja;
                        break;
                    case 2: PB_S4.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera;
                        break;
                    case 3: PB_S4.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña;
                        break;
                    case 4: PB_S4.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro;
                        break;
                }

                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PB_S1.Enabled = false;
                PB_S2.Enabled = false;
                PB_S3.Enabled = false;
                PB_S4.Enabled = false;
                PB_S5.Enabled = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
            }
        }

        private void PB_S5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Realizar el Intercambio", "Intercambio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                partida.Intercambio(inter, a, 4);

                switch (a)
                {
                    case 0: PB_S5.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable;
                        break;
                    case 1: PB_S5.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja;
                        break;
                    case 2: PB_S5.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera;
                        break;
                    case 3: PB_S5.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña;
                        break;
                    case 4: PB_S5.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro;
                        break;
                }

                btCancelar.Visible = false;
                btFinTurno.Enabled = true;
                PB_S1.Enabled = false;
                PB_S2.Enabled = false;
                PB_S3.Enabled = false;
                PB_S4.Enabled = false;
                PB_S5.Enabled = false;
                MessageBox.Show("Se ha realizado el intercambio exitosamente");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            btCancelar.Visible = false;
            Habilitar();
            RestaurarI();
            OcultarBarcos();
            OcultarFortalezas();
        }

        private void btFinTurno_Click(object sender, EventArgs e)
        {
            Deshabilitar();


            if ((partida.salvavidas[0] == partida.salvavidas[1]) && (partida.salvavidas[0] == partida.salvavidas[2]) &&
               (partida.salvavidas[0] == partida.salvavidas[3]) && (partida.salvavidas[0] == partida.salvavidas[4]))
            {
                PB_S1.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable;
                PB_S2.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja;
                PB_S3.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera;
                PB_S4.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña;
                PB_S5.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro;
            }
            partida.Revision();

            if (partida.partida == true)
            {
                MessageBox.Show("El jugador " + partida.z + 1 + " ha ganado!!");
                this.Close();
            }

            if (partida.JugadorIsla == -1)
                PB_FNIsla.BackgroundImage = null;
            if (partida.JugadorIsla == 0)
                PB_FNIsla.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
            if (partida.JugadorIsla == 1)
                PB_FNIsla.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
            if (partida.JugadorIsla == 2)
                PB_FNIsla.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
            if (partida.JugadorIsla == 3)
                PB_FNIsla.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

            btLanzar.Enabled = true;

            MessageBox.Show("Turno del Jugador " + partida.Player[partida.z].color.ToString(), "Cambio de Turno", MessageBoxButtons.OK);
            lbInformacion.Text = "Turno de Jugador " + partida.Player[partida.z].color.ToString();

            //habilitartodo();//creado para habilitar todo;
        }

        private void btConstruir_Click(object sender, EventArgs e)
        {
            Deshabilitar();
            PanelCompra.Visible = true;
            //HABILITAR BOTON DE COMPRAR FORTALEZA DE SER POSIBLE
            if (!((partida.Player[partida.z].recursos[0] >= 1) && (partida.Player[partida.z].recursos[1] >= 1) &&
              (partida.Player[partida.z].recursos[2] >= 1) && (partida.Player[partida.z].recursos[3] >= 1)))
                btCompra1.Enabled = false;
            else
                btCompra1.Enabled = true;

            //HABILITAR BOTON DE COMPRAR BARCO DE SER POSIBLE
            if (!((partida.Player[partida.z].recursos[1] >= 1) && (partida.Player[partida.z].recursos[2] >= 1)))
                btCompra2.Enabled = false;
            else
                btCompra2.Enabled = true;

            //HABILITAR COMPRA DE CARTAS AYUDA DE COCO DE SER POSIBLE
            if (!((partida.Player[partida.z].recursos[0] >= 1) && (partida.Player[partida.z].recursos[4] >= 1)
                && (partida.Player[partida.z].recursos[3] >= 1) && (partida.AyudaCoco != null)))
                btCompra3.Enabled = false;
            else
                btCompra3.Enabled = true;
        }

        private void btIntercambiar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
            PanelIntercambiar.Visible = true;
            //BOTON PARA HABiLITAR EL INTERCAMBIO DE LOS SALVAVIDAS
            if ((partida.Player[partida.z].recursos[0] == 0) && (partida.Player[partida.z].recursos[1] == 0) &&
                (partida.Player[partida.z].recursos[2] == 0) && (partida.Player[partida.z].recursos[3] == 0) &&
                (partida.Player[partida.z].recursos[4] == 0))
            {
                btIntercambiar1.Enabled = false;
            }
            else
            {
                btIntercambiar1.Enabled = true;
            }

            //BOTON PARA HABILITAR EL INTERCAMBIO DEL BANCO

            if ((partida.Player[partida.z].recursos[0] < 2) && (partida.Player[partida.z].recursos[1] < 2) &&
                (partida.Player[partida.z].recursos[2] < 2) && (partida.Player[partida.z].recursos[3] < 2) &&
                (partida.Player[partida.z].recursos[4] < 2))
                btIntercambiar2.Enabled = false;
            else
                btIntercambiar2.Enabled = true;
        }

        private void BorrarRapaz()
        {
            RapazIsla0.BackgroundImage = null;
            RapazIsla1.BackgroundImage = null;
            RapazIsla2.BackgroundImage = null;
            RapazIsla3.BackgroundImage = null;
            RapazIsla4.BackgroundImage = null;
            RapazIsla5.BackgroundImage = null;
            RapazIsla6.BackgroundImage = null;
            RapazIsla7.BackgroundImage = null;
            RapazIsla8.BackgroundImage = null;
        }

        private void EnabledIsla()
        {
            RapazIsla0.Enabled = true;
            RapazIsla1.Enabled = true;
            RapazIsla2.Enabled = true;
            RapazIsla3.Enabled = true;
            RapazIsla4.Enabled = true;
            RapazIsla5.Enabled = true;
            RapazIsla6.Enabled = true;
            RapazIsla7.Enabled = true;
            RapazIsla8.Enabled = true;
        }

        private void DisabledIsla()
        {
            RapazIsla0.Enabled = false;
            RapazIsla1.Enabled = false;
            RapazIsla2.Enabled = false;
            RapazIsla3.Enabled = false;
            RapazIsla4.Enabled = false;
            RapazIsla5.Enabled = false;
            RapazIsla6.Enabled = false;
            RapazIsla7.Enabled = false;
            RapazIsla8.Enabled = false;
        }

        private void Deshabilitar()
        {
            btIntercambiar.Enabled = false;
            btConstruir.Enabled = false;
            btFinTurno.Enabled = false;
        }

        private void Habilitar()
        {
            btIntercambiar.Enabled = true;
            btConstruir.Enabled = true;
            btFinTurno.Enabled = true;
        }

        private void RapazIsla0_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla0.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 0);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla1.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 1);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla2.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 2);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla3_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla3.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 3);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla4_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla4.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 4);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla5_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla5.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 5);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla6_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla6.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 6);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla7_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla7.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 7);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla8_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla8.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 8);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla9_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla9.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 9);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla10_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla10.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 10);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void RapazIsla11_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seguro de colocar a Rapaz en esta isla????", "SEGURO??", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (b == 1)
                {
                    btConstruir.Enabled = false;
                    btIntercambiar.Enabled = false;
                    btFinTurno.Enabled = true;
                }
                else
                    Habilitar();
                RapazIsla11.BackgroundImage = Catan_Junior.Properties.Resources.Pirata_Rapaz;
                partida.Lanzamiento(6, 11);
                DisabledIsla();
                PBCarta.Visible = false;
            }
        }

        private void Tablero_2_Load(object sender, EventArgs e)
        {
            partida.Reservar(n);

            if (n != 4)
            { //Si no son 4 jugadores elimino el boton de jugador 4
                PB_P4.Visible = false;
                PB_F_Az.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_neutro;
                PB_F_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_neutro;
                PB_B_Az.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_neutro;
                PB_B_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_neutro;
                PB_B_Az.Visible = false;
                PB_B_Az.Enabled = true;
                PB_B_Az2.Visible = false;
                PB_B_Az2.Enabled = true;
                PB_F_Az.Visible = false;
                PB_F_Az.Enabled = true;
                PB_F_Az2.Visible = false;
                PB_F_Az2.Enabled = true;
            }

            //Cargar Fortalezas ISLA 0 y 4
            partida.isla[0].Fortalezas[0] = 1;
            partida.isla[4].Fortalezas[0] = 1;
            //Cargar Fortalezas ISLA 0 y 1
            partida.isla[0].Fortalezas[1] = 2;
            partida.isla[1].Fortalezas[0] = 2;
            //Cargar Fortalezas ISLA 2 y 3
            partida.isla[2].Fortalezas[0] = 3;
            partida.isla[3].Fortalezas[0] = 3;
            //Cargar Fortalezas ISLA 3 y 7
            if (n == 4)
            {
                partida.isla[3].Fortalezas[1] = 4;
                partida.isla[7].Fortalezas[1] = 4;
            }
            //Cargar Fortalezas ISLA 4 y 8
            partida.isla[4].Fortalezas[1] = 3;
            partida.isla[8].Fortalezas[0] = 3;
            //Cargar Fortalezas ISLA 8 y 9
            if (n == 4)
            {
                partida.isla[8].Fortalezas[1] = 4;
                partida.isla[9].Fortalezas[0] = 4;
            }
            //Cargar Fortalezas ISLA 10 y 11
            partida.isla[10].Fortalezas[0] = 1;
            partida.isla[11].Fortalezas[0] = 1;
            //Cargar Fortalezas ISLA 7 y 11
            partida.isla[7].Fortalezas[0] = 2;
            partida.isla[11].Fortalezas[1] = 2;

            lbInformacion.Text = "Turno del Jugador 1";
        }

        private void RestaurarI()
        {
            PB_R4J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable;
            PB_R2J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja;
            PB_R5J.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera;
            PB_R3J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña;
            PB_R1J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro;
            PB_R1J.Enabled = false;
            PB_R2J.Enabled = false;
            PB_R3J.Enabled = false;
            PB_R4J.Enabled = false;
            PB_R5J.Enabled = false;
            PB_AC.Visible = true;
            lbAC.Visible = true;
            PRecusosJ.Visible = false;
        }

        private void PB_FN1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[1].Fortalezas.Length; i++)
                {
                    if (partida.isla[1].Fortalezas[i] == 0)
                    {
                        partida.isla[1].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN1.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN1.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN1.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN1.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[1].Fortalezas.Length; i++)
                {
                    if (partida.isla[1].Fortalezas[i] == 0)
                    {
                        partida.isla[1].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[2].Fortalezas.Length; i++)
                {
                    if (partida.isla[2].Fortalezas[i] == 0)
                    {
                        partida.isla[2].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[2].Fortalezas.Length; i++)
                {
                    if (partida.isla[2].Fortalezas[i] == 0)
                    {
                        partida.isla[2].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN3.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN3.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN3.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN3.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[4].Fortalezas.Length; i++)
                {
                    if (partida.isla[4].Fortalezas[i] == 0)
                    {
                        partida.isla[4].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN4.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN4.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN4.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN4.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[0].Fortalezas.Length; i++)
                {
                    if (partida.isla[0].Fortalezas[i] == 0)
                    {
                        partida.isla[0].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[4].Fortalezas.Length; i++)
                {
                    if (partida.isla[4].Fortalezas[i] == 0)
                    {
                        partida.isla[4].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[5].Fortalezas.Length; i++)
                {
                    if (partida.isla[5].Fortalezas[i] == 0)
                    {
                        partida.isla[5].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN5.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN5.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN5.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN5.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[0].Fortalezas.Length; i++)
                {
                    if (partida.isla[0].Fortalezas[i] == 0)
                    {
                        partida.isla[0].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[1].Fortalezas.Length; i++)
                {
                    if (partida.isla[1].Fortalezas[i] == 0)
                    {
                        partida.isla[1].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[5].Fortalezas.Length; i++)
                {
                    if (partida.isla[5].Fortalezas[i] == 0)
                    {
                        partida.isla[5].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN6.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN6.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN6.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN6.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[1].Fortalezas.Length; i++)
                {
                    if (partida.isla[1].Fortalezas[i] == 0)
                    {
                        partida.isla[1].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[5].Fortalezas.Length; i++)
                {
                    if (partida.isla[5].Fortalezas[i] == 0)
                    {
                        partida.isla[5].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN7.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN7.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN7.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN7.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[1].Fortalezas.Length; i++)
                {
                    if (partida.isla[1].Fortalezas[i] == 0)
                    {
                        partida.isla[1].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[2].Fortalezas.Length; i++)
                {
                    if (partida.isla[2].Fortalezas[i] == 0)
                    {
                        partida.isla[2].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN8.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN8.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN8.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN8.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[2].Fortalezas.Length; i++)
                {
                    if (partida.isla[2].Fortalezas[i] == 0)
                    {
                        partida.isla[2].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[6].Fortalezas.Length; i++)
                {
                    if (partida.isla[6].Fortalezas[i] == 0)
                    {
                        partida.isla[6].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN9.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN9.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN9.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN9.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[6].Fortalezas.Length; i++)
                {
                    if (partida.isla[6].Fortalezas[i] == 0)
                    {
                        partida.isla[6].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[3].Fortalezas.Length; i++)
                {
                    if (partida.isla[3].Fortalezas[i] == 0)
                    {
                        partida.isla[3].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[2].Fortalezas.Length; i++)
                {
                    if (partida.isla[2].Fortalezas[i] == 0)
                    {
                        partida.isla[2].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN10.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN10.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN10.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN10.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[3].Fortalezas.Length; i++)
                {
                    if (partida.isla[3].Fortalezas[i] == 0)
                    {
                        partida.isla[3].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[6].Fortalezas.Length; i++)
                {
                    if (partida.isla[6].Fortalezas[i] == 0)
                    {
                        partida.isla[6].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[7].Fortalezas.Length; i++)
                {
                    if (partida.isla[7].Fortalezas[i] == 0)
                    {
                        partida.isla[7].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN11.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN11.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN11.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN11.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[7].Fortalezas.Length; i++)
                {
                    if (partida.isla[7].Fortalezas[i] == 0)
                    {
                        partida.isla[7].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN12.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN12.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN12.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN12.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[4].Fortalezas.Length; i++)
                {
                    if (partida.isla[4].Fortalezas[i] == 0)
                    {
                        partida.isla[4].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN13.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN13.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN13.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN13.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[8].Fortalezas.Length; i++)
                {
                    if (partida.isla[8].Fortalezas[i] == 0)
                    {
                        partida.isla[8].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[4].Fortalezas.Length; i++)
                {
                    if (partida.isla[4].Fortalezas[i] == 0)
                    {
                        partida.isla[4].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[5].Fortalezas.Length; i++)
                {
                    if (partida.isla[5].Fortalezas[i] == 0)
                    {
                        partida.isla[5].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN14.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN14.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN14.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN14.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[9].Fortalezas.Length; i++)
                {
                    if (partida.isla[9].Fortalezas[i] == 0)
                    {
                        partida.isla[9].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[8].Fortalezas.Length; i++)
                {
                    if (partida.isla[8].Fortalezas[i] == 0)
                    {
                        partida.isla[8].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[5].Fortalezas.Length; i++)
                {
                    if (partida.isla[5].Fortalezas[i] == 0)
                    {
                        partida.isla[5].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN15.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN15.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN15.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN15.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[9].Fortalezas.Length; i++)
                {
                    if (partida.isla[9].Fortalezas[i] == 0)
                    {
                        partida.isla[9].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[5].Fortalezas.Length; i++)
                {
                    if (partida.isla[5].Fortalezas[i] == 0)
                    {
                        partida.isla[5].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN16.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN16.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN16.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN16.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN17_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[10].Fortalezas.Length; i++)
                {
                    if (partida.isla[10].Fortalezas[i] == 0)
                    {
                        partida.isla[10].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[9].Fortalezas.Length; i++)
                {
                    if (partida.isla[9].Fortalezas[i] == 0)
                    {
                        partida.isla[9].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN17.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN17.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN17.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN17.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[10].Fortalezas.Length; i++)
                {
                    if (partida.isla[10].Fortalezas[i] == 0)
                    {
                        partida.isla[10].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[6].Fortalezas.Length; i++)
                {
                    if (partida.isla[6].Fortalezas[i] == 0)
                    {
                        partida.isla[6].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN18.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN18.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN18.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN18.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[11].Fortalezas.Length; i++)
                {
                    if (partida.isla[11].Fortalezas[i] == 0)
                    {
                        partida.isla[11].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[10].Fortalezas.Length; i++)
                {
                    if (partida.isla[10].Fortalezas[i] == 0)
                    {
                        partida.isla[10].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[6].Fortalezas.Length; i++)
                {
                    if (partida.isla[6].Fortalezas[i] == 0)
                    {
                        partida.isla[6].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN19.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN19.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN19.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN19.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN20_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[11].Fortalezas.Length; i++)
                {
                    if (partida.isla[11].Fortalezas[i] == 0)
                    {
                        partida.isla[11].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[7].Fortalezas.Length; i++)
                {
                    if (partida.isla[7].Fortalezas[i] == 0)
                    {
                        partida.isla[7].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[6].Fortalezas.Length; i++)
                {
                    if (partida.isla[6].Fortalezas[i] == 0)
                    {
                        partida.isla[6].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN20.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN20.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN20.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN20.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[7].Fortalezas.Length; i++)
                {
                    if (partida.isla[7].Fortalezas[i] == 0)
                    {
                        partida.isla[7].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN21.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN21.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN21.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN21.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[9].Fortalezas.Length; i++)
                {
                    if (partida.isla[9].Fortalezas[i] == 0)
                    {
                        partida.isla[9].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN22.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN22.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN22.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN22.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN23_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[10].Fortalezas.Length; i++)
                {
                    if (partida.isla[10].Fortalezas[i] == 0)
                    {
                        partida.isla[10].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[9].Fortalezas.Length; i++)
                {
                    if (partida.isla[9].Fortalezas[i] == 0)
                    {
                        partida.isla[9].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN23.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN23.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN23.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN23.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_FN24_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[10].Fortalezas.Length; i++)
                {
                    if (partida.isla[10].Fortalezas[i] == 0)
                    {
                        partida.isla[10].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_FN24.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_FN24.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_FN24.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_FN24.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_F_Az_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[3].Fortalezas.Length; i++)
                {
                    if (partida.isla[3].Fortalezas[i] == 0)
                    {
                        partida.isla[3].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[7].Fortalezas.Length; i++)
                {
                    if (partida.isla[7].Fortalezas[i] == 0)
                    {
                        partida.isla[7].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_F_Az.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_F_Az.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_F_Az.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_F_Az.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_F_Az2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < partida.isla[8].Fortalezas.Length; i++)
                {
                    if (partida.isla[8].Fortalezas[i] == 0)
                    {
                        partida.isla[8].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                for (int i = 0; i < partida.isla[9].Fortalezas.Length; i++)
                {
                    if (partida.isla[9].Fortalezas[i] == 0)
                    {
                        partida.isla[9].Fortalezas[i] = partida.Player[partida.z].color;
                        break;
                    }
                }

                if (partida.Player[partida.z].color == 1)
                    PB_F_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Morada;
                if (partida.Player[partida.z].color == 2)
                    PB_F_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Roja;
                if (partida.Player[partida.z].color == 3)
                    PB_F_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Amarilla;
                if (partida.Player[partida.z].color == 4)
                    PB_F_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Fortaleza_Azul;

                partida.Comprar(1);
                PB_FN1.Enabled = false;
                OcultarFortalezas();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN1.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN1.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN1.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN1.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN1.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN2.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN2.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN2.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN2.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN2.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN3.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN3.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN3.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN3.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN3.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN4.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN4.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN4.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN4.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN4.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN5.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN5.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN5.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN5.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN5.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN6.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN6.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN6.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN6.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN1.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN7.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN7.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN7.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN7.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN8.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN8.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN8.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN8.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN8.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN9.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN9.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN9.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN9.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN9.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN10.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN10.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN10.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN10.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN10.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN11.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN11.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN11.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN11.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN11.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN12.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN12.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN12.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN12.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN12.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN13.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN13.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN13.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN13.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN13.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN14.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN14.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN14.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN14.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN14.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN15.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN15.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN15.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN15.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN15.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN16.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN16.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN16.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN16.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN16.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN17_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN17.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN17.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN17.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN17.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN17.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN18.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN18.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN18.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN18.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN18.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN19.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN19.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN19.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN19.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN19.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN20_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN20.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN20.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN20.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN20.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN20.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN21.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN21.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN21.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN21.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN21.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN22.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN22.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN22.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN22.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN22.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN23_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN23.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN23.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN23.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN23.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN23.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN24_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN24.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN24.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN24.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN24.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN24.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN25_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN25.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN25.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN25.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN25.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN25.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN26_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN26.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN26.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN26.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN26.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN26.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN27_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN27.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN27.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN27.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN27.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN27.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN28_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN28.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN28.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN28.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN28.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN28.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN29_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN29.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN29.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN29.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN29.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN29.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN30_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN30.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN30.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN30.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN30.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN30.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN31_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN31.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN31.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN31.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN31.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN31.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_BN32_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_BN32.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_BN32.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN32.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_BN32.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_BN32.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_B_Az_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_B_Az.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_B_Az.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_B_Az.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_B_Az.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_B_Az.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void PB_B_Az2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Presione Aceptar para confirmar", "CONFIRMAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (partida.Player[partida.z].color == 1)
                    PB_B_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Morado;
                if (partida.Player[partida.z].color == 2)
                    PB_B_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Rojo;
                if (partida.Player[partida.z].color == 2)
                    PB_B_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Amarillo;
                if (partida.Player[partida.z].color == 2)
                    PB_B_Az2.BackgroundImage = Catan_Junior.Properties.Resources.Barco_Azul;

                PB_B_Az2.Enabled = false;
                partida.Comprar(2);
                OcultarBarcos();
                if (b != 1)
                {
                    btFinTurno.Enabled = true;
                    btCancelar.Visible = false;
                }
            }
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            btncontinuar.Visible = false;
            PBCarta.Visible = false;
            btFinTurno.Enabled = true;
        }

        private void btCerrarCompra_Click(object sender, EventArgs e)
        {
            Habilitar();
            PanelCompra.Visible = false;
        }

        private void btCerrarCompra_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender == btCerrarCompra)
                btCerrarCompra.BackgroundImage = Catan_Junior.Properties.Resources.Salir_Brillo;
            if (sender == PB_Fin)
                PB_Fin.BackgroundImage = Catan_Junior.Properties.Resources.Salir_Brillo;
        }

        private void btCerrarCompra_MouseLeave(object sender, EventArgs e)
        {
            if (sender == btCerrarCompra)
                btCerrarCompra.BackgroundImage = Catan_Junior.Properties.Resources.Salir;
            if (sender == PB_Fin)
                PB_Fin.BackgroundImage = Catan_Junior.Properties.Resources.Salir;
        }

        private void btCompra1_Click(object sender, EventArgs e)
        {
            btCancelar.Visible = true;
            MostrarFortalezas();
            PanelCompra.Visible = false;
        }

        private void btCompra2_Click(object sender, EventArgs e)
        {
            MostrarBarcos();
            PanelCompra.Visible = false;
            btCancelar.Visible = true;
        }

        private void btCompra3_Click(object sender, EventArgs e)
        {
            b = 1;
            PanelCompra.Visible = false;
            partida.Comprar(3);
            switch (partida.carta)
            {
                case 1:
                    PBCarta.BackgroundImage = Catan_Junior.Properties.Resources.Carta_Estructura;
                    PBCarta.Visible = true;
                    MessageBox.Show("Seleccione la estructura a construir gratis");
                    PanelEstructura.Visible = true;
                    btncontinuar.Visible = true;
                    break;
                case 2:
                    PBCarta.BackgroundImage = Catan_Junior.Properties.Resources.Carta_malandro;
                    RapazIsla.BackgroundImage = null;
                    BorrarRapaz();
                    EnabledIsla();
                    MessageBox.Show("Selecciona la isla donde desees colocar el pirata!!");
                    break;
                case 3:
                    PBCarta.BackgroundImage = Catan_Junior.Properties.Resources.Carta_Recurso;
                    PBCarta.Visible = true;
                    btncontinuar.Visible = true;
                    break;
                case 4:
                    PBCarta.BackgroundImage = Catan_Junior.Properties.Resources.Carta_Recurso; //CAMBIAR IMAGEN DEL RECURSO
                    PBCarta.Visible = true;
                    btncontinuar.Visible = true;
                    break;
            }
            PBCarta.Visible = true;
        }

        private void btE_Fortaleza_Click(object sender, EventArgs e)
        {
            PanelEstructura.Visible = false;
            MostrarFortalezas();
            partida.Player[partida.z].recursos[0]++;
            partida.Player[partida.z].recursos[1]++;
            partida.Player[partida.z].recursos[2]++;
            partida.Player[partida.z].recursos[3]++;
            partida.recursos[0]--;
            partida.recursos[1]--;
            partida.recursos[2]--;
            partida.recursos[3]--;
        }

        private void btE_Barco_Click(object sender, EventArgs e)
        {
            PanelEstructura.Visible = false;
            MostrarBarcos();
            partida.Player[partida.z].recursos[1]++;
            partida.Player[partida.z].recursos[2]++;
            partida.recursos[1]--;
            partida.recursos[2]--;
        }

        private void btSalirIntercambiar_Click(object sender, EventArgs e)
        {
            Habilitar();
            PanelIntercambiar.Visible = false;
        }

        private void btSalirIntercambiar_MouseLeave(object sender, EventArgs e)
        {
            btSalirIntercambiar.BackgroundImage = Catan_Junior.Properties.Resources.Salir;
        }

        private void btSalirIntercambiar_MouseMove(object sender, MouseEventArgs e)
        {
            btSalirIntercambiar.BackgroundImage = Catan_Junior.Properties.Resources.Salir_Brillo;
        }

        private void btIntercambiar1_Click(object sender, EventArgs e)
        {
            btCancelar.Visible = true;
            PanelIntercambiar.Visible = false;
            inter = 1;
            //VERIFICA EL INVENTARIO DEL JUGADOR Y HABILITA EL RECURSO SI ES MAYOR O IGUAL A 1
            PB_AC.Visible = false;
            lbAC.Visible = false;
            PRecusosJ.Visible = true;
            MessageBox.Show("Primero seleccione un recurso de su inventario");
            lbR1J.Text = partida.Player[partida.z].recursos[4].ToString();
            lbR2J.Text = partida.Player[partida.z].recursos[1].ToString();
            lbR3J.Text = partida.Player[partida.z].recursos[3].ToString();
            lbR4J.Text = partida.Player[partida.z].recursos[0].ToString();
            lbR5J.Text = partida.Player[partida.z].recursos[2].ToString();

            if (partida.Player[partida.z].recursos[0] >= 1)
            {
                PB_R4J.Enabled = true;
                PB_R4J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable_Brillo;
            }

            if (partida.Player[partida.z].recursos[1] >= 1)
            {
                PB_R2J.Enabled = true;
                PB_R2J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja_Brillo;
            }

            if (partida.Player[partida.z].recursos[2] >= 1)
            {
                PB_R5J.Enabled = true;
                PB_R5J.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera_Brillante;
            }

            if (partida.Player[partida.z].recursos[3] >= 1)
            {
                PB_R3J.Enabled = true;
                PB_R3J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña_Brillo;
            }

            if (partida.Player[partida.z].recursos[4] >= 1)
            {
                PB_R1J.Enabled = true;
                PB_R1J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro_Brillo;
            }
        }

        private void btIntercambiar2_Click(object sender, EventArgs e)
        {
            btCancelar.Visible = true;
            PanelIntercambiar.Visible = false;
            inter = 2;
            //VERIFICA EL INVENTARIO DEL JUGADOR Y HABILITA EL RECURSO SI ES MAYOR O IGUAL A 2
            PB_AC.Visible = false;
            lbAC.Visible = false;
            PRecusosJ.Visible = true;
            MessageBox.Show("Primero seleccione un recurso de su inventario");
            lbR1J.Text = partida.Player[partida.z].recursos[4].ToString();
            lbR2J.Text = partida.Player[partida.z].recursos[1].ToString();
            lbR3J.Text = partida.Player[partida.z].recursos[3].ToString();
            lbR4J.Text = partida.Player[partida.z].recursos[0].ToString();
            lbR5J.Text = partida.Player[partida.z].recursos[2].ToString();
            lbBanco1.Text = partida.recursos[4].ToString();
            lbBanco2.Text = partida.recursos[1].ToString();
            lbBanco3.Text = partida.recursos[3].ToString();
            lbBanco4.Text = partida.recursos[0].ToString();
            lbBanco5.Text = partida.recursos[2].ToString();

            if (partida.Player[partida.z].recursos[0] >= 2)
            {
                PB_R4J.Enabled = true;
                PB_R4J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Sable_Brillo;
            }

            if (partida.Player[partida.z].recursos[1] >= 2)
            {
                PB_R2J.Enabled = true;
                PB_R2J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oveja_Brillo;
            }

            if (partida.Player[partida.z].recursos[2] >= 2)
            {
                PB_R5J.Enabled = true;
                PB_R5J.BackgroundImage = Catan_Junior.Properties.Resources.RecursoMadera_Brillante;
            }

            if (partida.Player[partida.z].recursos[3] >= 2)
            {
                PB_R3J.Enabled = true;
                PB_R3J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Piña_Brillo;
            }

            if (partida.Player[partida.z].recursos[4] >= 2)
            {
                PB_R1J.Enabled = true;
                PB_R1J.BackgroundImage = Catan_Junior.Properties.Resources.Recurso_Oro_Brillo;
            }
        }

    }
}
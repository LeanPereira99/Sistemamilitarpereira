using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace SistemaMilitarPereira
{
    public partial class Form1 : Form
    {
        private ContextoArma _contextoArma;
        private RadarService _radarService;
        private DisparoService _disparoService;
        private List<BEObjetivo> _objetivos;
        private BEObjetivo _objetivoSeleccionado;

        public Form1()
        {
            InitializeComponent();
            InicializarServicios();
            lblObjetivoSeleccionado.Text = "Ningún objetivo seleccionado";
            BtnDisparar.Enabled = false;
            BtnCambiarArma.Enabled = false;
            lblCompatibilidad.Text = "Seleccione un objetivo\npara verificar compatibilidad";
            lblCompatibilidad.BackColor = Color.LightYellow;
            lblCompatibilidad.ForeColor = Color.DarkBlue;
        }
        


        private void InicializarServicios()
        {
            _contextoArma = new ContextoArma();
            _radarService = new RadarService();
            _disparoService = new DisparoService();
            _objetivos = new List<BEObjetivo>();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerarObjetivos_Click(object sender, EventArgs e)
        {
            try
            {
                _objetivos = _radarService.GenerarObjetivos();
                ActualizarGridObjetivos();
                AgregarLogDisparo($"Radar: {_objetivos.Count} objetivos detectados", Color.Yellow);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar objetivos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiarRadar_Click(object sender, EventArgs e)
        {
            _objetivos.Clear();
            _objetivoSeleccionado = null;
            ActualizarGridObjetivos();
            ActualizarInterfaz();
            AgregarLogDisparo("Radar: Limpieza completa", Color.Yellow);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string objetivoId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                _objetivoSeleccionado = _objetivos.FirstOrDefault(o => o.Id == objetivoId);
                ActualizarInterfaz();
            }
        }

        private void BtnCambiarArma_Click(object sender, EventArgs e)
        {
            try
            {
                if (_objetivoSeleccionado != null)
                {
                    var armaSugerida = _contextoArma.SeleccionarArmaOptima(_objetivoSeleccionado.Distancia);
                    ActualizarInterfaz();
                    AgregarLogDisparo($"Arma cambiada automáticamente a: {armaSugerida.Nombre}", Color.Cyan);
                    AgregarLogDisparo($"Motivo: Objetivo a {_objetivoSeleccionado.Distancia}km", Color.White);
                }
                else
                {
                    MessageBox.Show("Seleccione un objetivo primero", "Sin objetivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar arma: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDisparar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_objetivoSeleccionado != null)
                {
                    if (!_contextoArma.PuedeDispararConArmaActual(_objetivoSeleccionado.Distancia))
                    {
                        string armaSugerida = _contextoArma.ObtenerArmaSugerida(_objetivoSeleccionado.Distancia);
                        string msj = $"El arma actual ({_contextoArma.GetArmaActual().Nombre}) " +
                                       $"no es adecuada para disparar a {_objetivoSeleccionado.Distancia}km.\n\n" +
                                       $"Arma sugerida: {armaSugerida}\n\n" +
                                       $"¿Desea cambiar automáticamente al arma adecuada?";

                        DialogResult result = MessageBox.Show(msj, "Arma Inadecuada",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _contextoArma.SeleccionarArmaOptima(_objetivoSeleccionado.Distancia);
                            ActualizarInterfaz();
                            AgregarLogDisparo($"Arma cambiada por compatibilidad: {_contextoArma.GetArmaActual().Nombre}", Color.Orange);
                        }
                        else
                        {
                            AgregarLogDisparo("Disparo cancelado - Arma incompatible", Color.Red);
                            return;
                        }
                    }

                    var disparo = _contextoArma.Disparar(_objetivoSeleccionado);
                    _disparoService.ProcesarDisparo(disparo);

                    string resultado = disparo.Acierto ? "ACIERTO" : "FALLO";
                    Color color = disparo.Acierto ? Color.Green : Color.Red;

                    string mensaje = $"{DateTime.Now:HH:mm:ss} - {disparo.ArmaUtilizada}\n" +
                                   $"Objetivo: {disparo.ObjetivoId} ({disparo.DistanciaObjetivo}km)\n" +
                                   $"Disparo: {disparo.DistanciaDisparo}km - {resultado}\n" +
                                   new string('-', 40);

                    AgregarLogDisparo(mensaje, color);
                    ActualizarHistorialGrid();

                    if (disparo.Acierto)
                    {
                        _objetivos.Remove(_objetivoSeleccionado);
                        _objetivoSeleccionado = null;
                        ActualizarGridObjetivos();
                        ActualizarInterfaz();
                        AgregarLogDisparo($"Objetivo {disparo.ObjetivoId} eliminado", Color.Yellow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al disparar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarInterfaz()
        {
            if (_objetivoSeleccionado != null)
            {
                lblObjetivoSeleccionado.Text = $"ID: {_objetivoSeleccionado.Id}\n" +
                                             $"Distancia: {_objetivoSeleccionado.Distancia} km\n" +
                                             $"Estado: {_objetivoSeleccionado.Estado}";
                BtnDisparar.Enabled = true;
                BtnCambiarArma.Enabled = true;

                bool compatible = _contextoArma.PuedeDispararConArmaActual(_objetivoSeleccionado.Distancia);
                if (compatible)
                {
                    lblCompatibilidad.Text = $"✓ Arma compatible\nPuede disparar al objetivo";
                    lblCompatibilidad.BackColor = Color.LightGreen;
                    lblCompatibilidad.ForeColor = Color.DarkGreen;
                }
                else
                {
                    string armaSugerida = _contextoArma.ObtenerArmaSugerida(_objetivoSeleccionado.Distancia);
                    lblCompatibilidad.Text = $"⚠ Arma incompatible\nSugerida: {armaSugerida}";
                    lblCompatibilidad.BackColor = Color.LightCoral;
                    lblCompatibilidad.ForeColor = Color.DarkRed;
                }
            }
            else
            {
                lblObjetivoSeleccionado.Text = "Ningún objetivo seleccionado";
                BtnDisparar.Enabled = false;
                BtnCambiarArma.Enabled = false;
                lblCompatibilidad.Text = "Seleccione un objetivo\npara verificar compatibilidad";
                lblCompatibilidad.BackColor = Color.LightYellow;
                lblCompatibilidad.ForeColor = Color.DarkBlue;
            }

            var armaActual = _contextoArma.GetArmaActual();
            lblArmaActual.Text = $"Arma Actual: {armaActual.Nombre}";
            lblAlcanceArma.Text = $"Alcance: {armaActual.AlcanceMinimo} - {armaActual.AlcanceMaximo} km";
        }
        private void ActualizarGridObjetivos()
        {
            dataGridView1.Rows.Clear();
            foreach (var objetivo in _objetivos)
            {
                dataGridView1.Rows.Add(objetivo.Id, $"{objetivo.Distancia} km", objetivo.Estado.ToString());
            }
        }

        private void ActualizarHistorialGrid()
        {
            try
            {
                dataGridView2.Rows.Clear();
                var disparos = _disparoService.ObtenerHistorial();
                foreach (var disparo in disparos)
                {
                    string acierto = disparo.Acierto ? "SÍ" : "NO";
                    dataGridView2.Rows.Add(
                        disparo.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"),
                        disparo.ObjetivoId,
                        $"{disparo.DistanciaObjetivo} km",
                        disparo.ArmaUtilizada,
                        $"{disparo.DistanciaDisparo} km",
                        acierto
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AgregarLogDisparo(string mensaje, Color color)
        {
            RtxtBitacora.SelectionStart = RtxtBitacora.TextLength;
            RtxtBitacora.SelectionLength = 0;
            RtxtBitacora.SelectionColor = color;
            RtxtBitacora.AppendText($"{mensaje}\n");
            RtxtBitacora.SelectionColor = RtxtBitacora.ForeColor;
            RtxtBitacora.ScrollToCaret();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace FinalClub
{
    public partial class Form1 : Form
    {
        // Listas para almacenar los datos
        private List<Socio> socios = new List<Socio>();
        private List<Entrenador> entrenadores = new List<Entrenador>();
        private List<Equipo> equipos = new List<Equipo>();
        private List<Partido> partidos = new List<Partido>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridViews();

            //Desabilitar GroupBoxes
            gbPersona.Enabled = false;
            gbEquipo.Enabled = false;
            gbCuota.Enabled = false;
            gbResultados.Enabled = false;
        }

        // Configuración inicial de los DataGridView
        private void ConfigurarDataGridViews()
        {
            // dgvSocios
            dgvSocios.Columns.Add("NombreCompleto", "Nombre y Apellido");
            dgvSocios.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dgvSocios.Columns.Add("Edad", "Edad");
            dgvSocios.Columns.Add("DNI", "DNI");
            dgvSocios.Columns.Add("Deporte", "Deporte");
            dgvSocios.Columns.Add("Cuota", "Cuota");

            // dgvEquipos
            dgvEquipos.Columns.Add("Deporte", "Deporte");
            dgvEquipos.Columns.Add("Nombre", "Nombre del Equipo");
            dgvEquipos.Columns.Add("Entrenador", "Entrenador");
            dgvEquipos.Columns.Add("Miembros", "Miembros");
            dgvEquipos.Columns.Add("Codigo", "Código");

            // dgvTabla
            dgvTabla.Columns.Add("Nombre", "Nombre del Equipo");
            dgvTabla.Columns.Add("PartidosJugados", "Partidos Jugados");
            dgvTabla.Columns.Add("Victorias", "Victorias");
            dgvTabla.Columns.Add("Derrotas", "Derrotas");
        }

        // Método para actualizar los DataGridView
        private void ActualizarDataGridViews()
        {
            // Limpiar los DataGridView antes de actualizar
            dgvSocios.Rows.Clear();
            dgvEquipos.Rows.Clear();
            dgvTabla.Rows.Clear();

            // Actualizar dgvSocios
            foreach (var socio in socios)
            {
                dgvSocios.Rows.Add(
                    $"{socio.Apellido}, {socio.Nombre}",
                    socio.FechaNacimiento.ToShortDateString(),
                    socio.CalcularEdad(),
                    socio.DNI,
                    socio.Deporte,
                    socio.CalcularCuota()
                );
            }

            // Actualizar dgvEquipos
            foreach (var equipo in equipos)
            {
                string miembros = string.Join(Environment.NewLine, equipo.Miembros.Select(s => s.Apellido + ", " + s.Nombre));
                dgvEquipos.Rows.Add(
                    equipo.Deporte,
                    equipo.Nombre,
                    equipo.Entrenador?.Apellido + ", " + equipo.Entrenador?.Nombre, // Manejar caso de entrenador null
                    miembros,
                    equipo.Codigo
                );
            }

            /* Actualizar dgvTabla (filtrar por deporte seleccionado)
            var deporteSeleccionado = ObtenerDeporteSeleccionado(); // Método para obtener el deporte seleccionado en los RadioButton
            var equiposFiltrados = equipos.Where(e => e.Deporte == deporteSeleccionado);

            foreach (var equipo in equiposFiltrados)
            {
                int victorias = partidos.Count(p => p.Ganador == equipo);
                int derrotas = partidos.Count(p => p.Ganador != equipo && (p.Equipo1 == equipo || p.Equipo2 == equipo));
                int partidosJugados = victorias + derrotas;

                dgvTabla.Rows.Add(equipo.Nombre, partidosJugados, victorias, derrotas);
            }

            // Ordenar dgvTabla por victorias descendente
            dgvTabla.Sort(dgvTabla.Columns["Victorias"], System.ComponentModel.ListSortDirection.Descending);
            */
        }

        // Configuración inicial del ComboBox cbDeportePersona
        private void ConfigurarComboBoxDeportePersona()
        {
            cbDeportePersona.Items.Add(Deporte.Futbol5);
            cbDeportePersona.Items.Add(Deporte.Tenis);
            cbDeportePersona.Items.Add(Deporte.VoleyPlaya);
            cbDeportePersona.SelectedIndex = -1; // Para que no haya ningún deporte seleccionado por defecto
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rbSocio.Checked || rbEntrenador.Checked)
            {
                gbDatos.Enabled = false;
                gbPartidos.Enabled = false;
                gbMasAcciones.Enabled = false;
                gbPersona.Enabled = true;

                tbNombre.Clear();
                tbApellido.Clear();
                tbFechaNaci.Clear();
                tbDNI.Clear();
            }

            else if (rbEquipo.Checked)
            {
                gbDatos.Enabled = false;
                gbDatos.Enabled = false;
                gbPartidos.Enabled = false;
                gbMasAcciones.Enabled = false;
                gbEquipo.Enabled = true;

                tbNombreEquipo.Clear();
                tbCodigo.Clear();
            }
        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (!ValidarDatosPersona())
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            // Crear el objeto Persona (Socio o Entrenador)
            Persona persona;
            if (rbSocio.Checked)
            {
                persona = new Socio
                {
                    Nombre = tbNombre.Text,
                    Apellido = tbApellido.Text,
                    FechaNacimiento = DateTime.Parse(tbFechaNaci.Text),
                    DNI = tbDNI.Text,
                    Deporte = (Deporte)cbDeportePersona.SelectedItem
                };
                socios.Add((Socio)persona);
            }
            else if (rbEntrenador.Checked)
            {
                persona = new Entrenador
                {
                    Nombre = tbNombre.Text,
                    Apellido = tbApellido.Text,
                    FechaNacimiento = DateTime.Parse(tbFechaNaci.Text),
                    DNI = tbDNI.Text,
                    Deporte = (Deporte)cbDeportePersona.SelectedItem
                };
                entrenadores.Add((Entrenador)persona);
            }
            else
            {
                MessageBox.Show("Seleccione si desea agregar un Socio o Entrenador.");
                return;
            }

            // Actualizar los DataGridViews
            ActualizarDataGridViews();

            // Limpiar los campos
            tbNombre.Clear();
            tbApellido.Clear();
            tbFechaNaci.Clear();
            tbDNI.Clear();
            cbDeportePersona.SelectedIndex = -1;

            // Deshabilitar GroupBox Persona y habilitar GroupBoxes principales
            gbPersona.Enabled = false;
            gbDatos.Enabled = true;
            gbPartidos.Enabled = true;
            gbMasAcciones.Enabled = true;
        }

        private bool ValidarDatosPersona()
        {
            // Validar nombre y apellido
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || !tbNombre.Text.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese un nombre válido (solo letras).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbApellido.Text) || !tbApellido.Text.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese un apellido válido (solo letras).");
                return false;
            }

            // Validar fecha de nacimiento
            if (!DateTime.TryParse(tbFechaNaci.Text, out DateTime fechaNacimiento))
            {
                MessageBox.Show("Ingrese una fecha de nacimiento válida.");
                return false;
            }

            // Validar DNI
            if (string.IsNullOrWhiteSpace(tbDNI.Text) || !tbDNI.Text.All(char.IsDigit) || tbDNI.Text.Length != 8)
            {
                MessageBox.Show("Ingrese un DNI válido (solo números y 8 dígitos).");
                return false;
            }

            // Validar selección de deporte
            if (cbDeportePersona.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un deporte.");
                return false;
            }

            return true;
        }
    }
}

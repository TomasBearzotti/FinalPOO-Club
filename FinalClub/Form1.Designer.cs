namespace FinalClub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSocios = new DataGridView();
            dgvTabla = new DataGridView();
            dgvEquipos = new DataGridView();
            rbSocio = new RadioButton();
            rbEquipo = new RadioButton();
            rbEntrenador = new RadioButton();
            gbPersona = new GroupBox();
            btnGuardarPersona = new Button();
            btnCancelarPersona = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbDNI = new TextBox();
            cbDeportePersona = new ComboBox();
            tbFechaNaci = new TextBox();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            gbEquipo = new GroupBox();
            btnCancelarEquipo = new Button();
            tbCodigo = new TextBox();
            tbNombreEquipo = new TextBox();
            cbEntrenador = new ComboBox();
            btnGuardarEquipo = new Button();
            cbDeporteEquipo = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            gbDatos = new GroupBox();
            gbResultados = new GroupBox();
            cbEmpate = new CheckBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            btnGuardarResultado = new Button();
            btnCancelarResultado = new Button();
            rbTenisDoble = new RadioButton();
            label11 = new Label();
            rbFutbol5 = new RadioButton();
            rbVoley = new RadioButton();
            rbTenisSingle = new RadioButton();
            gbPartidos = new GroupBox();
            btnCargarPartidos = new Button();
            btnVerTabla = new Button();
            gbMasAcciones = new GroupBox();
            btnCerrar = new Button();
            btnModificarCuota = new Button();
            gbCuota = new GroupBox();
            btnGurdarCuota = new Button();
            btnCancelarCuota = new Button();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            gbPersona.SuspendLayout();
            gbEquipo.SuspendLayout();
            gbDatos.SuspendLayout();
            gbResultados.SuspendLayout();
            gbPartidos.SuspendLayout();
            gbMasAcciones.SuspendLayout();
            gbCuota.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(6, 13);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.Size = new Size(418, 402);
            dgvSocios.TabIndex = 0;
            // 
            // dgvTabla
            // 
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(866, 13);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.Size = new Size(286, 402);
            dgvTabla.TabIndex = 1;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(430, 13);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.Size = new Size(430, 402);
            dgvEquipos.TabIndex = 2;
            // 
            // rbSocio
            // 
            rbSocio.AutoSize = true;
            rbSocio.Location = new Point(157, 26);
            rbSocio.Name = "rbSocio";
            rbSocio.Size = new Size(54, 19);
            rbSocio.TabIndex = 4;
            rbSocio.TabStop = true;
            rbSocio.Text = "Socio";
            rbSocio.UseVisualStyleBackColor = true;
            // 
            // rbEquipo
            // 
            rbEquipo.AutoSize = true;
            rbEquipo.Location = new Point(157, 76);
            rbEquipo.Name = "rbEquipo";
            rbEquipo.Size = new Size(62, 19);
            rbEquipo.TabIndex = 5;
            rbEquipo.TabStop = true;
            rbEquipo.Text = "Equipo";
            rbEquipo.UseVisualStyleBackColor = true;
            // 
            // rbEntrenador
            // 
            rbEntrenador.AutoSize = true;
            rbEntrenador.Location = new Point(157, 51);
            rbEntrenador.Name = "rbEntrenador";
            rbEntrenador.Size = new Size(83, 19);
            rbEntrenador.TabIndex = 6;
            rbEntrenador.TabStop = true;
            rbEntrenador.Text = "Entrenador";
            rbEntrenador.UseVisualStyleBackColor = true;
            // 
            // gbPersona
            // 
            gbPersona.Controls.Add(btnGuardarPersona);
            gbPersona.Controls.Add(btnCancelarPersona);
            gbPersona.Controls.Add(label5);
            gbPersona.Controls.Add(label4);
            gbPersona.Controls.Add(label3);
            gbPersona.Controls.Add(label2);
            gbPersona.Controls.Add(label1);
            gbPersona.Controls.Add(tbDNI);
            gbPersona.Controls.Add(cbDeportePersona);
            gbPersona.Controls.Add(tbFechaNaci);
            gbPersona.Controls.Add(tbApellido);
            gbPersona.Controls.Add(tbNombre);
            gbPersona.Location = new Point(1159, 12);
            gbPersona.Name = "gbPersona";
            gbPersona.Size = new Size(226, 191);
            gbPersona.TabIndex = 7;
            gbPersona.TabStop = false;
            gbPersona.Text = "Persona";
            // 
            // btnGuardarPersona
            // 
            btnGuardarPersona.Location = new Point(145, 162);
            btnGuardarPersona.Name = "btnGuardarPersona";
            btnGuardarPersona.Size = new Size(75, 23);
            btnGuardarPersona.TabIndex = 12;
            btnGuardarPersona.Text = "Guardar";
            btnGuardarPersona.UseVisualStyleBackColor = true;
            btnGuardarPersona.Click += btnGuardarPersona_Click;
            // 
            // btnCancelarPersona
            // 
            btnCancelarPersona.Location = new Point(6, 162);
            btnCancelarPersona.Name = "btnCancelarPersona";
            btnCancelarPersona.Size = new Size(75, 23);
            btnCancelarPersona.TabIndex = 11;
            btnCancelarPersona.Text = "Cancelar";
            btnCancelarPersona.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 135);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "Deporte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 106);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 9;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de Naci";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 48);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(89, 103);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(129, 23);
            tbDNI.TabIndex = 4;
            // 
            // cbDeportePersona
            // 
            cbDeportePersona.FormattingEnabled = true;
            cbDeportePersona.Location = new Point(89, 132);
            cbDeportePersona.Name = "cbDeportePersona";
            cbDeportePersona.Size = new Size(129, 23);
            cbDeportePersona.TabIndex = 3;
            // 
            // tbFechaNaci
            // 
            tbFechaNaci.Location = new Point(89, 74);
            tbFechaNaci.Name = "tbFechaNaci";
            tbFechaNaci.Size = new Size(129, 23);
            tbFechaNaci.TabIndex = 2;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(89, 45);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(129, 23);
            tbApellido.TabIndex = 1;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(89, 16);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(129, 23);
            tbNombre.TabIndex = 0;
            // 
            // gbEquipo
            // 
            gbEquipo.Controls.Add(btnCancelarEquipo);
            gbEquipo.Controls.Add(tbCodigo);
            gbEquipo.Controls.Add(tbNombreEquipo);
            gbEquipo.Controls.Add(cbEntrenador);
            gbEquipo.Controls.Add(btnGuardarEquipo);
            gbEquipo.Controls.Add(cbDeporteEquipo);
            gbEquipo.Controls.Add(label10);
            gbEquipo.Controls.Add(label9);
            gbEquipo.Controls.Add(label8);
            gbEquipo.Controls.Add(label7);
            gbEquipo.Controls.Add(label6);
            gbEquipo.Location = new Point(1161, 210);
            gbEquipo.Name = "gbEquipo";
            gbEquipo.Size = new Size(241, 192);
            gbEquipo.TabIndex = 8;
            gbEquipo.TabStop = false;
            gbEquipo.Text = "Equipo";
            // 
            // btnCancelarEquipo
            // 
            btnCancelarEquipo.Location = new Point(6, 163);
            btnCancelarEquipo.Name = "btnCancelarEquipo";
            btnCancelarEquipo.Size = new Size(75, 23);
            btnCancelarEquipo.TabIndex = 16;
            btnCancelarEquipo.Text = "Cancelar";
            btnCancelarEquipo.UseVisualStyleBackColor = true;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(103, 132);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(129, 23);
            tbCodigo.TabIndex = 7;
            // 
            // tbNombreEquipo
            // 
            tbNombreEquipo.Location = new Point(103, 21);
            tbNombreEquipo.Name = "tbNombreEquipo";
            tbNombreEquipo.Size = new Size(129, 23);
            tbNombreEquipo.TabIndex = 6;
            // 
            // cbEntrenador
            // 
            cbEntrenador.FormattingEnabled = true;
            cbEntrenador.Location = new Point(103, 79);
            cbEntrenador.Name = "cbEntrenador";
            cbEntrenador.Size = new Size(129, 23);
            cbEntrenador.TabIndex = 15;
            // 
            // btnGuardarEquipo
            // 
            btnGuardarEquipo.Location = new Point(157, 163);
            btnGuardarEquipo.Name = "btnGuardarEquipo";
            btnGuardarEquipo.Size = new Size(75, 23);
            btnGuardarEquipo.TabIndex = 5;
            btnGuardarEquipo.Text = "Guardar";
            btnGuardarEquipo.UseVisualStyleBackColor = true;
            // 
            // cbDeporteEquipo
            // 
            cbDeporteEquipo.FormattingEnabled = true;
            cbDeporteEquipo.Location = new Point(103, 50);
            cbDeporteEquipo.Name = "cbDeporteEquipo";
            cbDeporteEquipo.Size = new Size(129, 23);
            cbDeporteEquipo.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 135);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 4;
            label10.Text = "Codigo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 111);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 3;
            label9.Text = "Miembros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 82);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 2;
            label8.Text = "Entrenador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 53);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 1;
            label7.Text = "Deporte";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 0;
            label6.Text = "Nombre Equipo";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 18);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(6, 47);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(135, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(6, 76);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(btnEliminar);
            gbDatos.Controls.Add(btnModificar);
            gbDatos.Controls.Add(btnAgregar);
            gbDatos.Controls.Add(rbEntrenador);
            gbDatos.Controls.Add(rbEquipo);
            gbDatos.Controls.Add(rbSocio);
            gbDatos.Location = new Point(6, 421);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(246, 111);
            gbDatos.TabIndex = 13;
            gbDatos.TabStop = false;
            gbDatos.Text = "Cargar Datos";
            // 
            // gbResultados
            // 
            gbResultados.Controls.Add(cbEmpate);
            gbResultados.Controls.Add(comboBox5);
            gbResultados.Controls.Add(comboBox4);
            gbResultados.Controls.Add(label13);
            gbResultados.Controls.Add(label12);
            gbResultados.Controls.Add(btnGuardarResultado);
            gbResultados.Controls.Add(btnCancelarResultado);
            gbResultados.Location = new Point(1159, 408);
            gbResultados.Name = "gbResultados";
            gbResultados.Size = new Size(283, 125);
            gbResultados.TabIndex = 14;
            gbResultados.TabStop = false;
            gbResultados.Text = "Resultado de los Partidos";
            // 
            // cbEmpate
            // 
            cbEmpate.AutoSize = true;
            cbEmpate.Location = new Point(114, 86);
            cbEmpate.Name = "cbEmpate";
            cbEmpate.Size = new Size(66, 19);
            cbEmpate.TabIndex = 11;
            cbEmpate.Text = "Empate";
            cbEmpate.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(152, 48);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(11, 48);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(182, 20);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 8;
            label13.Text = "Perdedor";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 20);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 7;
            label12.Text = "Ganador";
            // 
            // btnGuardarResultado
            // 
            btnGuardarResultado.Location = new Point(198, 86);
            btnGuardarResultado.Name = "btnGuardarResultado";
            btnGuardarResultado.Size = new Size(75, 23);
            btnGuardarResultado.TabIndex = 6;
            btnGuardarResultado.Text = "Guardar";
            btnGuardarResultado.UseVisualStyleBackColor = true;
            // 
            // btnCancelarResultado
            // 
            btnCancelarResultado.Location = new Point(11, 86);
            btnCancelarResultado.Name = "btnCancelarResultado";
            btnCancelarResultado.Size = new Size(75, 23);
            btnCancelarResultado.TabIndex = 5;
            btnCancelarResultado.Text = "Cancelar";
            btnCancelarResultado.UseVisualStyleBackColor = true;
            // 
            // rbTenisDoble
            // 
            rbTenisDoble.AutoSize = true;
            rbTenisDoble.Location = new Point(124, 61);
            rbTenisDoble.Name = "rbTenisDoble";
            rbTenisDoble.Size = new Size(85, 19);
            rbTenisDoble.TabIndex = 4;
            rbTenisDoble.TabStop = true;
            rbTenisDoble.Text = "Tenis Doble";
            rbTenisDoble.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 51);
            label11.Name = "label11";
            label11.Size = new Size(112, 15);
            label11.TabIndex = 0;
            label11.Text = "Eleccion de Deporte";
            // 
            // rbFutbol5
            // 
            rbFutbol5.AutoSize = true;
            rbFutbol5.Location = new Point(124, 14);
            rbFutbol5.Name = "rbFutbol5";
            rbFutbol5.Size = new Size(68, 19);
            rbFutbol5.TabIndex = 1;
            rbFutbol5.TabStop = true;
            rbFutbol5.Text = "Futbol 5";
            rbFutbol5.UseVisualStyleBackColor = true;
            // 
            // rbVoley
            // 
            rbVoley.AutoSize = true;
            rbVoley.Location = new Point(124, 86);
            rbVoley.Name = "rbVoley";
            rbVoley.Size = new Size(84, 19);
            rbVoley.TabIndex = 3;
            rbVoley.TabStop = true;
            rbVoley.Text = "Voley Playa";
            rbVoley.UseVisualStyleBackColor = true;
            // 
            // rbTenisSingle
            // 
            rbTenisSingle.AutoSize = true;
            rbTenisSingle.Location = new Point(124, 36);
            rbTenisSingle.Name = "rbTenisSingle";
            rbTenisSingle.Size = new Size(86, 19);
            rbTenisSingle.TabIndex = 2;
            rbTenisSingle.TabStop = true;
            rbTenisSingle.Text = "Tenis Single";
            rbTenisSingle.UseVisualStyleBackColor = true;
            // 
            // gbPartidos
            // 
            gbPartidos.Controls.Add(btnCargarPartidos);
            gbPartidos.Controls.Add(btnVerTabla);
            gbPartidos.Controls.Add(rbTenisDoble);
            gbPartidos.Controls.Add(rbTenisSingle);
            gbPartidos.Controls.Add(rbVoley);
            gbPartidos.Controls.Add(rbFutbol5);
            gbPartidos.Controls.Add(label11);
            gbPartidos.Location = new Point(258, 421);
            gbPartidos.Name = "gbPartidos";
            gbPartidos.Size = new Size(301, 112);
            gbPartidos.TabIndex = 15;
            gbPartidos.TabStop = false;
            gbPartidos.Text = "Partidos";
            // 
            // btnCargarPartidos
            // 
            btnCargarPartidos.Location = new Point(226, 53);
            btnCargarPartidos.Name = "btnCargarPartidos";
            btnCargarPartidos.Size = new Size(69, 42);
            btnCargarPartidos.TabIndex = 16;
            btnCargarPartidos.Text = "Cargar Partidos";
            btnCargarPartidos.UseVisualStyleBackColor = true;
            // 
            // btnVerTabla
            // 
            btnVerTabla.Location = new Point(226, 24);
            btnVerTabla.Name = "btnVerTabla";
            btnVerTabla.Size = new Size(69, 23);
            btnVerTabla.TabIndex = 5;
            btnVerTabla.Text = "Ver Tabla";
            btnVerTabla.UseVisualStyleBackColor = true;
            // 
            // gbMasAcciones
            // 
            gbMasAcciones.Controls.Add(btnCerrar);
            gbMasAcciones.Controls.Add(btnModificarCuota);
            gbMasAcciones.Location = new Point(565, 421);
            gbMasAcciones.Name = "gbMasAcciones";
            gbMasAcciones.Size = new Size(587, 112);
            gbMasAcciones.TabIndex = 16;
            gbMasAcciones.TabStop = false;
            gbMasAcciones.Text = "Mas Acciones";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(495, 24);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 75);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar Programa";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnModificarCuota
            // 
            btnModificarCuota.Location = new Point(6, 25);
            btnModificarCuota.Name = "btnModificarCuota";
            btnModificarCuota.Size = new Size(103, 71);
            btnModificarCuota.TabIndex = 0;
            btnModificarCuota.Text = "Modificar Valor de Cuotas";
            btnModificarCuota.UseVisualStyleBackColor = true;
            // 
            // gbCuota
            // 
            gbCuota.Controls.Add(btnGurdarCuota);
            gbCuota.Controls.Add(btnCancelarCuota);
            gbCuota.Controls.Add(textBox9);
            gbCuota.Controls.Add(textBox8);
            gbCuota.Controls.Add(textBox7);
            gbCuota.Controls.Add(label16);
            gbCuota.Controls.Add(label15);
            gbCuota.Controls.Add(label14);
            gbCuota.Location = new Point(1440, 43);
            gbCuota.Name = "gbCuota";
            gbCuota.Size = new Size(200, 139);
            gbCuota.TabIndex = 17;
            gbCuota.TabStop = false;
            gbCuota.Text = "Cuota de los Socios";
            // 
            // btnGurdarCuota
            // 
            btnGurdarCuota.Location = new Point(113, 110);
            btnGurdarCuota.Name = "btnGurdarCuota";
            btnGurdarCuota.Size = new Size(75, 23);
            btnGurdarCuota.TabIndex = 7;
            btnGurdarCuota.Text = "Guardar";
            btnGurdarCuota.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCuota
            // 
            btnCancelarCuota.Location = new Point(6, 110);
            btnCancelarCuota.Name = "btnCancelarCuota";
            btnCancelarCuota.Size = new Size(75, 23);
            btnCancelarCuota.TabIndex = 6;
            btnCancelarCuota.Text = "Cancelar";
            btnCancelarCuota.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(88, 77);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(88, 48);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(88, 18);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 80);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 2;
            label16.Text = "Voley Playa";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(36, 51);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 1;
            label15.Text = "Tenis";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 21);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 0;
            label14.Text = "Futbol 5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1670, 544);
            Controls.Add(gbCuota);
            Controls.Add(gbMasAcciones);
            Controls.Add(gbPartidos);
            Controls.Add(gbResultados);
            Controls.Add(gbDatos);
            Controls.Add(gbEquipo);
            Controls.Add(gbPersona);
            Controls.Add(dgvEquipos);
            Controls.Add(dgvTabla);
            Controls.Add(dgvSocios);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            gbPersona.ResumeLayout(false);
            gbPersona.PerformLayout();
            gbEquipo.ResumeLayout(false);
            gbEquipo.PerformLayout();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbResultados.ResumeLayout(false);
            gbResultados.PerformLayout();
            gbPartidos.ResumeLayout(false);
            gbPartidos.PerformLayout();
            gbMasAcciones.ResumeLayout(false);
            gbCuota.ResumeLayout(false);
            gbCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSocios;
        private DataGridView dgvTabla;
        private DataGridView dgvEquipos;
        private RadioButton rbSocio;
        private RadioButton rbEquipo;
        private RadioButton rbEntrenador;
        private GroupBox gbPersona;
        private TextBox tbNombre;
        private GroupBox gbEquipo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbDNI;
        private ComboBox cbDeportePersona;
        private TextBox tbFechaNaci;
        private TextBox tbApellido;
        private Button btnGuardarPersona;
        private Button btnCancelarPersona;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox gbDatos;
        private Button btnGuardarEquipo;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnCancelarEquipo;
        private TextBox tbCodigo;
        private TextBox tbNombreEquipo;
        private ComboBox cbEntrenador;
        private ComboBox cbDeporteEquipo;
        private GroupBox gbResultados;
        private RadioButton rbTenisDoble;
        private Label label11;
        private RadioButton rbFutbol5;
        private RadioButton rbVoley;
        private RadioButton rbTenisSingle;
        private Label label13;
        private Label label12;
        private Button btnGuardarResultado;
        private Button btnCancelarResultado;
        private GroupBox gbPartidos;
        private Button btnVerTabla;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private Button btnCargarPartidos;
        private GroupBox gbMasAcciones;
        private GroupBox gbCuota;
        private Button btnGurdarCuota;
        private Button btnCancelarCuota;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label16;
        private Label label15;
        private Label label14;
        private CheckBox cbEmpate;
        private Button btnCerrar;
        private Button btnModificarCuota;
    }
}

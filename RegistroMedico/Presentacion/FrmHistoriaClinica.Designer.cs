namespace Presentacion
{
    partial class FrmHistoriaClinica
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoriaClinica));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtRegimen = new System.Windows.Forms.TextBox();
            this.txtEstrato = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEstrato = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lalDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMedicoCargo = new System.Windows.Forms.TextBox();
            this.lbMedico = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.txtFormaRealizacion = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lbDiagnostico = new System.Windows.Forms.Label();
            this.lbRealizacion = new System.Windows.Forms.Label();
            this.txtTipoTratamiento = new System.Windows.Forms.TextBox();
            this.lbTratamiento = new System.Windows.Forms.Label();
            this.lbFinalidadProcedimiento = new System.Windows.Forms.Label();
            this.txtResultadoRevision = new System.Windows.Forms.TextBox();
            this.txtMotivoIngreso = new System.Windows.Forms.TextBox();
            this.lbProcedimiento = new System.Windows.Forms.Label();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtNroIngreso = new System.Windows.Forms.TextBox();
            this.lblNumIngreso = new System.Windows.Forms.Label();
            this.lblEps = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnPdf);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtRegimen);
            this.groupBox1.Controls.Add(this.txtEstrato);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.lblFechaNacimiento);
            this.groupBox1.Controls.Add(this.lblEstrato);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblRegimen);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.lalDireccion);
            this.groupBox1.Controls.Add(this.lblEdad);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(123, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(221, 20);
            this.txtBuscar.TabIndex = 77;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(32, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 30);
            this.btnBuscar.TabIndex = 76;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(234, 513);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 40);
            this.btnEliminar.TabIndex = 75;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(149, 513);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(57, 41);
            this.btnActualizar.TabIndex = 74;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(46, 514);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 40);
            this.btnSalir.TabIndex = 71;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPdf.Location = new System.Drawing.Point(312, 511);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(68, 43);
            this.btnPdf.TabIndex = 52;
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPdf.UseVisualStyleBackColor = false;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(160, 452);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(142, 20);
            this.txtFechaNacimiento.TabIndex = 70;
            // 
            // txtRegimen
            // 
            this.txtRegimen.Location = new System.Drawing.Point(160, 410);
            this.txtRegimen.Name = "txtRegimen";
            this.txtRegimen.Size = new System.Drawing.Size(119, 20);
            this.txtRegimen.TabIndex = 69;
            // 
            // txtEstrato
            // 
            this.txtEstrato.Location = new System.Drawing.Point(160, 364);
            this.txtEstrato.Name = "txtEstrato";
            this.txtEstrato.Size = new System.Drawing.Size(46, 20);
            this.txtEstrato.TabIndex = 68;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(160, 324);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(46, 20);
            this.txtSexo.TabIndex = 67;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(6, 456);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(151, 16);
            this.lblFechaNacimiento.TabIndex = 65;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblEstrato
            // 
            this.lblEstrato.AutoSize = true;
            this.lblEstrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrato.Location = new System.Drawing.Point(6, 368);
            this.lblEstrato.Name = "lblEstrato";
            this.lblEstrato.Size = new System.Drawing.Size(56, 16);
            this.lblEstrato.TabIndex = 52;
            this.lblEstrato.Text = "Estrato";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSexo.Location = new System.Drawing.Point(6, 328);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 16);
            this.lblSexo.TabIndex = 63;
            this.lblSexo.Text = "Sexo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(160, 204);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 20);
            this.txtDireccion.TabIndex = 62;
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimen.Location = new System.Drawing.Point(6, 411);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(69, 16);
            this.lblRegimen.TabIndex = 50;
            this.lblRegimen.Text = "Regimen";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(160, 284);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(46, 20);
            this.txtEdad.TabIndex = 60;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 243);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(167, 20);
            this.txtTelefono.TabIndex = 58;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 170);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 20);
            this.txtNombre.TabIndex = 56;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(160, 131);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(167, 20);
            this.txtCedula.TabIndex = 54;
            // 
            // lalDireccion
            // 
            this.lalDireccion.AutoSize = true;
            this.lalDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lalDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lalDireccion.Location = new System.Drawing.Point(6, 208);
            this.lalDireccion.Name = "lalDireccion";
            this.lalDireccion.Size = new System.Drawing.Size(73, 16);
            this.lalDireccion.TabIndex = 61;
            this.lalDireccion.Text = "Dirección";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEdad.Location = new System.Drawing.Point(6, 284);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(44, 16);
            this.lblEdad.TabIndex = 59;
            this.lblEdad.Text = "Edad";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefono.Location = new System.Drawing.Point(6, 247);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 16);
            this.lblTelefono.TabIndex = 57;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(6, 174);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCedula.Location = new System.Drawing.Point(6, 135);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(56, 16);
            this.lblCedula.TabIndex = 53;
            this.lblCedula.Text = "Cédula";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.txtMedicoCargo);
            this.groupBox2.Controls.Add(this.lbMedico);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.lbObservaciones);
            this.groupBox2.Controls.Add(this.txtFormaRealizacion);
            this.groupBox2.Controls.Add(this.txtDiagnostico);
            this.groupBox2.Controls.Add(this.lbDiagnostico);
            this.groupBox2.Controls.Add(this.lbRealizacion);
            this.groupBox2.Controls.Add(this.txtTipoTratamiento);
            this.groupBox2.Controls.Add(this.lbTratamiento);
            this.groupBox2.Controls.Add(this.lbFinalidadProcedimiento);
            this.groupBox2.Controls.Add(this.txtResultadoRevision);
            this.groupBox2.Controls.Add(this.txtMotivoIngreso);
            this.groupBox2.Controls.Add(this.lbProcedimiento);
            this.groupBox2.Controls.Add(this.txtEps);
            this.groupBox2.Controls.Add(this.txtFechaIngreso);
            this.groupBox2.Controls.Add(this.txtNroIngreso);
            this.groupBox2.Controls.Add(this.lblNumIngreso);
            this.groupBox2.Controls.Add(this.lblEps);
            this.groupBox2.Controls.Add(this.lblFechaIngreso);
            this.groupBox2.Location = new System.Drawing.Point(451, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 624);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtMedicoCargo
            // 
            this.txtMedicoCargo.Location = new System.Drawing.Point(132, 493);
            this.txtMedicoCargo.Multiline = true;
            this.txtMedicoCargo.Name = "txtMedicoCargo";
            this.txtMedicoCargo.Size = new System.Drawing.Size(280, 19);
            this.txtMedicoCargo.TabIndex = 69;
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedico.Location = new System.Drawing.Point(11, 496);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(115, 16);
            this.lbMedico.TabIndex = 68;
            this.lbMedico.Text = "Medico a cargo";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(554, 483);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(245, 73);
            this.txtObservaciones.TabIndex = 67;
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservaciones.Location = new System.Drawing.Point(444, 484);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(112, 16);
            this.lbObservaciones.TabIndex = 66;
            this.lbObservaciones.Text = "Observaciones";
            // 
            // txtFormaRealizacion
            // 
            this.txtFormaRealizacion.Location = new System.Drawing.Point(167, 294);
            this.txtFormaRealizacion.Multiline = true;
            this.txtFormaRealizacion.Name = "txtFormaRealizacion";
            this.txtFormaRealizacion.Size = new System.Drawing.Size(632, 72);
            this.txtFormaRealizacion.TabIndex = 65;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(167, 386);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(632, 74);
            this.txtDiagnostico.TabIndex = 64;
            // 
            // lbDiagnostico
            // 
            this.lbDiagnostico.AutoSize = true;
            this.lbDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagnostico.Location = new System.Drawing.Point(11, 387);
            this.lbDiagnostico.Name = "lbDiagnostico";
            this.lbDiagnostico.Size = new System.Drawing.Size(123, 16);
            this.lbDiagnostico.TabIndex = 63;
            this.lbDiagnostico.Text = "Diagnostico final";
            // 
            // lbRealizacion
            // 
            this.lbRealizacion.AutoSize = true;
            this.lbRealizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealizacion.Location = new System.Drawing.Point(11, 294);
            this.lbRealizacion.Name = "lbRealizacion";
            this.lbRealizacion.Size = new System.Drawing.Size(153, 16);
            this.lbRealizacion.TabIndex = 62;
            this.lbRealizacion.Text = "Forma de realizacion";
            // 
            // txtTipoTratamiento
            // 
            this.txtTipoTratamiento.Location = new System.Drawing.Point(167, 219);
            this.txtTipoTratamiento.Multiline = true;
            this.txtTipoTratamiento.Name = "txtTipoTratamiento";
            this.txtTipoTratamiento.Size = new System.Drawing.Size(632, 41);
            this.txtTipoTratamiento.TabIndex = 60;
            // 
            // lbTratamiento
            // 
            this.lbTratamiento.AutoSize = true;
            this.lbTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTratamiento.Location = new System.Drawing.Point(11, 231);
            this.lbTratamiento.Name = "lbTratamiento";
            this.lbTratamiento.Size = new System.Drawing.Size(146, 16);
            this.lbTratamiento.TabIndex = 59;
            this.lbTratamiento.Text = "Tipo de tratamiento ";
            // 
            // lbFinalidadProcedimiento
            // 
            this.lbFinalidadProcedimiento.AutoSize = true;
            this.lbFinalidadProcedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalidadProcedimiento.Location = new System.Drawing.Point(11, 160);
            this.lbFinalidadProcedimiento.Name = "lbFinalidadProcedimiento";
            this.lbFinalidadProcedimiento.Size = new System.Drawing.Size(112, 32);
            this.lbFinalidadProcedimiento.TabIndex = 58;
            this.lbFinalidadProcedimiento.Text = "Resultados de \r\nla revision";
            // 
            // txtResultadoRevision
            // 
            this.txtResultadoRevision.Location = new System.Drawing.Point(167, 147);
            this.txtResultadoRevision.Multiline = true;
            this.txtResultadoRevision.Name = "txtResultadoRevision";
            this.txtResultadoRevision.Size = new System.Drawing.Size(632, 39);
            this.txtResultadoRevision.TabIndex = 57;
            // 
            // txtMotivoIngreso
            // 
            this.txtMotivoIngreso.Location = new System.Drawing.Point(167, 88);
            this.txtMotivoIngreso.Multiline = true;
            this.txtMotivoIngreso.Name = "txtMotivoIngreso";
            this.txtMotivoIngreso.Size = new System.Drawing.Size(632, 38);
            this.txtMotivoIngreso.TabIndex = 56;
            // 
            // lbProcedimiento
            // 
            this.lbProcedimiento.AutoSize = true;
            this.lbProcedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcedimiento.Location = new System.Drawing.Point(11, 97);
            this.lbProcedimiento.Name = "lbProcedimiento";
            this.lbProcedimiento.Size = new System.Drawing.Size(131, 16);
            this.lbProcedimiento.TabIndex = 55;
            this.lbProcedimiento.Text = "Motivo de Ingreso";
            // 
            // txtEps
            // 
            this.txtEps.Location = new System.Drawing.Point(420, 49);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(183, 20);
            this.txtEps.TabIndex = 54;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.Location = new System.Drawing.Point(167, 49);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(245, 20);
            this.txtFechaIngreso.TabIndex = 53;
            // 
            // txtNroIngreso
            // 
            this.txtNroIngreso.Location = new System.Drawing.Point(623, 49);
            this.txtNroIngreso.Name = "txtNroIngreso";
            this.txtNroIngreso.Size = new System.Drawing.Size(108, 20);
            this.txtNroIngreso.TabIndex = 52;
            // 
            // lblNumIngreso
            // 
            this.lblNumIngreso.AutoSize = true;
            this.lblNumIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblNumIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumIngreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumIngreso.Location = new System.Drawing.Point(609, 25);
            this.lblNumIngreso.Name = "lblNumIngreso";
            this.lblNumIngreso.Size = new System.Drawing.Size(139, 16);
            this.lblNumIngreso.TabIndex = 51;
            this.lblNumIngreso.Text = "Numero de ingreso";
            // 
            // lblEps
            // 
            this.lblEps.AutoSize = true;
            this.lblEps.BackColor = System.Drawing.Color.Transparent;
            this.lblEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEps.Location = new System.Drawing.Point(479, 22);
            this.lblEps.Name = "lblEps";
            this.lblEps.Size = new System.Drawing.Size(34, 16);
            this.lblEps.TabIndex = 49;
            this.lblEps.Text = "Eps";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(191, 25);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(175, 16);
            this.lblFechaIngreso.TabIndex = 48;
            this.lblFechaIngreso.Text = "Fecha y hora de ingreso";
            // 
            // FrmHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1323, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clinica";
            this.Load += new System.EventHandler(this.FrmHistoriaClinica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEstrato;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lalDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtEstrato;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtRegimen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtNroIngreso;
        private System.Windows.Forms.Label lblNumIngreso;
        private System.Windows.Forms.Label lblEps;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox txtFormaRealizacion;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lbDiagnostico;
        private System.Windows.Forms.Label lbRealizacion;
        private System.Windows.Forms.Label lbTratamiento;
        private System.Windows.Forms.Label lbFinalidadProcedimiento;
        private System.Windows.Forms.TextBox txtResultadoRevision;
        private System.Windows.Forms.TextBox txtMotivoIngreso;
        private System.Windows.Forms.Label lbProcedimiento;
        private System.Windows.Forms.TextBox txtTipoTratamiento;
        private System.Windows.Forms.TextBox txtMedicoCargo;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}
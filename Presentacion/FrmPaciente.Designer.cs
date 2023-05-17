﻿namespace Presentacion
{
    partial class FrmPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaciente));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboRegimen = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.lbProcedimiento = new System.Windows.Forms.Label();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.txtFinalidad = new System.Windows.Forms.TextBox();
            this.lbFinalidadProcedimiento = new System.Windows.Forms.Label();
            this.lbTratamiento = new System.Windows.Forms.Label();
            this.txtTipoTratamiento = new System.Windows.Forms.TextBox();
            this.txtFormaRealizacion = new System.Windows.Forms.TextBox();
            this.lbRealizacion = new System.Windows.Forms.Label();
            this.lbDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.lbMedico = new System.Windows.Forms.Label();
            this.txtMedicoCargo = new System.Windows.Forms.TextBox();
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(308, 30);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(16, 30);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 23);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Location = new System.Drawing.Point(302, 842);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 785);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboEstrato);
            this.groupBox1.Controls.Add(this.txtMedicoCargo);
            this.groupBox1.Controls.Add(this.lbMedico);
            this.groupBox1.Controls.Add(this.textObservaciones);
            this.groupBox1.Controls.Add(this.lbObservaciones);
            this.groupBox1.Controls.Add(this.txtDiagnostico);
            this.groupBox1.Controls.Add(this.lbDiagnostico);
            this.groupBox1.Controls.Add(this.lbRealizacion);
            this.groupBox1.Controls.Add(this.txtFormaRealizacion);
            this.groupBox1.Controls.Add(this.txtTipoTratamiento);
            this.groupBox1.Controls.Add(this.lbTratamiento);
            this.groupBox1.Controls.Add(this.lbFinalidadProcedimiento);
            this.groupBox1.Controls.Add(this.txtFinalidad);
            this.groupBox1.Controls.Add(this.txtProcedimiento);
            this.groupBox1.Controls.Add(this.lbProcedimiento);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.dateTimeFecha);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboRegimen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 586);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // comboRegimen
            // 
            this.comboRegimen.FormattingEnabled = true;
            this.comboRegimen.Items.AddRange(new object[] {
            "Subsidiado",
            "Contributivo"});
            this.comboRegimen.Location = new System.Drawing.Point(380, 25);
            this.comboRegimen.Name = "comboRegimen";
            this.comboRegimen.Size = new System.Drawing.Size(121, 21);
            this.comboRegimen.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(317, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "REGIMEN";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(660, 27);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(100, 20);
            this.dateTimeFecha.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(526, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "FECHA DE ATENCION";
            // 
            // lbProcedimiento
            // 
            this.lbProcedimiento.AutoSize = true;
            this.lbProcedimiento.Location = new System.Drawing.Point(6, 106);
            this.lbProcedimiento.Name = "lbProcedimiento";
            this.lbProcedimiento.Size = new System.Drawing.Size(97, 13);
            this.lbProcedimiento.TabIndex = 4;
            this.lbProcedimiento.Text = "PROCEDIMIENTO";
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Location = new System.Drawing.Point(155, 93);
            this.txtProcedimiento.Multiline = true;
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(722, 38);
            this.txtProcedimiento.TabIndex = 5;
            // 
            // txtFinalidad
            // 
            this.txtFinalidad.Location = new System.Drawing.Point(155, 148);
            this.txtFinalidad.Multiline = true;
            this.txtFinalidad.Name = "txtFinalidad";
            this.txtFinalidad.Size = new System.Drawing.Size(722, 35);
            this.txtFinalidad.TabIndex = 6;
            // 
            // lbFinalidadProcedimiento
            // 
            this.lbFinalidadProcedimiento.AutoSize = true;
            this.lbFinalidadProcedimiento.Location = new System.Drawing.Point(9, 157);
            this.lbFinalidadProcedimiento.Name = "lbFinalidadProcedimiento";
            this.lbFinalidadProcedimiento.Size = new System.Drawing.Size(97, 26);
            this.lbFinalidadProcedimiento.TabIndex = 7;
            this.lbFinalidadProcedimiento.Text = "FINALIDAD\r\nPROCEDIMIENTO";
            // 
            // lbTratamiento
            // 
            this.lbTratamiento.AutoSize = true;
            this.lbTratamiento.Location = new System.Drawing.Point(6, 212);
            this.lbTratamiento.Name = "lbTratamiento";
            this.lbTratamiento.Size = new System.Drawing.Size(131, 13);
            this.lbTratamiento.TabIndex = 8;
            this.lbTratamiento.Text = "TIPO DE TRATAMIENTO";
            // 
            // txtTipoTratamiento
            // 
            this.txtTipoTratamiento.Location = new System.Drawing.Point(155, 200);
            this.txtTipoTratamiento.Multiline = true;
            this.txtTipoTratamiento.Name = "txtTipoTratamiento";
            this.txtTipoTratamiento.Size = new System.Drawing.Size(722, 34);
            this.txtTipoTratamiento.TabIndex = 9;
            // 
            // txtFormaRealizacion
            // 
            this.txtFormaRealizacion.Location = new System.Drawing.Point(155, 253);
            this.txtFormaRealizacion.Multiline = true;
            this.txtFormaRealizacion.Name = "txtFormaRealizacion";
            this.txtFormaRealizacion.Size = new System.Drawing.Size(722, 36);
            this.txtFormaRealizacion.TabIndex = 10;
            // 
            // lbRealizacion
            // 
            this.lbRealizacion.AutoSize = true;
            this.lbRealizacion.Location = new System.Drawing.Point(9, 263);
            this.lbRealizacion.Name = "lbRealizacion";
            this.lbRealizacion.Size = new System.Drawing.Size(96, 26);
            this.lbRealizacion.TabIndex = 11;
            this.lbRealizacion.Text = "FORMA \r\nDE REALIZACION";
            // 
            // lbDiagnostico
            // 
            this.lbDiagnostico.AutoSize = true;
            this.lbDiagnostico.Location = new System.Drawing.Point(9, 326);
            this.lbDiagnostico.Name = "lbDiagnostico";
            this.lbDiagnostico.Size = new System.Drawing.Size(140, 13);
            this.lbDiagnostico.TabIndex = 12;
            this.lbDiagnostico.Text = "DIAGNOSTICO PRINCIPAL";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(155, 312);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(722, 47);
            this.txtDiagnostico.TabIndex = 13;
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.Location = new System.Drawing.Point(566, 394);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(98, 13);
            this.lbObservaciones.TabIndex = 15;
            this.lbObservaciones.Text = "OBSERVACIONES";
            // 
            // textObservaciones
            // 
            this.textObservaciones.Location = new System.Drawing.Point(692, 394);
            this.textObservaciones.Multiline = true;
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(185, 107);
            this.textObservaciones.TabIndex = 16;
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Location = new System.Drawing.Point(35, 403);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(100, 13);
            this.lbMedico.TabIndex = 17;
            this.lbMedico.Text = "MEDICO A CARGO";
            // 
            // txtMedicoCargo
            // 
            this.txtMedicoCargo.Location = new System.Drawing.Point(155, 400);
            this.txtMedicoCargo.Multiline = true;
            this.txtMedicoCargo.Name = "txtMedicoCargo";
            this.txtMedicoCargo.Size = new System.Drawing.Size(299, 19);
            this.txtMedicoCargo.TabIndex = 19;
            // 
            // comboEstrato
            // 
            this.comboEstrato.FormattingEnabled = true;
            this.comboEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboEstrato.Location = new System.Drawing.Point(206, 26);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(73, 21);
            this.comboEstrato.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ESTRATO";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(38, 534);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(141, 534);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "ELIMINAR";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 534);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "VER DIAGNOSTICO";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(47, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cédula";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(367, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(459, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(692, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefono";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(784, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(53, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Edad";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 20);
            this.textBox4.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(367, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Dirección";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(459, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 20);
            this.textBox5.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(692, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sexo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBox1.Location = new System.Drawing.Point(784, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 811);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1079, 785);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Historia clinica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(205, 78);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 19);
            this.textBox6.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1120, 987);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEstrato;
        private System.Windows.Forms.TextBox txtMedicoCargo;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.TextBox textObservaciones;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lbDiagnostico;
        private System.Windows.Forms.Label lbRealizacion;
        private System.Windows.Forms.TextBox txtFormaRealizacion;
        private System.Windows.Forms.TextBox txtTipoTratamiento;
        private System.Windows.Forms.Label lbTratamiento;
        private System.Windows.Forms.Label lbFinalidadProcedimiento;
        private System.Windows.Forms.TextBox txtFinalidad;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.Label lbProcedimiento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboRegimen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
    }
}
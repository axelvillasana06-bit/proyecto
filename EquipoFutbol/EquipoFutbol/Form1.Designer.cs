
namespace EquipoFutbol
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtgListaJugadores = new System.Windows.Forms.DataGridView();
            this.grpDatosEquipo = new System.Windows.Forms.GroupBox();
            this.btnCapturarEquipo = new System.Windows.Forms.Button();
            this.rad2da = new System.Windows.Forms.RadioButton();
            this.rad1ra = new System.Windows.Forms.RadioButton();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.grpDatosJugador = new System.Windows.Forms.GroupBox();
            this.btnCapturarJugador = new System.Windows.Forms.Button();
            this.lblPosiciones = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.chkTitular = new System.Windows.Forms.CheckBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.lblNombreJugador = new System.Windows.Forms.Label();
            this.txtDorsal = new System.Windows.Forms.TextBox();
            this.lblDorsal = new System.Windows.Forms.Label();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaJugadores)).BeginInit();
            this.grpDatosEquipo.SuspendLayout();
            this.grpDatosJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgListaJugadores
            // 
            this.dtgListaJugadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListaJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListaJugadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgListaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaJugadores.Location = new System.Drawing.Point(6, 261);
            this.dtgListaJugadores.Name = "dtgListaJugadores";
            this.dtgListaJugadores.Size = new System.Drawing.Size(596, 177);
            this.dtgListaJugadores.TabIndex = 0;
            this.dtgListaJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaJugadores_CellClick);
            // 
            // grpDatosEquipo
            // 
            this.grpDatosEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatosEquipo.AutoSize = true;
            this.grpDatosEquipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDatosEquipo.Controls.Add(this.btnCapturarEquipo);
            this.grpDatosEquipo.Controls.Add(this.rad2da);
            this.grpDatosEquipo.Controls.Add(this.rad1ra);
            this.grpDatosEquipo.Controls.Add(this.lblCategoria);
            this.grpDatosEquipo.Controls.Add(this.txtNombreEquipo);
            this.grpDatosEquipo.Controls.Add(this.lblNombreEquipo);
            this.grpDatosEquipo.Location = new System.Drawing.Point(6, 4);
            this.grpDatosEquipo.Margin = new System.Windows.Forms.Padding(5);
            this.grpDatosEquipo.Name = "grpDatosEquipo";
            this.grpDatosEquipo.Size = new System.Drawing.Size(236, 216);
            this.grpDatosEquipo.TabIndex = 1;
            this.grpDatosEquipo.TabStop = false;
            this.grpDatosEquipo.Text = "Datos del Equipo";
            // 
            // btnCapturarEquipo
            // 
            this.btnCapturarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapturarEquipo.Location = new System.Drawing.Point(6, 174);
            this.btnCapturarEquipo.Name = "btnCapturarEquipo";
            this.btnCapturarEquipo.Size = new System.Drawing.Size(224, 23);
            this.btnCapturarEquipo.TabIndex = 3;
            this.btnCapturarEquipo.Text = "&Capturar Equipo";
            this.btnCapturarEquipo.UseVisualStyleBackColor = true;
            this.btnCapturarEquipo.Click += new System.EventHandler(this.btnCapturarEquipo_Click);
            // 
            // rad2da
            // 
            this.rad2da.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rad2da.AutoSize = true;
            this.rad2da.Location = new System.Drawing.Point(14, 120);
            this.rad2da.Name = "rad2da";
            this.rad2da.Size = new System.Drawing.Size(83, 17);
            this.rad2da.TabIndex = 4;
            this.rad2da.Text = "2da Division";
            this.rad2da.UseVisualStyleBackColor = true;
            // 
            // rad1ra
            // 
            this.rad1ra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rad1ra.AutoSize = true;
            this.rad1ra.Checked = true;
            this.rad1ra.Location = new System.Drawing.Point(14, 96);
            this.rad1ra.Name = "rad1ra";
            this.rad1ra.Size = new System.Drawing.Size(80, 17);
            this.rad1ra.TabIndex = 3;
            this.rad1ra.TabStop = true;
            this.rad1ra.Text = "1ra Division";
            this.rad1ra.UseVisualStyleBackColor = true;
            this.rad1ra.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(11, 66);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreEquipo.Location = new System.Drawing.Point(113, 20);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(76, 20);
            this.txtNombreEquipo.TabIndex = 1;
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Location = new System.Drawing.Point(8, 23);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(99, 13);
            this.lblNombreEquipo.TabIndex = 0;
            this.lblNombreEquipo.Text = "Nombre Del Equipo";
            // 
            // grpDatosJugador
            // 
            this.grpDatosJugador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatosJugador.AutoSize = true;
            this.grpDatosJugador.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDatosJugador.Controls.Add(this.btnCapturarJugador);
            this.grpDatosJugador.Controls.Add(this.lblPosiciones);
            this.grpDatosJugador.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosJugador.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatosJugador.Controls.Add(this.chkTitular);
            this.grpDatosJugador.Controls.Add(this.lblPosicion);
            this.grpDatosJugador.Controls.Add(this.cboPosicion);
            this.grpDatosJugador.Controls.Add(this.txtNombreJugador);
            this.grpDatosJugador.Controls.Add(this.lblNombreJugador);
            this.grpDatosJugador.Controls.Add(this.txtDorsal);
            this.grpDatosJugador.Controls.Add(this.lblDorsal);
            this.grpDatosJugador.Location = new System.Drawing.Point(282, 3);
            this.grpDatosJugador.Name = "grpDatosJugador";
            this.grpDatosJugador.Size = new System.Drawing.Size(305, 217);
            this.grpDatosJugador.TabIndex = 2;
            this.grpDatosJugador.TabStop = false;
            this.grpDatosJugador.Text = "Datos del Jugador";
            // 
            // btnCapturarJugador
            // 
            this.btnCapturarJugador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapturarJugador.Location = new System.Drawing.Point(6, 175);
            this.btnCapturarJugador.Name = "btnCapturarJugador";
            this.btnCapturarJugador.Size = new System.Drawing.Size(289, 23);
            this.btnCapturarJugador.TabIndex = 4;
            this.btnCapturarJugador.Text = "Capturar &Jugador";
            this.btnCapturarJugador.UseVisualStyleBackColor = true;
            this.btnCapturarJugador.Click += new System.EventHandler(this.btnCapturarJugador_Click);
            // 
            // lblPosiciones
            // 
            this.lblPosiciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosiciones.AutoSize = true;
            this.lblPosiciones.Location = new System.Drawing.Point(119, 79);
            this.lblPosiciones.Name = "lblPosiciones";
            this.lblPosiciones.Size = new System.Drawing.Size(93, 52);
            this.lblPosiciones.TabIndex = 11;
            this.lblPosiciones.Text = "P=Portero\r\nD=Defensor\r\nM=Mediocampista\r\nA=Atacante";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(9, 140);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(110, 13);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "Fecha De Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(122, 139);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(176, 20);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // chkTitular
            // 
            this.chkTitular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTitular.AutoSize = true;
            this.chkTitular.Location = new System.Drawing.Point(9, 114);
            this.chkTitular.Name = "chkTitular";
            this.chkTitular.Size = new System.Drawing.Size(76, 17);
            this.chkTitular.TabIndex = 8;
            this.chkTitular.Text = "Es Titular?";
            this.chkTitular.UseVisualStyleBackColor = true;
            // 
            // lblPosicion
            // 
            this.lblPosicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(6, 87);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(47, 13);
            this.lblPosicion.TabIndex = 7;
            this.lblPosicion.Text = "Posicion";
            // 
            // cboPosicion
            // 
            this.cboPosicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Items.AddRange(new object[] {
            "P",
            "D",
            "M",
            "A"});
            this.cboPosicion.Location = new System.Drawing.Point(62, 87);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(36, 21);
            this.cboPosicion.TabIndex = 6;
            this.cboPosicion.SelectedIndexChanged += new System.EventHandler(this.cboPosicion_SelectedIndexChanged);
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreJugador.Location = new System.Drawing.Point(111, 24);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(163, 20);
            this.txtNombreJugador.TabIndex = 5;
            // 
            // lblNombreJugador
            // 
            this.lblNombreJugador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreJugador.AutoSize = true;
            this.lblNombreJugador.Location = new System.Drawing.Point(6, 27);
            this.lblNombreJugador.Name = "lblNombreJugador";
            this.lblNombreJugador.Size = new System.Drawing.Size(104, 13);
            this.lblNombreJugador.TabIndex = 4;
            this.lblNombreJugador.Text = "Nombre Del Jugador";
            // 
            // txtDorsal
            // 
            this.txtDorsal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDorsal.Location = new System.Drawing.Point(50, 51);
            this.txtDorsal.Name = "txtDorsal";
            this.txtDorsal.Size = new System.Drawing.Size(35, 20);
            this.txtDorsal.TabIndex = 3;
            this.txtDorsal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDorsal
            // 
            this.lblDorsal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDorsal.AutoSize = true;
            this.lblDorsal.Location = new System.Drawing.Point(6, 54);
            this.lblDorsal.Name = "lblDorsal";
            this.lblDorsal.Size = new System.Drawing.Size(37, 13);
            this.lblDorsal.TabIndex = 2;
            this.lblDorsal.Text = "Dorsal";
            this.lblDorsal.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarJugador.AutoSize = true;
            this.btnEliminarJugador.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarJugador.Location = new System.Drawing.Point(263, 232);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(6, 6);
            this.btnEliminarJugador.TabIndex = 3;
            this.btnEliminarJugador.UseVisualStyleBackColor = true;
            this.btnEliminarJugador.Click += new System.EventHandler(this.btnEliminarJugador_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(482, 224);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(120, 23);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(356, 224);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(120, 23);
            this.btnGuardarCambios.TabIndex = 5;
            this.btnGuardarCambios.Text = "Modificar";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(230, 226);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Jugador";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnEliminarJugador);
            this.Controls.Add(this.grpDatosJugador);
            this.Controls.Add(this.grpDatosEquipo);
            this.Controls.Add(this.dtgListaJugadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Equipo de Futbol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaJugadores)).EndInit();
            this.grpDatosEquipo.ResumeLayout(false);
            this.grpDatosEquipo.PerformLayout();
            this.grpDatosJugador.ResumeLayout(false);
            this.grpDatosJugador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaJugadores;
        private System.Windows.Forms.GroupBox grpDatosEquipo;
        private System.Windows.Forms.RadioButton rad2da;
        private System.Windows.Forms.RadioButton rad1ra;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.GroupBox grpDatosJugador;
        private System.Windows.Forms.Button btnCapturarEquipo;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label lblNombreJugador;
        private System.Windows.Forms.TextBox txtDorsal;
        private System.Windows.Forms.Label lblDorsal;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox chkTitular;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblPosiciones;
        private System.Windows.Forms.Button btnCapturarJugador;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEliminar;
    }
}


namespace farmabit
{
    partial class direccionForm
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
            this.components = new System.ComponentModel.Container();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combosec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.comboprov = new System.Windows.Forms.ComboBox();
            this.combomun = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsDireccionBuena = new farmabit.dsDireccionBuena();
            this.dsDireccionBuenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDireccion = new farmabit.DSDireccion();
            this.direccionTableAdapter = new farmabit.DSDireccionTableAdapters.DireccionTableAdapter();
            this.dScompletoPaProbar = new farmabit.DScompletoPaProbar();
            this.direccionTableAdapter1 = new farmabit.DScompletoPaProbarTableAdapters.DireccionTableAdapter();
            this.tableAdapterManager = new farmabit.DScompletoPaProbarTableAdapters.TableAdapterManager();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionBuena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionBuenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dScompletoPaProbar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(161, 36);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 26);
            this.textBox4.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 30);
            this.label11.TabIndex = 63;
            this.label11.Text = "Id dirección:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combosec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCasa);
            this.groupBox1.Controls.Add(this.comboprov);
            this.groupBox1.Controls.Add(this.combomun);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1152, 280);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la dirección";
            // 
            // combosec
            // 
            this.combosec.DisplayMember = "nombre";
            this.combosec.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combosec.FormattingEnabled = true;
            this.combosec.Location = new System.Drawing.Point(106, 150);
            this.combosec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combosec.Name = "combosec";
            this.combosec.Size = new System.Drawing.Size(186, 26);
            this.combosec.TabIndex = 67;
            this.combosec.ValueMember = "nombre";
            this.combosec.SelectedIndexChanged += new System.EventHandler(this.combosec_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 66;
            this.label4.Text = "Sector:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCasa
            // 
            this.txtCasa.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCasa.Location = new System.Drawing.Point(116, 241);
            this.txtCasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(205, 25);
            this.txtCasa.TabIndex = 41;
            // 
            // comboprov
            // 
            this.comboprov.DisplayMember = "nombre";
            this.comboprov.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboprov.FormattingEnabled = true;
            this.comboprov.Location = new System.Drawing.Point(135, 74);
            this.comboprov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboprov.Name = "comboprov";
            this.comboprov.Size = new System.Drawing.Size(186, 26);
            this.comboprov.TabIndex = 38;
            this.comboprov.SelectedIndexChanged += new System.EventHandler(this.comboprov_SelectedIndexChanged);
            this.comboprov.SelectedValueChanged += new System.EventHandler(this.comboprov_SelectedValueChanged);
            this.comboprov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboprov_KeyPress);
            // 
            // combomun
            // 
            this.combomun.DisplayMember = "nombre";
            this.combomun.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combomun.FormattingEnabled = true;
            this.combomun.Location = new System.Drawing.Point(141, 104);
            this.combomun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combomun.Name = "combomun";
            this.combomun.Size = new System.Drawing.Size(186, 26);
            this.combomun.TabIndex = 37;
            this.combomun.ValueMember = "nombre";
            this.combomun.SelectedIndexChanged += new System.EventHandler(this.combomun_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(0, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 30);
            this.label9.TabIndex = 31;
            this.label9.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(116, 191);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(202, 25);
            this.txtCalle.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 30);
            this.label8.TabIndex = 27;
            this.label8.Text = "Municipio:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Provincia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Casa:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(-179, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1477, 64);
            this.panel5.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(565, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(325, 38);
            this.label17.TabIndex = 11;
            this.label17.Text = "REGISTRAR DIRECCION";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(227, 362);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(244, 26);
            this.textBox9.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar por nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 396);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 210);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dsDireccionBuena
            // 
            this.dsDireccionBuena.DataSetName = "dsDireccionBuena";
            this.dsDireccionBuena.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDireccionBuenaBindingSource
            // 
            this.dsDireccionBuenaBindingSource.DataSource = this.dsDireccionBuena;
            this.dsDireccionBuenaBindingSource.Position = 0;
            // 
            // direccionBindingSource
            // 
            this.direccionBindingSource.DataMember = "Direccion";
            this.direccionBindingSource.DataSource = this.dSDireccion;
            // 
            // dSDireccion
            // 
            this.dSDireccion.DataSetName = "DSDireccion";
            this.dSDireccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // direccionTableAdapter
            // 
            this.direccionTableAdapter.ClearBeforeFill = true;
            // 
            // dScompletoPaProbar
            // 
            this.dScompletoPaProbar.DataSetName = "DScompletoPaProbar";
            this.dScompletoPaProbar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // direccionTableAdapter1
            // 
            this.direccionTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuditoriaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Compañia_seguroTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ConducesTableAdapter = null;
            this.tableAdapterManager.Configuracion_puntosTableAdapter = null;
            this.tableAdapterManager.ConfiguracionIVATableAdapter = null;
            this.tableAdapterManager.DescuentosPromocionesTableAdapter = null;
            this.tableAdapterManager.DetalleComprasTableAdapter = null;
            this.tableAdapterManager.DetalleFacturaTableAdapter = null;
            this.tableAdapterManager.DetallePedidoTableAdapter = null;
            this.tableAdapterManager.DireccionTableAdapter = this.direccionTableAdapter1;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.Empresas_aliadasTableAdapter = null;
            this.tableAdapterManager.FacturasServiciosTableAdapter = null;
            this.tableAdapterManager.FacturasTableAdapter = null;
            this.tableAdapterManager.HistorialComprasTableAdapter = null;
            this.tableAdapterManager.HistorialInventarioTableAdapter = null;
            this.tableAdapterManager.HistorialPagosTableAdapter = null;
            this.tableAdapterManager.InspeccionAlmacenamientoTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.MunicipioTableAdapter = null;
            this.tableAdapterManager.Ofertas_alianzasTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.PedidosTableAdapter = null;
            this.tableAdapterManager.PermisoTableAdapter = null;
            this.tableAdapterManager.PersonaTableAdapter = null;
            this.tableAdapterManager.Presentacion_productoTableAdapter = null;
            this.tableAdapterManager.PresentacionTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.ProvinciaTableAdapter = null;
            this.tableAdapterManager.PuestoTableAdapter = null;
            this.tableAdapterManager.Puntos_recompensasTableAdapter = null;
            this.tableAdapterManager.Puntos_transaccionesTableAdapter = null;
            this.tableAdapterManager.RecargaTLFTableAdapter = null;
            this.tableAdapterManager.referencia_telefonoTableAdapter = null;
            this.tableAdapterManager.SectorTableAdapter = null;
            this.tableAdapterManager.seguro_clienteTableAdapter = null;
            this.tableAdapterManager.Seguro_medicoTableAdapter = null;
            this.tableAdapterManager.ServiciosTableAdapter = null;
            this.tableAdapterManager.SubtipoTableAdapter = null;
            this.tableAdapterManager.SucursalTableAdapter = null;
            this.tableAdapterManager.TelefonoTableAdapter = null;
            this.tableAdapterManager.Tipo_afiliado_seguroTableAdapter = null;
            this.tableAdapterManager.TipoTableAdapter = null;
            this.tableAdapterManager.TransporteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = farmabit.DScompletoPaProbarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox4.Location = new System.Drawing.Point(837, 410);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(461, 135);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkBlue;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageKey = "(ninguno)";
            this.button6.Location = new System.Drawing.Point(21, 45);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 62);
            this.button6.TabIndex = 21;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkBlue;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(166, 44);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 65);
            this.button7.TabIndex = 22;
            this.button7.Text = "Guardar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(300, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 65);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // direccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 626);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Name = "direccionForm";
            this.Text = "direccionForm";
            this.Load += new System.EventHandler(this.direccionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionBuena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionBuenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dScompletoPaProbar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.ComboBox comboprov;
        private System.Windows.Forms.ComboBox combomun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DSDireccion dSDireccion;
        private System.Windows.Forms.BindingSource direccionBindingSource;
        private DSDireccionTableAdapters.DireccionTableAdapter direccionTableAdapter;
        private System.Windows.Forms.Label label4;
        private dsDireccionBuena dsDireccionBuena;
        private System.Windows.Forms.BindingSource dsDireccionBuenaBindingSource;
        private DScompletoPaProbar dScompletoPaProbar;
        private DScompletoPaProbarTableAdapters.DireccionTableAdapter direccionTableAdapter1;
        private DScompletoPaProbarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox combosec;
        private System.Windows.Forms.Button button1;
    }
}
﻿namespace ITCManager.Core.UI.Forms
{
    partial class FrmCargaCiudadPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargaCiudadPersonal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ciudadSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTC_DBPOwerDataSet = new ITCManager.Core.UI.ITC_DBPOwerDataSet();
            this.ciudadPersonalSetDataGridView = new System.Windows.Forms.DataGridView();
            this.getPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadPersonalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.CiudadSetTableAdapter();
            this.tableAdapterManager = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager();
            this.ciudadPersonalSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.CiudadPersonalSetTableAdapter();
            this.ciudadSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ciudadSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.getPersonalTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.getPersonalTableAdapter();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadPersonalSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadPersonalSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadSetBindingNavigator)).BeginInit();
            this.ciudadSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.778337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.22166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Controls.Add(this.ciudadSetDataGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ciudadPersonalSetDataGridView, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.72222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 429);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ciudadSetDataGridView
            // 
            this.ciudadSetDataGridView.AutoGenerateColumns = false;
            this.ciudadSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ciudadSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.ciudadSetDataGridView.DataSource = this.ciudadSetBindingSource;
            this.ciudadSetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ciudadSetDataGridView.Location = new System.Drawing.Point(32, 29);
            this.ciudadSetDataGridView.Name = "ciudadSetDataGridView";
            this.ciudadSetDataGridView.Size = new System.Drawing.Size(756, 226);
            this.ciudadSetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCiudad";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCiudad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DesignacionCiudad";
            this.dataGridViewTextBoxColumn2.HeaderText = "DesignacionCiudad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdLocalidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdLocalidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PeriodoApertura";
            this.dataGridViewTextBoxColumn4.HeaderText = "PeriodoApertura";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CantidadMeses";
            this.dataGridViewTextBoxColumn5.HeaderText = "CantidadMeses";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activa";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activa";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NumeroLinea";
            this.dataGridViewTextBoxColumn6.HeaderText = "NumeroLinea";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ciudadSetBindingSource
            // 
            this.ciudadSetBindingSource.DataMember = "CiudadSet";
            this.ciudadSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // iTC_DBPOwerDataSet
            // 
            this.iTC_DBPOwerDataSet.DataSetName = "ITC_DBPOwerDataSet";
            this.iTC_DBPOwerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciudadPersonalSetDataGridView
            // 
            this.ciudadPersonalSetDataGridView.AutoGenerateColumns = false;
            this.ciudadPersonalSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ciudadPersonalSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Empleado,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.ciudadPersonalSetDataGridView.DataSource = this.ciudadPersonalSetBindingSource;
            this.ciudadPersonalSetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ciudadPersonalSetDataGridView.Location = new System.Drawing.Point(32, 261);
            this.ciudadPersonalSetDataGridView.Name = "ciudadPersonalSetDataGridView";
            this.ciudadPersonalSetDataGridView.Size = new System.Drawing.Size(756, 165);
            this.ciudadPersonalSetDataGridView.TabIndex = 1;
            this.ciudadPersonalSetDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ciudadPersonalSetDataGridView_CellClick);
            // 
            // getPersonalBindingSource
            // 
            this.getPersonalBindingSource.DataMember = "getPersonal";
            this.getPersonalBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // ciudadPersonalSetBindingSource
            // 
            this.ciudadPersonalSetBindingSource.DataMember = "FK_CiudadCiudadPersonal";
            this.ciudadPersonalSetBindingSource.DataSource = this.ciudadSetBindingSource;
            // 
            // ciudadSetTableAdapter
            // 
            this.ciudadSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoHorarioSetTableAdapter = null;
            this.tableAdapterManager.ArmadoEquipoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionCiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager.AsignacionReciboSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CajaEfectivoSetTableAdapter = null;
            this.tableAdapterManager.CapacitacionSetTableAdapter = null;
            this.tableAdapterManager.ChequePropioSetTableAdapter = null;
            this.tableAdapterManager.ChequeSetTableAdapter = null;
            this.tableAdapterManager.CiudadActivaLocacionesSetTableAdapter = null;
            this.tableAdapterManager.CiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager.CiudadFechasHorariosSetTableAdapter = null;
            this.tableAdapterManager.CiudadPersonalSetTableAdapter = this.ciudadPersonalSetTableAdapter;
            this.tableAdapterManager.CiudadProductosSetTableAdapter = null;
            this.tableAdapterManager.CiudadSetTableAdapter = this.ciudadSetTableAdapter;
            this.tableAdapterManager.CoeficTarjetasSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
            this.tableAdapterManager.CondicionEmpleadoSetTableAdapter = null;
            this.tableAdapterManager.CuentaBancoSetTableAdapter = null;
            this.tableAdapterManager.CuentaBancoTerceroSetTableAdapter = null;
            this.tableAdapterManager.DepositoSetTableAdapter = null;
            this.tableAdapterManager.DetalleArmadoEquipoSetTableAdapter = null;
            this.tableAdapterManager.DetalleCompraSetTableAdapter = null;
            this.tableAdapterManager.DetalleCondicionEmpleadoTableAdapter = null;
            this.tableAdapterManager.DiaSetTableAdapter = null;
            this.tableAdapterManager.EnvioCiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager.EnvioSetTableAdapter = null;
            this.tableAdapterManager.EstadoAlumnoTableAdapter = null;
            this.tableAdapterManager.EstadoAsignacionEquipoSetTableAdapter = null;
            this.tableAdapterManager.EstadoChequeSetTableAdapter = null;
            this.tableAdapterManager.EstadoCompraSetTableAdapter = null;
            this.tableAdapterManager.EstadoDepositoSetTableAdapter = null;
            this.tableAdapterManager.EstadoPagoTarjetaSetTableAdapter = null;
            this.tableAdapterManager.EstadoRendicionSetTableAdapter = null;
            this.tableAdapterManager.EstadoTransferenciaSetTableAdapter = null;
            this.tableAdapterManager.EstadoVentaSetTableAdapter = null;
            this.tableAdapterManager.FormaPagoLocalSetTableAdapter = null;
            this.tableAdapterManager.FormaPagoSetTableAdapter = null;
            this.tableAdapterManager.GastoBaseSetTableAdapter = null;
            this.tableAdapterManager.GastoChequeSetTableAdapter = null;
            this.tableAdapterManager.GastoLocalSetTableAdapter = null;
            this.tableAdapterManager.HorarioSetTableAdapter = null;
            this.tableAdapterManager.ItemPagadoSetTableAdapter = null;
            this.tableAdapterManager.LocacionRolLocadorSetTableAdapter = null;
            this.tableAdapterManager.LocacionSetTableAdapter = null;
            this.tableAdapterManager.LocalidadSetTableAdapter = null;
            this.tableAdapterManager.MovimientoInternoEfectivoSetTableAdapter = null;
            this.tableAdapterManager.PagoChequeSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalCajaEfectivoSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalChequePropioSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalChequeSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalEnvioSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalSueldoSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalTarjetaSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalTransferenciaSetTableAdapter = null;
            this.tableAdapterManager.PagoSetTableAdapter = null;
            this.tableAdapterManager.PagoTarjetaSetTableAdapter = null;
            this.tableAdapterManager.PermisoAccesoTableAdapter = null;
            this.tableAdapterManager.PermisoTableAdapter = null;
            this.tableAdapterManager.PersonaTableAdapter = null;
            this.tableAdapterManager.PlanBaseSetTableAdapter = null;
            this.tableAdapterManager.PlanVendedorAlumnoSetTableAdapter = null;
            this.tableAdapterManager.ProductosSetTableAdapter = null;
            this.tableAdapterManager.ProveedorSetTableAdapter = null;
            this.tableAdapterManager.PuestoSetTableAdapter = null;
            this.tableAdapterManager.ReciboSetTableAdapter = null;
            this.tableAdapterManager.RendicionDepositoSetTableAdapter = null;
            this.tableAdapterManager.RendicionGastoSetTableAdapter = null;
            this.tableAdapterManager.RendicionPagoSetTableAdapter = null;
            this.tableAdapterManager.RendicionPersonaCiudadSetTableAdapter = null;
            this.tableAdapterManager.RendicionSueldoSetTableAdapter = null;
            this.tableAdapterManager.RendicionValeSetTableAdapter = null;
            this.tableAdapterManager.RendicionVentaEquipoSetTableAdapter = null;
            this.tableAdapterManager.RolAlumnoPracticasSetTableAdapter = null;
            this.tableAdapterManager.RolAlumnoPresentismoSetTableAdapter = null;
            this.tableAdapterManager.RolAlumnoTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaGastosSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaHorarioSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaPlanSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadEnProcesoSetTableAdapter = null;
            this.tableAdapterManager.RolDocenteSetTableAdapter = null;
            this.tableAdapterManager.RolEmpleadoTableAdapter = null;
            this.tableAdapterManager.RolLocacionAlojamientoSetTableAdapter = null;
            this.tableAdapterManager.RolLocacionSalonSetTableAdapter = null;
            this.tableAdapterManager.RolLocadorSetTableAdapter = null;
            this.tableAdapterManager.RolVendedorTableAdapter = null;
            this.tableAdapterManager.SueldoPagoSetTableAdapter = null;
            this.tableAdapterManager.TarjetaPropiaSetTableAdapter = null;
            this.tableAdapterManager.TipoChequeSetTableAdapter = null;
            this.tableAdapterManager.TransferenciaSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValeFinanciacionSetTableAdapter = null;
            this.tableAdapterManager.ValeSetTableAdapter = null;
            // 
            // ciudadPersonalSetTableAdapter
            // 
            this.ciudadPersonalSetTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadSetBindingNavigator
            // 
            this.ciudadSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ciudadSetBindingNavigator.BindingSource = this.ciudadSetBindingSource;
            this.ciudadSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ciudadSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ciudadSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ciudadSetBindingNavigatorSaveItem});
            this.ciudadSetBindingNavigator.Location = new System.Drawing.Point(10, 30);
            this.ciudadSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ciudadSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ciudadSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ciudadSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ciudadSetBindingNavigator.Name = "ciudadSetBindingNavigator";
            this.ciudadSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ciudadSetBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.ciudadSetBindingNavigator.TabIndex = 2;
            this.ciudadSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ciudadSetBindingNavigatorSaveItem
            // 
            this.ciudadSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ciudadSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ciudadSetBindingNavigatorSaveItem.Image")));
            this.ciudadSetBindingNavigatorSaveItem.Name = "ciudadSetBindingNavigatorSaveItem";
            this.ciudadSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ciudadSetBindingNavigatorSaveItem.Text = "Save Data";
            this.ciudadSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.ciudadSetBindingNavigatorSaveItem_Click);
            // 
            // getPersonalTableAdapter
            // 
            this.getPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdCiudadPersonal";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdCiudadPersonal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // Empleado
            // 
            this.Empleado.DataPropertyName = "IdRolEmpleado";
            this.Empleado.DataSource = this.getPersonalBindingSource;
            this.Empleado.DisplayMember = "Column1";
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ValueMember = "IdRolEmpleado";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Periodo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdRolEmpleado";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdRolEmpleado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdCiudad";
            this.dataGridViewTextBoxColumn10.HeaderText = "IdCiudad";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // FrmCargaCiudadPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 487);
            this.Controls.Add(this.ciudadSetBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCargaCiudadPersonal";
            this.Text = "FrmCargaCiudadPersonal";
            this.Load += new System.EventHandler(this.FrmCargaCiudadPersonal_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.ciudadSetBindingNavigator, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadPersonalSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadPersonalSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadSetBindingNavigator)).EndInit();
            this.ciudadSetBindingNavigator.ResumeLayout(false);
            this.ciudadSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ITC_DBPOwerDataSet iTC_DBPOwerDataSet;
        private System.Windows.Forms.BindingSource ciudadSetBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.CiudadSetTableAdapter ciudadSetTableAdapter;
        private ITC_DBPOwerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ciudadSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ciudadSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ciudadSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private ITC_DBPOwerDataSetTableAdapters.CiudadPersonalSetTableAdapter ciudadPersonalSetTableAdapter;
        private System.Windows.Forms.BindingSource ciudadPersonalSetBindingSource;
        private System.Windows.Forms.DataGridView ciudadPersonalSetDataGridView;
        private System.Windows.Forms.BindingSource getPersonalBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.getPersonalTableAdapter getPersonalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}
/*--------------------------------------------------------------
 * Programa “SOFIA” Diseñado para Sernatur
 * 
 * Programador: Oliver Osvaldo Consterla Araya
 * Correo: Oliver_Consterla@Yahoo.cl
 * Numero movil: +56 9 87612427
 * 
 * Programa diseñado con fines de facilitar y ayudar
 * a la automatización de la atención a turista
 * y el cálculo estadísticos que estos pueden conllevar.
 ---------------------------------------------------------------*/

namespace OIT_Sernatur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.HomNum = new System.Windows.Forms.NumericUpDown();
            this.OITBox = new System.Windows.Forms.ComboBox();
            this.oITBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sernatur_RegionalDataSet = new Sofia_Sernatur.Sernatur_RegionalDataSet();
            this.oITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MujNum = new System.Windows.Forms.NumericUpDown();
            this.asesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HorarioBox = new System.Windows.Forms.ComboBox();
            this.horarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TematicaBox = new System.Windows.Forms.ComboBox();
            this.tématicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tématicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.XperBox = new System.Windows.Forms.ComboBox();
            this.experienciasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.experienciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DestBox = new System.Windows.Forms.ComboBox();
            this.regiónDestinoPorRegionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.regiónBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.regiónDestinoPorRegionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regiónBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegiBox = new System.Windows.Forms.ComboBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.PaisBox = new System.Windows.Forms.ComboBox();
            this.nacionalidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nacionalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sernaturRegionalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Calendario = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NumCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PIABox = new System.Windows.Forms.ComboBox();
            this.PIAlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oITTableAdapter = new Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.OITTableAdapter();
            this.nacionalidadTableAdapter = new Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.NacionalidadTableAdapter();
            this.horarioTableAdapter = new Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.HorarioTableAdapter();
            this.tématicaTableAdapter = new Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.TématicaTableAdapter();
            this.experienciasTableAdapter = new Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.ExperienciasTableAdapter();
            this.regiónTableAdapter = new Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.RegiónTableAdapter();
            this.destino_Por_RegionesTableAdapter = new Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.Destino_Por_RegionesTableAdapter();
            this.tématicaPIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIATableAdapter = new Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.PIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HomNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oITBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sernatur_RegionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MujNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asesoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tématicaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tématicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienciasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiónDestinoPorRegionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiónBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiónDestinoPorRegionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiónBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sernaturRegionalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tématicaPIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIT";
            // 
            // HomNum
            // 
            this.HomNum.Location = new System.Drawing.Point(242, 21);
            this.HomNum.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.HomNum.Name = "HomNum";
            this.HomNum.Size = new System.Drawing.Size(166, 20);
            this.HomNum.TabIndex = 9;
            // 
            // OITBox
            // 
            this.OITBox.DataSource = this.oITBindingSource1;
            this.OITBox.DisplayMember = "Oficina";
            this.OITBox.FormattingEnabled = true;
            this.OITBox.Location = new System.Drawing.Point(32, 57);
            this.OITBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OITBox.Name = "OITBox";
            this.OITBox.Size = new System.Drawing.Size(127, 21);
            this.OITBox.TabIndex = 1;
            this.OITBox.ValueMember = "Oficina";
            // 
            // oITBindingSource1
            // 
            this.oITBindingSource1.DataMember = "OIT";
            this.oITBindingSource1.DataSource = this.sernatur_RegionalDataSet;
            // 
            // sernatur_RegionalDataSet
            // 
            this.sernatur_RegionalDataSet.DataSetName = "Sernatur_RegionalDataSet";
            this.sernatur_RegionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mujeres";
            // 
            // MujNum
            // 
            this.MujNum.Location = new System.Drawing.Point(463, 21);
            this.MujNum.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MujNum.Name = "MujNum";
            this.MujNum.Size = new System.Drawing.Size(166, 20);
            this.MujNum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nacionalidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Horario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo de atencion";
            // 
            // HorarioBox
            // 
            this.HorarioBox.DataSource = this.horarioBindingSource1;
            this.HorarioBox.DisplayMember = "Rango Hora";
            this.HorarioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorarioBox.FormattingEnabled = true;
            this.HorarioBox.Location = new System.Drawing.Point(525, 64);
            this.HorarioBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.HorarioBox.Name = "HorarioBox";
            this.HorarioBox.Size = new System.Drawing.Size(105, 21);
            this.HorarioBox.TabIndex = 4;
            this.HorarioBox.ValueMember = "Rango Hora";
            // 
            // horarioBindingSource1
            // 
            this.horarioBindingSource1.DataMember = "Horario";
            this.horarioBindingSource1.DataSource = this.sernatur_RegionalDataSet;
            // 
            // TematicaBox
            // 
            this.TematicaBox.DataSource = this.tématicaBindingSource1;
            this.TematicaBox.DisplayMember = "Tipo";
            this.TematicaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TematicaBox.DropDownWidth = 350;
            this.TematicaBox.FormattingEnabled = true;
            this.TematicaBox.Location = new System.Drawing.Point(166, 181);
            this.TematicaBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TematicaBox.MaxDropDownItems = 15;
            this.TematicaBox.Name = "TematicaBox";
            this.TematicaBox.Size = new System.Drawing.Size(168, 21);
            this.TematicaBox.TabIndex = 6;
            this.TematicaBox.ValueMember = "Tipo";
            this.TematicaBox.SelectedIndexChanged += new System.EventHandler(this.TematicaBox_SelectedIndexChanged);
            // 
            // tématicaBindingSource1
            // 
            this.tématicaBindingSource1.DataMember = "Tématica";
            this.tématicaBindingSource1.DataSource = this.sernatur_RegionalDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Experiencias";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Destinos Priorizados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 207);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Región Consultada";
            // 
            // XperBox
            // 
            this.XperBox.DataSource = this.experienciasBindingSource1;
            this.XperBox.DisplayMember = "Tipo";
            this.XperBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XperBox.FormattingEnabled = true;
            this.XperBox.Location = new System.Drawing.Point(464, 107);
            this.XperBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.XperBox.Name = "XperBox";
            this.XperBox.Size = new System.Drawing.Size(168, 21);
            this.XperBox.TabIndex = 7;
            this.XperBox.ValueMember = "Tipo";
            // 
            // experienciasBindingSource1
            // 
            this.experienciasBindingSource1.DataMember = "Experiencias";
            this.experienciasBindingSource1.DataSource = this.sernatur_RegionalDataSet;
            // 
            // DestBox
            // 
            this.DestBox.DataSource = this.regiónDestinoPorRegionesBindingSource1;
            this.DestBox.DisplayMember = "Destino";
            this.DestBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestBox.DropDownWidth = 508;
            this.DestBox.FormattingEnabled = true;
            this.DestBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DestBox.Location = new System.Drawing.Point(242, 107);
            this.DestBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DestBox.Name = "DestBox";
            this.DestBox.Size = new System.Drawing.Size(168, 21);
            this.DestBox.TabIndex = 11;
            this.DestBox.ValueMember = "Destino";
            // 
            // regiónDestinoPorRegionesBindingSource1
            // 
            this.regiónDestinoPorRegionesBindingSource1.DataMember = "RegiónDestino Por Regiones";
            this.regiónDestinoPorRegionesBindingSource1.DataSource = this.regiónBindingSource1;
            // 
            // regiónBindingSource1
            // 
            this.regiónBindingSource1.DataMember = "Región";
            this.regiónBindingSource1.DataSource = this.sernatur_RegionalDataSet;
            // 
            // regiónDestinoPorRegionesBindingSource
            // 
            this.regiónDestinoPorRegionesBindingSource.DataSource = this.regiónBindingSource;
            // 
            // RegiBox
            // 
            this.RegiBox.DataSource = this.regiónBindingSource1;
            this.RegiBox.DisplayMember = "Nombre";
            this.RegiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegiBox.FormattingEnabled = true;
            this.RegiBox.Location = new System.Drawing.Point(32, 223);
            this.RegiBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RegiBox.Name = "RegiBox";
            this.RegiBox.Size = new System.Drawing.Size(168, 21);
            this.RegiBox.TabIndex = 8;
            this.RegiBox.ValueMember = "Nombre";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(547, 201);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(105, 27);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Enviar Informe";
            this.SendButton.UseMnemonic = false;
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // PaisBox
            // 
            this.PaisBox.DataSource = this.nacionalidadBindingSource1;
            this.PaisBox.DisplayMember = "Nacionalidad";
            this.PaisBox.FormattingEnabled = true;
            this.PaisBox.Location = new System.Drawing.Point(20, 20);
            this.PaisBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PaisBox.Name = "PaisBox";
            this.PaisBox.Size = new System.Drawing.Size(168, 21);
            this.PaisBox.TabIndex = 2;
            this.PaisBox.ValueMember = "Nacionalidad";
            // 
            // nacionalidadBindingSource1
            // 
            this.nacionalidadBindingSource1.DataMember = "Nacionalidad";
            this.nacionalidadBindingSource1.DataSource = this.sernatur_RegionalDataSet;
            // 
            // Calendario
            // 
            this.Calendario.CustomFormat = "dd/mm/yyyy HH:mm tt";
            this.Calendario.Enabled = false;
            this.Calendario.Location = new System.Drawing.Point(525, 24);
            this.Calendario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Calendario.Name = "Calendario";
            this.Calendario.Size = new System.Drawing.Size(105, 20);
            this.Calendario.TabIndex = 14;
            this.Calendario.Value = new System.DateTime(2019, 12, 5, 22, 43, 17, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.NumCount);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.HorarioBox);
            this.splitContainer1.Panel1.Controls.Add(this.Calendario);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PIABox);
            this.splitContainer1.Panel2.Controls.Add(this.SendButton);
            this.splitContainer1.Panel2.Controls.Add(this.DestBox);
            this.splitContainer1.Panel2.Controls.Add(this.TematicaBox);
            this.splitContainer1.Panel2.Controls.Add(this.XperBox);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.PaisBox);
            this.splitContainer1.Panel2.Controls.Add(this.HomNum);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.MujNum);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.PIAlabel);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new System.Drawing.Size(656, 336);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 16;
            // 
            // NumCount
            // 
            this.NumCount.AutoSize = true;
            this.NumCount.Location = new System.Drawing.Point(346, 31);
            this.NumCount.Name = "NumCount";
            this.NumCount.Size = new System.Drawing.Size(74, 13);
            this.NumCount.TabIndex = 15;
            this.NumCount.Text = "Inicializando...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Atenciones del dia:";
            // 
            // PIABox
            // 
            this.PIABox.DataSource = this.tématicaPIABindingSource;
            this.PIABox.DisplayMember = "Nombre Largo";
            this.PIABox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PIABox.Enabled = false;
            this.PIABox.FormattingEnabled = true;
            this.PIABox.Location = new System.Drawing.Point(373, 181);
            this.PIABox.Name = "PIABox";
            this.PIABox.Size = new System.Drawing.Size(156, 21);
            this.PIABox.TabIndex = 13;
            this.PIABox.ValueMember = "Nombre Corto";
            this.PIABox.Visible = false;
            // 
            // PIAlabel
            // 
            this.PIAlabel.AutoSize = true;
            this.PIAlabel.Enabled = false;
            this.PIAlabel.Location = new System.Drawing.Point(370, 165);
            this.PIAlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PIAlabel.Name = "PIAlabel";
            this.PIAlabel.Size = new System.Drawing.Size(154, 13);
            this.PIAlabel.TabIndex = 0;
            this.PIAlabel.Text = "Producto institucional asociado";
            this.PIAlabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // oITTableAdapter
            // 
            this.oITTableAdapter.ClearBeforeFill = true;
            // 
            // nacionalidadTableAdapter
            // 
            this.nacionalidadTableAdapter.ClearBeforeFill = true;
            // 
            // horarioTableAdapter
            // 
            this.horarioTableAdapter.ClearBeforeFill = true;
            // 
            // tématicaTableAdapter
            // 
            this.tématicaTableAdapter.ClearBeforeFill = true;
            // 
            // experienciasTableAdapter
            // 
            this.experienciasTableAdapter.ClearBeforeFill = true;
            // 
            // regiónTableAdapter
            // 
            this.regiónTableAdapter.ClearBeforeFill = true;
            // 
            // destino_Por_RegionesTableAdapter
            // 
            this.destino_Por_RegionesTableAdapter.ClearBeforeFill = true;
            // 
            // tématicaPIABindingSource
            // 
            this.tématicaPIABindingSource.DataMember = "TématicaPIA";
            this.tématicaPIABindingSource.DataSource = this.tématicaBindingSource1;
            // 
            // pIATableAdapter
            // 
            this.pIATableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(676, 360);
            this.Controls.Add(this.RegiBox);
            this.Controls.Add(this.OITBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(16)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SOFIA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oITBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sernatur_RegionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MujNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asesoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tématicaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tématicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienciasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiónDestinoPorRegionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiónBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiónDestinoPorRegionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiónBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sernaturRegionalDataSetBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tématicaPIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HomNum;
        private System.Windows.Forms.ComboBox OITBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MujNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox HorarioBox;
        private System.Windows.Forms.ComboBox TematicaBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox XperBox;
        private System.Windows.Forms.ComboBox DestBox;
        private System.Windows.Forms.ComboBox RegiBox;
        private System.Windows.Forms.BindingSource oITBindingSource;
        private System.Windows.Forms.BindingSource asesoresBindingSource;
        private System.Windows.Forms.BindingSource horarioBindingSource;
        private System.Windows.Forms.BindingSource tématicaBindingSource;
        private System.Windows.Forms.BindingSource experienciasBindingSource;
        private System.Windows.Forms.BindingSource regiónBindingSource;
        private System.Windows.Forms.BindingSource regiónDestinoPorRegionesBindingSource;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ComboBox PaisBox;
        private System.Windows.Forms.BindingSource sernaturRegionalDataSetBindingSource;
        private System.Windows.Forms.BindingSource nacionalidadBindingSource;
        private System.Windows.Forms.DateTimePicker Calendario;
        private Sofia_Sernatur.Sernatur_RegionalDataSet sernatur_RegionalDataSet;
        private System.Windows.Forms.BindingSource oITBindingSource1;
        private Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.OITTableAdapter oITTableAdapter;
        private System.Windows.Forms.BindingSource nacionalidadBindingSource1;
        private Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.NacionalidadTableAdapter nacionalidadTableAdapter;
        private System.Windows.Forms.BindingSource horarioBindingSource1;
        private Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.HorarioTableAdapter horarioTableAdapter;
        private System.Windows.Forms.BindingSource tématicaBindingSource1;
        private Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.TématicaTableAdapter tématicaTableAdapter;
        private System.Windows.Forms.BindingSource experienciasBindingSource1;
        private Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.ExperienciasTableAdapter experienciasTableAdapter;
        private System.Windows.Forms.BindingSource regiónBindingSource1;
        private Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.RegiónTableAdapter regiónTableAdapter;
        private System.Windows.Forms.BindingSource regiónDestinoPorRegionesBindingSource1;
        private Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.Destino_Por_RegionesTableAdapter destino_Por_RegionesTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label NumCount;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox PIABox;
        private System.Windows.Forms.Label PIAlabel;
        private System.Windows.Forms.BindingSource tématicaPIABindingSource;
        private Sofia_Sernatur.Sernatur_RegionalDataSetTableAdapters.PIATableAdapter pIATableAdapter;
    }
}


namespace persistenciaArchivos
{
    partial class CreateFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilesForm));
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroChequeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.CrearArchivoButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpsertPanel = new System.Windows.Forms.Panel();
            this.EmisorLabel = new System.Windows.Forms.Label();
            this.InstitucionTextBox = new System.Windows.Forms.TextBox();
            this.ReceptorTextBox = new System.Windows.Forms.TextBox();
            this.EmisorTextBox = new System.Windows.Forms.TextBox();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.DescripcionLlabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroChequeLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NumeroChequeTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.InformacionRutaLabel = new System.Windows.Forms.Label();
            this.BorrarRenglonButton = new System.Windows.Forms.Button();
            this.InformationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ReceptorLabel = new System.Windows.Forms.Label();
            this.InstitucionLabel = new System.Windows.Forms.Label();
            this.MonedaLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.EmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstituciónColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonedaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MonedaComboBox = new System.Windows.Forms.ComboBox();
            this.MontoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.UpsertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreColumn,
            this.NumeroChequeColumn,
            this.MontoColumn,
            this.DescripcionColumn,
            this.EmisorColumn,
            this.ReceptorColumn,
            this.InstituciónColumn,
            this.MonedaColumn,
            this.FechaColumn});
            this.ChequesDataGridView.Location = new System.Drawing.Point(279, 83);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.Size = new System.Drawing.Size(946, 391);
            this.ChequesDataGridView.TabIndex = 2;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // NumeroChequeColumn
            // 
            this.NumeroChequeColumn.HeaderText = "Número Cheque";
            this.NumeroChequeColumn.Name = "NumeroChequeColumn";
            this.NumeroChequeColumn.ReadOnly = true;
            // 
            // MontoColumn
            // 
            this.MontoColumn.HeaderText = "Monto en Colones";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripción";
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(279, 493);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CrearArchivoButton
            // 
            this.CrearArchivoButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CrearArchivoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CrearArchivoButton.Location = new System.Drawing.Point(1123, 493);
            this.CrearArchivoButton.Name = "CrearArchivoButton";
            this.CrearArchivoButton.Size = new System.Drawing.Size(93, 23);
            this.CrearArchivoButton.TabIndex = 11;
            this.CrearArchivoButton.Text = "Crear Archivo";
            this.CrearArchivoButton.UseVisualStyleBackColor = false;
            this.CrearArchivoButton.Click += new System.EventHandler(this.CrearArchivoButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // UpsertPanel
            // 
            this.UpsertPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UpsertPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.UpsertPanel.Controls.Add(this.MontoNumericUpDown);
            this.UpsertPanel.Controls.Add(this.MonedaComboBox);
            this.UpsertPanel.Controls.Add(this.FechaDateTimePicker);
            this.UpsertPanel.Controls.Add(this.FechaLabel);
            this.UpsertPanel.Controls.Add(this.MonedaLabel);
            this.UpsertPanel.Controls.Add(this.InstitucionLabel);
            this.UpsertPanel.Controls.Add(this.ReceptorLabel);
            this.UpsertPanel.Controls.Add(this.EmisorLabel);
            this.UpsertPanel.Controls.Add(this.InstitucionTextBox);
            this.UpsertPanel.Controls.Add(this.ReceptorTextBox);
            this.UpsertPanel.Controls.Add(this.EmisorTextBox);
            this.UpsertPanel.Controls.Add(this.MontoLabel);
            this.UpsertPanel.Controls.Add(this.DescripcionLlabel);
            this.UpsertPanel.Controls.Add(this.DescripcionTextBox);
            this.UpsertPanel.Controls.Add(this.NumeroChequeLabel);
            this.UpsertPanel.Controls.Add(this.NombreLabel);
            this.UpsertPanel.Controls.Add(this.NumeroChequeTextBox);
            this.UpsertPanel.Controls.Add(this.NombreTextBox);
            this.UpsertPanel.Controls.Add(this.AgregarButton);
            this.UpsertPanel.Controls.Add(this.LimpiarButton);
            this.UpsertPanel.Location = new System.Drawing.Point(0, 0);
            this.UpsertPanel.Name = "UpsertPanel";
            this.UpsertPanel.Size = new System.Drawing.Size(251, 535);
            this.UpsertPanel.TabIndex = 12;
            // 
            // EmisorLabel
            // 
            this.EmisorLabel.AutoSize = true;
            this.EmisorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmisorLabel.Location = new System.Drawing.Point(20, 129);
            this.EmisorLabel.Name = "EmisorLabel";
            this.EmisorLabel.Size = new System.Drawing.Size(38, 13);
            this.EmisorLabel.TabIndex = 24;
            this.EmisorLabel.Text = "Emisor";
            this.EmisorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // InstitucionTextBox
            // 
            this.InstitucionTextBox.Location = new System.Drawing.Point(21, 232);
            this.InstitucionTextBox.Name = "InstitucionTextBox";
            this.InstitucionTextBox.Size = new System.Drawing.Size(205, 20);
            this.InstitucionTextBox.TabIndex = 5;
            // 
            // ReceptorTextBox
            // 
            this.ReceptorTextBox.Location = new System.Drawing.Point(21, 184);
            this.ReceptorTextBox.Name = "ReceptorTextBox";
            this.ReceptorTextBox.Size = new System.Drawing.Size(205, 20);
            this.ReceptorTextBox.TabIndex = 4;
            // 
            // EmisorTextBox
            // 
            this.EmisorTextBox.Location = new System.Drawing.Point(23, 145);
            this.EmisorTextBox.Name = "EmisorTextBox";
            this.EmisorTextBox.Size = new System.Drawing.Size(203, 20);
            this.EmisorTextBox.TabIndex = 3;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.ForeColor = System.Drawing.Color.White;
            this.MontoLabel.Location = new System.Drawing.Point(18, 90);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(110, 13);
            this.MontoLabel.TabIndex = 20;
            this.MontoLabel.Text = "Monto (Solo números)";
            // 
            // DescripcionLlabel
            // 
            this.DescripcionLlabel.AutoSize = true;
            this.DescripcionLlabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLlabel.Location = new System.Drawing.Point(20, 358);
            this.DescripcionLlabel.Name = "DescripcionLlabel";
            this.DescripcionLlabel.Size = new System.Drawing.Size(212, 13);
            this.DescripcionLlabel.TabIndex = 18;
            this.DescripcionLlabel.Text = "Descripción( min 10 caractéres, encriptada)";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(21, 390);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(205, 97);
            this.DescripcionTextBox.TabIndex = 8;
            this.DescripcionTextBox.TextChanged += new System.EventHandler(this.DescripcionTextBox_TextChanged);
            // 
            // NumeroChequeLabel
            // 
            this.NumeroChequeLabel.AutoSize = true;
            this.NumeroChequeLabel.ForeColor = System.Drawing.Color.White;
            this.NumeroChequeLabel.Location = new System.Drawing.Point(18, 51);
            this.NumeroChequeLabel.Name = "NumeroChequeLabel";
            this.NumeroChequeLabel.Size = new System.Drawing.Size(185, 13);
            this.NumeroChequeLabel.TabIndex = 16;
            this.NumeroChequeLabel.Text = "Número de cheque (min 5 caractéres)";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.ForeColor = System.Drawing.Color.White;
            this.NombreLabel.Location = new System.Drawing.Point(18, 12);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(131, 13);
            this.NombreLabel.TabIndex = 15;
            this.NombreLabel.Text = "Nombre (min 3 caractéres)";
            // 
            // NumeroChequeTextBox
            // 
            this.NumeroChequeTextBox.Location = new System.Drawing.Point(21, 67);
            this.NumeroChequeTextBox.Name = "NumeroChequeTextBox";
            this.NumeroChequeTextBox.Size = new System.Drawing.Size(205, 20);
            this.NumeroChequeTextBox.TabIndex = 1;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(21, 28);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(205, 20);
            this.NombreTextBox.TabIndex = 0;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(151, 493);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 9;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(23, 493);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ListaChequesLabel
            // 
            this.ListaChequesLabel.AutoSize = true;
            this.ListaChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListaChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaChequesLabel.ForeColor = System.Drawing.Color.Black;
            this.ListaChequesLabel.Location = new System.Drawing.Point(448, 12);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(169, 24);
            this.ListaChequesLabel.TabIndex = 15;
            this.ListaChequesLabel.Text = "Lista de cheques";
            // 
            // InformacionRutaLabel
            // 
            this.InformacionRutaLabel.Location = new System.Drawing.Point(279, 37);
            this.InformacionRutaLabel.Name = "InformacionRutaLabel";
            this.InformacionRutaLabel.Size = new System.Drawing.Size(471, 41);
            this.InformacionRutaLabel.TabIndex = 16;
            this.InformacionRutaLabel.Text = "@InformacionRutaArchivos";
            // 
            // BorrarRenglonButton
            // 
            this.BorrarRenglonButton.Location = new System.Drawing.Point(375, 493);
            this.BorrarRenglonButton.Name = "BorrarRenglonButton";
            this.BorrarRenglonButton.Size = new System.Drawing.Size(95, 23);
            this.BorrarRenglonButton.TabIndex = 11;
            this.BorrarRenglonButton.Text = "Borrar renglón";
            this.BorrarRenglonButton.UseVisualStyleBackColor = true;
            this.BorrarRenglonButton.Click += new System.EventHandler(this.BorrarRenglonButton_Click);
            // 
            // InformationProvider
            // 
            this.InformationProvider.ContainerControl = this;
            this.InformationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InformationProvider.Icon")));
            // 
            // ReceptorLabel
            // 
            this.ReceptorLabel.AutoSize = true;
            this.ReceptorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReceptorLabel.Location = new System.Drawing.Point(20, 168);
            this.ReceptorLabel.Name = "ReceptorLabel";
            this.ReceptorLabel.Size = new System.Drawing.Size(51, 13);
            this.ReceptorLabel.TabIndex = 25;
            this.ReceptorLabel.Text = "Receptor";
            // 
            // InstitucionLabel
            // 
            this.InstitucionLabel.AutoSize = true;
            this.InstitucionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InstitucionLabel.Location = new System.Drawing.Point(18, 207);
            this.InstitucionLabel.Name = "InstitucionLabel";
            this.InstitucionLabel.Size = new System.Drawing.Size(107, 13);
            this.InstitucionLabel.TabIndex = 26;
            this.InstitucionLabel.Text = "Institucion Financiera";
            // 
            // MonedaLabel
            // 
            this.MonedaLabel.AutoSize = true;
            this.MonedaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonedaLabel.Location = new System.Drawing.Point(18, 263);
            this.MonedaLabel.Name = "MonedaLabel";
            this.MonedaLabel.Size = new System.Drawing.Size(46, 13);
            this.MonedaLabel.TabIndex = 27;
            this.MonedaLabel.Text = "Moneda";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FechaLabel.Location = new System.Drawing.Point(18, 302);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(37, 13);
            this.FechaLabel.TabIndex = 29;
            this.FechaLabel.Text = "Fecha";
            // 
            // EmisorColumn
            // 
            this.EmisorColumn.HeaderText = "Emisor";
            this.EmisorColumn.Name = "EmisorColumn";
            this.EmisorColumn.ReadOnly = true;
            // 
            // ReceptorColumn
            // 
            this.ReceptorColumn.HeaderText = "Receptor";
            this.ReceptorColumn.Name = "ReceptorColumn";
            this.ReceptorColumn.ReadOnly = true;
            // 
            // InstituciónColumn
            // 
            this.InstituciónColumn.HeaderText = "Institución Financiera";
            this.InstituciónColumn.Name = "InstituciónColumn";
            this.InstituciónColumn.ReadOnly = true;
            // 
            // MonedaColumn
            // 
            this.MonedaColumn.HeaderText = "Moneda";
            this.MonedaColumn.Name = "MonedaColumn";
            this.MonedaColumn.ReadOnly = true;
            // 
            // FechaColumn
            // 
            this.FechaColumn.HeaderText = "Fecha";
            this.FechaColumn.Name = "FechaColumn";
            this.FechaColumn.ReadOnly = true;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Location = new System.Drawing.Point(21, 318);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDateTimePicker.TabIndex = 7;
            // 
            // MonedaComboBox
            // 
            this.MonedaComboBox.FormattingEnabled = true;
            this.MonedaComboBox.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Colon",
            "Peso"});
            this.MonedaComboBox.Location = new System.Drawing.Point(21, 278);
            this.MonedaComboBox.Name = "MonedaComboBox";
            this.MonedaComboBox.Size = new System.Drawing.Size(200, 21);
            this.MonedaComboBox.TabIndex = 6;
            // 
            // MontoNumericUpDown
            // 
            this.MontoNumericUpDown.Location = new System.Drawing.Point(21, 106);
            this.MontoNumericUpDown.Name = "MontoNumericUpDown";
            this.MontoNumericUpDown.Size = new System.Drawing.Size(205, 20);
            this.MontoNumericUpDown.TabIndex = 2;
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 535);
            this.Controls.Add(this.InformacionRutaLabel);
            this.Controls.Add(this.BorrarRenglonButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.UpsertPanel);
            this.Controls.Add(this.CrearArchivoButton);
            this.Controls.Add(this.ChequesDataGridView);
            this.Controls.Add(this.ListaChequesLabel);
            this.Name = "CreateFilesForm";
            this.Text = "Información de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFilesForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.UpsertPanel.ResumeLayout(false);
            this.UpsertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button CrearArchivoButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel UpsertPanel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.Label DescripcionLlabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label NumeroChequeLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NumeroChequeTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label InformacionRutaLabel;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroChequeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.Button BorrarRenglonButton;
        private System.Windows.Forms.ErrorProvider InformationProvider;
        private System.Windows.Forms.Label EmisorLabel;
        private System.Windows.Forms.TextBox InstitucionTextBox;
        private System.Windows.Forms.TextBox ReceptorTextBox;
        private System.Windows.Forms.TextBox EmisorTextBox;
        private System.Windows.Forms.Label InstitucionLabel;
        private System.Windows.Forms.Label ReceptorLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label MonedaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstituciónColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonedaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaColumn;
        private System.Windows.Forms.NumericUpDown MontoNumericUpDown;
        private System.Windows.Forms.ComboBox MonedaComboBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
    }
}


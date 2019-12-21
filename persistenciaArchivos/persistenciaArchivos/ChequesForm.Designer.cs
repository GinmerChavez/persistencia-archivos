namespace persistenciaArchivos
{
    partial class ChequesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequesForm));
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroChequeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstituciónColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonedaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlChequesLabel = new System.Windows.Forms.Label();
            this.RefrescarButton = new System.Windows.Forms.Button();
            this.Refreshtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.ChequesDataGridView.Location = new System.Drawing.Point(75, 99);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.Size = new System.Drawing.Size(955, 302);
            this.ChequesDataGridView.TabIndex = 3;
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
            // ControlChequesLabel
            // 
            this.ControlChequesLabel.AutoSize = true;
            this.ControlChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ControlChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.ControlChequesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ControlChequesLabel.Location = new System.Drawing.Point(459, 9);
            this.ControlChequesLabel.Name = "ControlChequesLabel";
            this.ControlChequesLabel.Size = new System.Drawing.Size(267, 31);
            this.ControlChequesLabel.TabIndex = 16;
            this.ControlChequesLabel.Text = "Control de cheques";
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.RefrescarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RefrescarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RefrescarButton.Location = new System.Drawing.Point(930, 9);
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(100, 50);
            this.RefrescarButton.TabIndex = 23;
            this.RefrescarButton.Text = "Refrescar";
            this.RefrescarButton.UseVisualStyleBackColor = false;
            this.RefrescarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // ChequesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1409, 447);
            this.Controls.Add(this.RefrescarButton);
            this.Controls.Add(this.ControlChequesLabel);
            this.Controls.Add(this.ChequesDataGridView);
            this.Name = "ChequesForm";
            this.Text = "Sistema de control de cheques";
            this.Load += new System.EventHandler(this.ChequesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroChequeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstituciónColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonedaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaColumn;
        private System.Windows.Forms.Label ControlChequesLabel;
        private System.Windows.Forms.Button RefrescarButton;
        private System.Windows.Forms.Timer Refreshtimer;
    }
}
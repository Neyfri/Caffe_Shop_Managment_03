namespace Coffe_Shop_Management.All_Controls
{
    partial class UC_SalesReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SalesReport));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label121 = new System.Windows.Forms.Label();
            this.txtSearchRecord = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvSalesReport = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnPrint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(336, 25);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(86, 20);
            this.label121.TabIndex = 0;
            this.label121.Text = "Search by:";
            // 
            // txtSearchRecord
            // 
            this.txtSearchRecord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchRecord.DefaultText = "";
            this.txtSearchRecord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRecord.DisabledState.Parent = this.txtSearchRecord;
            this.txtSearchRecord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRecord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRecord.FocusedState.Parent = this.txtSearchRecord;
            this.txtSearchRecord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRecord.HoverState.Parent = this.txtSearchRecord;
            this.txtSearchRecord.Location = new System.Drawing.Point(340, 45);
            this.txtSearchRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchRecord.Name = "txtSearchRecord";
            this.txtSearchRecord.PasswordChar = '\0';
            this.txtSearchRecord.PlaceholderText = "";
            this.txtSearchRecord.SelectedText = "";
            this.txtSearchRecord.ShadowDecoration.Parent = this.txtSearchRecord;
            this.txtSearchRecord.Size = new System.Drawing.Size(315, 36);
            this.txtSearchRecord.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchRecord.TabIndex = 1;
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSalesReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSalesReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalesReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesReport.ColumnHeadersHeight = 40;
            this.dgvSalesReport.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSalesReport.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSalesReport.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSalesReport.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvSalesReport.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSalesReport.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvSalesReport.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSalesReport.CurrentTheme.Name = null;
            this.dgvSalesReport.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSalesReport.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSalesReport.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSalesReport.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesReport.EnableHeadersVisualStyles = false;
            this.dgvSalesReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSalesReport.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvSalesReport.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSalesReport.Location = new System.Drawing.Point(59, 110);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersVisible = false;
            this.dgvSalesReport.RowTemplate.Height = 40;
            this.dgvSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesReport.Size = new System.Drawing.Size(867, 255);
            this.dgvSalesReport.TabIndex = 2;
            this.dgvSalesReport.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvSalesReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesReport_CellContentClick);
            // 
            // btnPrint
            // 
            this.btnPrint.AllowToggling = false;
            this.btnPrint.AnimationSpeed = 200;
            this.btnPrint.AutoGenerateColors = false;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.ButtonText = "Report";
            this.btnPrint.ButtonTextMarginLeft = 0;
            this.btnPrint.ColorContrastOnClick = 45;
            this.btnPrint.ColorContrastOnHover = 45;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPrint.CustomizableEdges = borderEdges1;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnPrint.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrint.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrint.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.IconMarginLeft = 11;
            this.btnPrint.IconPadding = 10;
            this.btnPrint.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.IdleBorderColor = System.Drawing.Color.Cyan;
            this.btnPrint.IdleBorderRadius = 44;
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrint.IdleIconLeftImage = null;
            this.btnPrint.IdleIconRightImage = null;
            this.btnPrint.IndicateFocus = false;
            this.btnPrint.Location = new System.Drawing.Point(753, 36);
            this.btnPrint.Name = "btnPrint";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 44;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnPrint.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 44;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnPrint.OnPressedState = stateProperties2;
            this.btnPrint.Size = new System.Drawing.Size(115, 45);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.TextMarginLeft = 0;
            this.btnPrint.UseDefaultRadiusAndThickness = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID: ";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSid.Location = new System.Drawing.Point(54, 25);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(48, 25);
            this.lblSid.TabIndex = 5;
            this.lblSid.Text = "----";
            // 
            // UC_SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblSid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.txtSearchRecord);
            this.Controls.Add(this.label121);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_SalesReport";
            this.Size = new System.Drawing.Size(1006, 414);
            this.Load += new System.EventHandler(this.UC_SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label121;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchRecord;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvSalesReport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSid;
    }
}

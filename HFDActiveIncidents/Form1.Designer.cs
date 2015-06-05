namespace HFDActiveIncidents
{
    partial class Form1
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
            this.grdIncidents = new System.Windows.Forms.DataGridView();
            this.ctxmenuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.googleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdIncidents)).BeginInit();
            this.ctxmenuDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdIncidents
            // 
            this.grdIncidents.AllowUserToAddRows = false;
            this.grdIncidents.AllowUserToDeleteRows = false;
            this.grdIncidents.AllowUserToOrderColumns = true;
            this.grdIncidents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIncidents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIncidents.Location = new System.Drawing.Point(0, 0);
            this.grdIncidents.MultiSelect = false;
            this.grdIncidents.Name = "grdIncidents";
            this.grdIncidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdIncidents.Size = new System.Drawing.Size(761, 351);
            this.grdIncidents.TabIndex = 0;
            this.grdIncidents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdIncidents_CellClick);
            // 
            // ctxmenuDataGrid
            // 
            this.ctxmenuDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleMapsToolStripMenuItem});
            this.ctxmenuDataGrid.Name = "ctxmenuDataGrid";
            this.ctxmenuDataGrid.Size = new System.Drawing.Size(145, 26);
            // 
            // googleMapsToolStripMenuItem
            // 
            this.googleMapsToolStripMenuItem.Name = "googleMapsToolStripMenuItem";
            this.googleMapsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.googleMapsToolStripMenuItem.Text = "Google Maps";
            this.googleMapsToolStripMenuItem.Click += new System.EventHandler(this.googleMapsToolStripMenuItem_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // lblLoading
            // 
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(314, 163);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(132, 25);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading Data...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoading.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 351);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.grdIncidents);
            this.Name = "Form1";
            this.Text = "HFD Active Incidents Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdIncidents)).EndInit();
            this.ctxmenuDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdIncidents;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.ContextMenuStrip ctxmenuDataGrid;
        private System.Windows.Forms.ToolStripMenuItem googleMapsToolStripMenuItem;
        private System.Windows.Forms.Label lblLoading;
    }
}


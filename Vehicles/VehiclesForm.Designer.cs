
namespace Vehicles
{
    partial class VehiclesForm
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
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.vehiclesListView = new System.Windows.Forms.ListView();
            this.modelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productionDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxVelocityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.vehiclesListView);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer.TabIndex = 2;
            this.toolStripContainer.Text = "toolStripContainer";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // vehiclesListView
            // 
            this.vehiclesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modelHeader,
            this.typeHeader,
            this.productionDateHeader,
            this.maxVelocityHeader});
            this.vehiclesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehiclesListView.HideSelection = false;
            this.vehiclesListView.Location = new System.Drawing.Point(0, 0);
            this.vehiclesListView.Name = "vehiclesListView";
            this.vehiclesListView.Size = new System.Drawing.Size(800, 450);
            this.vehiclesListView.TabIndex = 0;
            this.vehiclesListView.UseCompatibleStateImageBehavior = false;
            this.vehiclesListView.View = System.Windows.Forms.View.Details;
            this.vehiclesListView.SelectedIndexChanged += new System.EventHandler(this.VehiclesListView_SelectedIndexChanged);
            // 
            // modelHeader
            // 
            this.modelHeader.Text = "Model";
            this.modelHeader.Width = 131;
            // 
            // typeHeader
            // 
            this.typeHeader.Text = "Type";
            this.typeHeader.Width = 189;
            // 
            // productionDateHeader
            // 
            this.productionDateHeader.Text = "Production date";
            this.productionDateHeader.Width = 327;
            // 
            // maxVelocityHeader
            // 
            this.maxVelocityHeader.Text = "Max velocity";
            this.maxVelocityHeader.Width = 251;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(67, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.Visible = false;
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton,
            this.toolStripFilter});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(234, 38);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Visible = false;
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Image = global::Vehicles.Properties.Resources.add;
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(33, 35);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addToolStripButton.ToolTipText = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.Enabled = false;
            this.editToolStripButton.Image = global::Vehicles.Properties.Resources.edit;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(31, 35);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editToolStripButton.ToolTipText = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.Enabled = false;
            this.deleteToolStripButton.Image = global::Vehicles.Properties.Resources.delete;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(44, 35);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteToolStripButton.ToolTipText = "Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripFilter
            // 
            this.toolStripFilter.Items.AddRange(new object[] {
            "All",
            "Over 100",
            "Under 100"});
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new System.Drawing.Size(121, 38);
            this.toolStripFilter.Text = "All";
            this.toolStripFilter.SelectedIndexChanged += new System.EventHandler(this.ToolStripFilter_SelectedIndexChanged);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "VehiclesForm";
            this.Text = "Vehicles";
            this.Activated += new System.EventHandler(this.VehiclesForm_Activated);
            this.Deactivate += new System.EventHandler(this.VehiclesForm_Deactivated);
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ListView vehiclesListView;
        private System.Windows.Forms.ColumnHeader modelHeader;
        private System.Windows.Forms.ColumnHeader typeHeader;
        private System.Windows.Forms.ColumnHeader productionDateHeader;
        private System.Windows.Forms.ColumnHeader maxVelocityHeader;
        private System.Windows.Forms.ToolStripComboBox toolStripFilter;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
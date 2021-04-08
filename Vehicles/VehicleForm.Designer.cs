namespace Vehicles
{
    partial class VehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleForm));
            this.productionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.maxVelocityLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.maxVelocityTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.typeSelectorControl = new Vehicles.TypeSelectorControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeSelectorControl)).BeginInit();
            this.SuspendLayout();
            // 
            // productionDateTimePicker
            // 
            this.productionDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productionDateTimePicker.Location = new System.Drawing.Point(91, 81);
            this.productionDateTimePicker.Name = "productionDateTimePicker";
            this.productionDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.productionDateTimePicker.TabIndex = 7;
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Location = new System.Drawing.Point(3, 78);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(82, 13);
            this.productionDateLabel.TabIndex = 3;
            this.productionDateLabel.Text = "Production date";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(3, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "Model";
            // 
            // maxVelocityLabel
            // 
            this.maxVelocityLabel.AutoSize = true;
            this.maxVelocityLabel.Location = new System.Drawing.Point(3, 52);
            this.maxVelocityLabel.Name = "maxVelocityLabel";
            this.maxVelocityLabel.Size = new System.Drawing.Size(66, 13);
            this.maxVelocityLabel.TabIndex = 2;
            this.maxVelocityLabel.Text = "Max velocity";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTextBox.Location = new System.Drawing.Point(91, 3);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(152, 20);
            this.modelTextBox.TabIndex = 4;
            this.modelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ModelTextBox_Validating);
            this.modelTextBox.Validated += new System.EventHandler(this.ModelTextBox_Validated);
            // 
            // maxVelocityTextBox
            // 
            this.maxVelocityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxVelocityTextBox.Location = new System.Drawing.Point(91, 55);
            this.maxVelocityTextBox.Name = "maxVelocityTextBox";
            this.maxVelocityTextBox.Size = new System.Drawing.Size(152, 20);
            this.maxVelocityTextBox.TabIndex = 6;
            this.maxVelocityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MaxVelocityTextBox_Validating);
            this.maxVelocityTextBox.Validated += new System.EventHandler(this.MaxVelocityTextBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(24, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 20);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(131, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 20);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeTextBox.Location = new System.Drawing.Point(91, 29);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(152, 20);
            this.typeTextBox.TabIndex = 5;
            this.typeTextBox.Text = "Motorcycle";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(3, 26);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.typeSelectorControl);
            this.splitContainer1.Size = new System.Drawing.Size(758, 467);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.modelLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.typeTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.typeLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.modelTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.maxVelocityLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.productionDateLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.maxVelocityTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.productionDateTimePicker, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 429);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel3.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cancelButton, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 438);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(246, 26);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // typeSelectorControl
            // 
            this.typeSelectorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeSelectorControl.Image = ((System.Drawing.Image)(resources.GetObject("typeSelectorControl.Image")));
            this.typeSelectorControl.InitialImage = global::Vehicles.Properties.Resources.car;
            this.typeSelectorControl.Location = new System.Drawing.Point(0, 0);
            this.typeSelectorControl.Name = "typeSelectorControl";
            this.typeSelectorControl.Size = new System.Drawing.Size(502, 467);
            this.typeSelectorControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typeSelectorControl.TabIndex = 0;
            this.typeSelectorControl.TabStop = false;
            this.typeSelectorControl.Type = Vehicles.TypeSelectorControl.Types.Motorcycle;
            this.typeSelectorControl.Click += new System.EventHandler(this.TypeSelectorControl_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 467);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VehicleForm";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeSelectorControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker productionDateTimePicker;
        private System.Windows.Forms.Label productionDateLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label maxVelocityLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox maxVelocityTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private TypeSelectorControl typeSelectorControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
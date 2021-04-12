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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeftBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.typeSelectorControl = new Vehicles.TypeSelectorControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelLeftTop.SuspendLayout();
            this.tableLayoutPanelLeftBottom.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeSelectorControl)).BeginInit();
            this.SuspendLayout();
            // 
            // productionDateTimePicker
            // 
            this.productionDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productionDateTimePicker.Location = new System.Drawing.Point(91, 81);
            this.productionDateTimePicker.Name = "productionDateTimePicker";
            this.productionDateTimePicker.Size = new System.Drawing.Size(203, 20);
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
            this.modelTextBox.Size = new System.Drawing.Size(203, 20);
            this.modelTextBox.TabIndex = 4;
            this.modelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ModelTextBox_Validating);
            this.modelTextBox.Validated += new System.EventHandler(this.ModelTextBox_Validated);
            // 
            // maxVelocityTextBox
            // 
            this.maxVelocityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxVelocityTextBox.Location = new System.Drawing.Point(91, 55);
            this.maxVelocityTextBox.Name = "maxVelocityTextBox";
            this.maxVelocityTextBox.Size = new System.Drawing.Size(203, 20);
            this.maxVelocityTextBox.TabIndex = 6;
            this.maxVelocityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MaxVelocityTextBox_Validating);
            this.maxVelocityTextBox.Validated += new System.EventHandler(this.MaxVelocityTextBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(45, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 20);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(173, 3);
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
            this.typeTextBox.Size = new System.Drawing.Size(203, 20);
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
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanelLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanelRight);
            this.splitContainer.Size = new System.Drawing.Size(594, 225);
            this.splitContainer.SplitterDistance = 325;
            this.splitContainer.TabIndex = 0;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelLeftTop, 0, 0);
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelLeftBottom, 0, 1);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 2;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(325, 225);
            this.tableLayoutPanelLeft.TabIndex = 0;
            // 
            // tableLayoutPanelLeftTop
            // 
            this.tableLayoutPanelLeftTop.ColumnCount = 3;
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelLeftTop.Controls.Add(this.typeTextBox, 1, 1);
            this.tableLayoutPanelLeftTop.Controls.Add(this.typeLabel, 0, 1);
            this.tableLayoutPanelLeftTop.Controls.Add(this.modelTextBox, 1, 0);
            this.tableLayoutPanelLeftTop.Controls.Add(this.maxVelocityLabel, 0, 2);
            this.tableLayoutPanelLeftTop.Controls.Add(this.productionDateLabel, 0, 3);
            this.tableLayoutPanelLeftTop.Controls.Add(this.maxVelocityTextBox, 1, 2);
            this.tableLayoutPanelLeftTop.Controls.Add(this.productionDateTimePicker, 1, 3);
            this.tableLayoutPanelLeftTop.Controls.Add(this.modelLabel, 0, 0);
            this.tableLayoutPanelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeftTop.Name = "tableLayoutPanelLeftTop";
            this.tableLayoutPanelLeftTop.RowCount = 5;
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftTop.Size = new System.Drawing.Size(319, 187);
            this.tableLayoutPanelLeftTop.TabIndex = 0;
            // 
            // tableLayoutPanelLeftBottom
            // 
            this.tableLayoutPanelLeftBottom.AutoSize = true;
            this.tableLayoutPanelLeftBottom.ColumnCount = 5;
            this.tableLayoutPanelLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanelLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanelLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanelLeftBottom.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanelLeftBottom.Controls.Add(this.cancelButton, 3, 0);
            this.tableLayoutPanelLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftBottom.Location = new System.Drawing.Point(3, 196);
            this.tableLayoutPanelLeftBottom.Name = "tableLayoutPanelLeftBottom";
            this.tableLayoutPanelLeftBottom.RowCount = 1;
            this.tableLayoutPanelLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftBottom.Size = new System.Drawing.Size(319, 26);
            this.tableLayoutPanelLeftBottom.TabIndex = 1;
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 3;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.Controls.Add(this.typeSelectorControl, 1, 1);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 3;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(265, 225);
            this.tableLayoutPanelRight.TabIndex = 0;
            // 
            // typeSelectorControl
            // 
            this.typeSelectorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeSelectorControl.Image = ((System.Drawing.Image)(resources.GetObject("typeSelectorControl.Image")));
            this.typeSelectorControl.InitialImage = global::Vehicles.Properties.Resources.car;
            this.typeSelectorControl.Location = new System.Drawing.Point(29, 25);
            this.typeSelectorControl.Name = "typeSelectorControl";
            this.typeSelectorControl.Size = new System.Drawing.Size(206, 174);
            this.typeSelectorControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typeSelectorControl.TabIndex = 0;
            this.typeSelectorControl.TabStop = false;
            this.typeSelectorControl.Type = Vehicles.TypeSelectorControl.Types.Truck;
            this.typeSelectorControl.Click += new System.EventHandler(this.TypeSelectorControl_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 225);
            this.Controls.Add(this.splitContainer);
            this.Name = "VehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelLeft.PerformLayout();
            this.tableLayoutPanelLeftTop.ResumeLayout(false);
            this.tableLayoutPanelLeftTop.PerformLayout();
            this.tableLayoutPanelLeftBottom.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
    }
}
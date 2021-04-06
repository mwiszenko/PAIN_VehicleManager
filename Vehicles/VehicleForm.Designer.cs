
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
            this.typeSelectorControl = new Vehicles.TypeSelectorControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSelectorControl)).BeginInit();
            this.SuspendLayout();
            // 
            // productionDateTimePicker
            // 
            this.productionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productionDateTimePicker.Location = new System.Drawing.Point(138, 126);
            this.productionDateTimePicker.Name = "productionDateTimePicker";
            this.productionDateTimePicker.Size = new System.Drawing.Size(243, 20);
            this.productionDateTimePicker.TabIndex = 4;
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Location = new System.Drawing.Point(31, 133);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(82, 13);
            this.productionDateLabel.TabIndex = 5;
            this.productionDateLabel.Text = "Production date";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(31, 24);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.Text = "Model";
            // 
            // maxVelocityLabel
            // 
            this.maxVelocityLabel.AutoSize = true;
            this.maxVelocityLabel.Location = new System.Drawing.Point(31, 97);
            this.maxVelocityLabel.Name = "maxVelocityLabel";
            this.maxVelocityLabel.Size = new System.Drawing.Size(66, 13);
            this.maxVelocityLabel.TabIndex = 8;
            this.maxVelocityLabel.Text = "Max velocity";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(138, 17);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(123, 20);
            this.modelTextBox.TabIndex = 9;
            this.modelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ModelTextBox_Validating);
            this.modelTextBox.Validated += new System.EventHandler(this.ModelTextBox_Validated);
            // 
            // maxVelocityTextBox
            // 
            this.maxVelocityTextBox.Location = new System.Drawing.Point(138, 90);
            this.maxVelocityTextBox.Name = "maxVelocityTextBox";
            this.maxVelocityTextBox.Size = new System.Drawing.Size(123, 20);
            this.maxVelocityTextBox.TabIndex = 11;
            this.maxVelocityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MaxVelocityTextBox_Validating);
            this.maxVelocityTextBox.Validated += new System.EventHandler(this.MaxVelocityTextBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(99, 161);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 161);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(138, 53);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(123, 20);
            this.typeTextBox.TabIndex = 14;
            this.typeTextBox.Text = "Motorcycle";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(31, 60);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 15;
            this.typeLabel.Text = "Type";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // typeSelectorControl
            // 
            this.typeSelectorControl.Image = ((System.Drawing.Image)(resources.GetObject("typeSelectorControl.Image")));
            this.typeSelectorControl.InitialImage = global::Vehicles.Properties.Resources.car;
            this.typeSelectorControl.Location = new System.Drawing.Point(281, 17);
            this.typeSelectorControl.Name = "typeSelectorControl";
            this.typeSelectorControl.Size = new System.Drawing.Size(100, 100);
            this.typeSelectorControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.typeSelectorControl.TabIndex = 16;
            this.typeSelectorControl.TabStop = false;
            this.typeSelectorControl.Type = Vehicles.TypeSelectorControl.Types.Motorcycle;
            this.typeSelectorControl.Click += new System.EventHandler(this.TypeSelectorControl_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 196);
            this.Controls.Add(this.typeSelectorControl);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.maxVelocityTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.maxVelocityLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.productionDateLabel);
            this.Controls.Add(this.productionDateTimePicker);
            this.Name = "VehicleForm";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSelectorControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
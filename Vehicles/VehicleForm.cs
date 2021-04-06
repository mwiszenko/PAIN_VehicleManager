using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Vehicles.TypeSelectorControl;

namespace Vehicles
{
    public partial class VehicleForm : Form
    {
        private Vehicle vehicle;
        public VehicleForm(Vehicle vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;
        }
        public string Model
        {
            get { return modelTextBox.Text; }
        }

        public Types Type
        {
            get { return typeSelectorControl.Type; }
        }

        public double MaxVelocity
        {
            get { return double.Parse(maxVelocityTextBox.Text); }
        }

        public DateTime ProductionDate
        {
            get { return productionDateTimePicker.Value; }
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TypeSelectorControl_Click(object sender, EventArgs e)
        {
            typeTextBox.Text = typeSelectorControl.ToString();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                modelTextBox.Text = vehicle.Model;
                productionDateTimePicker.Value = vehicle.ProductionDate;
                maxVelocityTextBox.Text = vehicle.MaxVelocity.ToString();

                switch (vehicle.Type)
                {
                    case Types.Motorcycle:
                        typeSelectorControl.Type = Types.Motorcycle;
                        typeSelectorControl.SetImage();
                        typeTextBox.Text = "Motorcycle";
                        break;
                    case Types.Car:
                        typeSelectorControl.Type = Types.Car;
                        typeSelectorControl.SetImage();
                        typeTextBox.Text = "Car";
                        break;
                    case Types.Truck:
                        typeSelectorControl.Type = Types.Truck;
                        typeSelectorControl.SetImage();
                        typeTextBox.Text = "Truck";
                        break;
                }
            }
        }

        private void MaxVelocityTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double velocity = double.Parse(maxVelocityTextBox.Text);
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                errorProvider.SetError(maxVelocityTextBox, exception.Message);
            }
        }

        private void MaxVelocityTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(maxVelocityTextBox, "");
        }

        private void ModelTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (modelTextBox.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(modelTextBox, "Field cannot be empty!");
            }
        }

        private void ModelTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(modelTextBox, "");
        }
    }
}

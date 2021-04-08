using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class VehiclesForm : Form
    {
        private Document Document { get; set; }
        enum FilterOptions { ALL, OVER_100, UNDER_100 }
        FilterOptions Filter = FilterOptions.ALL;

        public VehiclesForm(Document document)
        {
            InitializeComponent();
            Document = document;
            Document.AddVehicleEvent += Document_AddVehicleEvent;
            Document.UpdateVehicleEvent += Document_UpdateVehicleEvent;
            Document.DeleteVehicleEvent += Document_DeleteVehicleEvent;
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void VehiclesForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStrip, ((MainForm)MdiParent).toolStrip);
        }

        private void VehiclesForm_Deactivated(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).toolStrip, toolStrip);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleForm vehicleForm = new VehicleForm(null);
            if (vehicleForm.ShowDialog() == DialogResult.OK)
            {
                Vehicle newVehicle = new Vehicle(vehicleForm.Model, vehicleForm.Type, vehicleForm.ProductionDate, vehicleForm.MaxVelocity);

                Document.AddVehicle(newVehicle);
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem vehicleItem in vehiclesListView.SelectedItems)
            {
                Vehicle vehicle = (Vehicle)vehicleItem.Tag;
                VehicleForm vehicleForm = new VehicleForm(vehicle);
                if (vehicleForm.ShowDialog() == DialogResult.OK)
                {
                    vehicle.Model = vehicleForm.Model;
                    vehicle.Type = vehicleForm.Type;
                    vehicle.ProductionDate = vehicleForm.ProductionDate;
                    vehicle.MaxVelocity = vehicleForm.MaxVelocity;

                    Document.UpdateVehicle(vehicle);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem vehicleItem in vehiclesListView.SelectedItems)
                {
                    Vehicle vehicle = (Vehicle)vehicleItem.Tag;
                    Document.DeleteVehicle(vehicle);
                }
            }
        }

        private void Document_AddVehicleEvent(Vehicle vehicle)
        {
            if (MaxVelocityFilter(vehicle))
            {
                AddItem(vehicle);
            }
        }

        private void Document_UpdateVehicleEvent(Vehicle vehicle)
        {
            foreach (ListViewItem item in vehiclesListView.Items)
            {
                if (item.Tag == vehicle)
                {
                    item.SubItems[0].Text = vehicle.Model;
                    item.SubItems[1].Text = vehicle.Type.ToString();
                    item.SubItems[2].Text = vehicle.ProductionDate.ToShortDateString();
                    item.SubItems[3].Text = vehicle.MaxVelocity.ToString();
                    if (!MaxVelocityFilter(vehicle))
                    {
                        vehiclesListView.Items.Remove(item);
                    }
                    UpdateNumberOfItemsOnLabel();
                    return;
                }
            }

            if (MaxVelocityFilter(vehicle))
            {
                AddItem(vehicle);
            }
        }

        private void Document_DeleteVehicleEvent(Vehicle vehicle)
        {
            foreach (ListViewItem item in vehiclesListView.Items)
            {
                if (item.Tag == vehicle)
                {
                    vehiclesListView.Items.Remove(item);
                    UpdateNumberOfItemsOnLabel();
                    return;
                }
            }
        }

        private bool MaxVelocityFilter(Vehicle vehicle)
        {
            switch (Filter)
            {
                case FilterOptions.ALL:
                    return true;
                case FilterOptions.OVER_100:
                    return vehicle.MaxVelocity >= 100.0;
                case FilterOptions.UNDER_100:
                    return vehicle.MaxVelocity < 100.0;
                default:
                    return true;
            }
        }

        private List<Vehicle> FilterList(List<Vehicle> vehicles)
        {
            return vehicles.Where(MaxVelocityFilter).ToList();
        }

        private void UpdateList()
        {
            vehiclesListView.Items.Clear();
            foreach (Vehicle vehicle in FilterList(Document.vehicles))
            {
                AddItem(vehicle);
            }
        }

        private void AddItem(Vehicle vehicle)
        {
            ListViewItem viewItem = new ListViewItem();
            viewItem.Tag = vehicle;
            UpdateItem(viewItem);
            vehiclesListView.Items.Add(viewItem);
            UpdateNumberOfItemsOnLabel();
        }

        private void UpdateItem(ListViewItem item)
        {
            Vehicle vehicle = (Vehicle)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = vehicle.Model;
            item.SubItems[1].Text = vehicle.Type.ToString();
            item.SubItems[2].Text = vehicle.ProductionDate.ToShortDateString();
            item.SubItems[3].Text = vehicle.MaxVelocity.ToString();
        }

        private void VehiclesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehiclesListView.SelectedItems.Count == 0)
            {
                deleteToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                deleteToolStripButton.Enabled = false;
                editToolStripButton.Enabled = false;
            }
            else
            {
                deleteToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                deleteToolStripButton.Enabled = true;
                editToolStripButton.Enabled = true;
            }
        }

        private void ToolStripFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(toolStripFilter.Text)
            {
                case "All":
                    this.Filter = FilterOptions.ALL;
                    break;
                case "Over 100":
                    this.Filter = FilterOptions.OVER_100;
                    break;
                case "Under 100":
                    this.Filter = FilterOptions.UNDER_100;
                    break;
                default:
                    this.Filter = FilterOptions.ALL;
                    break;
            }
            UpdateList();
            UpdateNumberOfItemsOnLabel();
        }

        private void UpdateNumberOfItemsOnLabel()
        {
            itemsToolStripStatusLabel.Text = "Number of items: " + vehiclesListView.Items.Count;
        }
    }
}

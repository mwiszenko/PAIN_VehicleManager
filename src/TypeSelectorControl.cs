using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace Vehicles
{
    public class TypeSelectorEditor : UITypeEditor
    {
        public TypeSelectorEditor()
        {
        }

        // Indicates whether the UITypeEditor provides a form-based (modal) dialog, 
        // drop down dialog, or no UI outside of the properties window.
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        // Displays the UI for value selection.
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            // Uses the IWindowsFormsEditorService to display a 
            // drop-down UI in the Properties window.
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                TypeSelectorControl typeControl = new TypeSelectorControl();
                typeControl.Type = (TypeSelectorControl.Types) value;
                edSvc.DropDownControl(typeControl);
                return typeControl.Type;
            }
            return value;
        }

        // Indicates whether the UITypeEditor supports painting a 
        // representation of a property's value.
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }

    [ToolboxBitmap(typeof(PictureBox))]
    public class TypeSelectorControl : PictureBox
    {

        public enum Types { Motorcycle = 0, Car = 1, Truck = 2 };

        private Types _type;

        [BrowsableAttribute(true)]
        [EditorAttribute(typeof(TypeSelectorEditor), typeof(UITypeEditor))]
        public Types Type
        {
            get
            {
                return this._type;
            }

            set
            {
                _type = value;
                SetImage();
            }
        }

        public TypeSelectorControl()
        {
            Type = Types.Motorcycle;
            Image = Properties.Resources.motorcycle;
            Click += TypeSelectorControl_Click;
        }

        public override string ToString()
        {
            return _type.ToString();
        }

        public void TypeSelectorControl_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case Types.Motorcycle:
                    this.Image = Properties.Resources.car;
                    this.Type = Types.Car;
                    break;
                case Types.Car:
                    this.Image = Properties.Resources.truck;
                    this.Type = Types.Truck;
                    break;
                case Types.Truck:
                    this.Image = Properties.Resources.motorcycle;
                    this.Type = Types.Motorcycle;
                    break;

            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void SetImage()
        {
            switch (Type)
            {
                case Types.Motorcycle:
                    this.Image = Properties.Resources.motorcycle;
                    break;
                case Types.Car:
                    this.Image = Properties.Resources.car;
                    break;
                case Types.Truck:
                    this.Image = Properties.Resources.truck;
                    break;

            }
        }
    }
}
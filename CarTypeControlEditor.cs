using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PAIN_Projekt
{
    class CarTypeControlEditor : UITypeEditor
    {
        CarType currentCarType;
       

        public override void PaintValue(PaintValueEventArgs e)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);

            System.Drawing.Image image = null;
            if(currentCarType == CarType.MOTOR) image = Properties.Resources.motor;
            else if(currentCarType == CarType.CAR) image = Properties.Resources.car;
            else if(currentCarType == CarType.TRUCK) image = Properties.Resources.truck;

            e.Graphics.DrawImage(image, rect);

        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            CarTypeControl owner = context.Instance as CarTypeControl;
            currentCarType = owner.Type;
            return true;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc =
                (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            if (edSvc != null)
            {
                CarTypeControl carTypeControl = new CarTypeControl();
                carTypeControl.Type = currentCarType;


                edSvc.DropDownControl(carTypeControl);
                currentCarType = carTypeControl.Type;

                return carTypeControl.Type;
            }

            return value;
        }
    }
}

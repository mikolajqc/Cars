using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_Projekt
{
    public partial class CarTypeControl : UserControl
    {
        List<Bitmap> vehicleImages = new List<Bitmap>();
        private CarType carType;

        [Category("Data")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public CarType Type
        {
            get
            {
                return carType;
            }
            set
            {
                carType = value;
                BackgroundImage = vehicleImages[(int)carType];
            }
        }

        public CarTypeControl()
        {
            InitializeComponent();
            vehicleImages.Add(Properties.Resources.motor);
            vehicleImages.Add(Properties.Resources.car);
            vehicleImages.Add(Properties.Resources.truck);
        }

        private void CarTypeControl_Click(object sender, EventArgs e)
        {
            carType = (CarType)((int)(carType + 1) % 3);
            BackgroundImage = vehicleImages[(int)carType];
        }
    }
}

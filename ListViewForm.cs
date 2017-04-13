using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_Projekt
{
#if DEBUG
    public partial class ListViewForm : ViewFormImpl
#else
    public partial class ListViewForm : ViewForm
#endif
    {
        public ListViewForm()
        {
            InitializeComponent();
        }

        public override void AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public override void EditCar(Car car)
        {
            throw new NotImplementedException();
        }

        public override void DeleteCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}

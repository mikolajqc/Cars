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

        public override Car GetSelectedCar()
        {
            Car resultCar = null;

            if (carsListView.SelectedItems.Count == 1)
            {
                resultCar = (Car)carsListView.SelectedItems[0].Tag;
            }

            return resultCar;
        }

        public override void AddCar(Car car)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = car;
            UpdateItem(item);
            carsListView.Items.Add(item);
        }

        public override void EditCar(Car car, Car oldCar)
        {
            foreach (ListViewItem item in carsListView.Items)
            {
                if (oldCar == (Car)item.Tag)
                {
                    item.Tag = car;
                    UpdateItem(item);
                    break;
                }
            }
        }

        public override void DeleteCar(Car car)
        {
            foreach (ListViewItem item in carsListView.Items)
            {
                if(car == (Car)item.Tag)
                {
                    carsListView.Items.Remove(item);
                    break;
                }
            }
        }

        public void UpdateItem(ListViewItem item)
        {
            Car car = (Car)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = car.Brand;
            item.SubItems[1].Text = car.MaxSpeed.ToString();
            item.SubItems[2].Text = car.ProductionYear.ToString();
            item.SubItems[3].Text = car.Type;
        }

        public override void UpdateAll(List<Car> cars)
        {
            //zrob cleaning
            foreach (Car car in cars)
            {
                AddCar(car);
            }
        }
    }
}

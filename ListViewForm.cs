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
        //private bool filterIsOn = false;
        //private bool filterMore = false;
        private short filterConf = 0; // 0 all, 1 <=, 2 >

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
            if (FilterPosition(car))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = car;
                UpdateItem(item);
                carsListView.Items.Add(item);
            }
        }

        public override void EditCar(Car car)
        {
            foreach (ListViewItem item in carsListView.Items)
            {
                if (car == (Car)item.Tag)
                {
                    if (FilterPosition(car))
                    {//to nie dziala
                        UpdateItem(item);
                        return;
                    }
                    else
                    { //to dziala
                        carsListView.Items.Remove(item);
                        return;
                    }
                }

            }

            if(FilterPosition(car))
            {
                AddCar(car);
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

        public override void UpdateAll(/*List<Car> cars*/)
        {
            //zrob cleaning
            carsListView.Items.Clear();
            List<Car> cars = (MdiParent as MainForm).Cars;

            foreach (Car car in cars)
            {
                if(FilterPosition(car))AddCar(car);
            }
        }

        private void maxSpeed100ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (filterConf != 1)
            {
                filterConf = 1;
                UpdateAll();
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(filterConf != 0)
            {
                filterConf = 0;
                UpdateAll();
            }

        }

        private void maxSpeed100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filterConf != 2)
            {
                filterConf = 2;
                UpdateAll();
            }
        }

        private bool FilterPosition(Car car)
        {
            bool result = true;
            switch (filterConf)
            {
                case 1:
                    {
                        if (car.MaxSpeed < 100) result = false;
                        break;
                    }
                case 2:
                    {
                        if (car.MaxSpeed >= 100) result = false;
                        break;
                    }
            }
            return result;
        }
    }
}

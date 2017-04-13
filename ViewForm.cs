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
    public abstract partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm(null);
            if (carForm.ShowDialog() == DialogResult.OK)
            {
                Car newCar = new Car(carForm.CarBrand, carForm.CarMaxSpeed, carForm.CarProductionYear, carForm.CarType);
                (MdiParent as MainForm).AddCar(newCar);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Car oldCar = GetSelectedCar();
            if (oldCar != null)
            {
                CarForm carForm = new CarForm(oldCar);
                if (carForm.ShowDialog() == DialogResult.OK)
                {
                    Car newCar = new Car(carForm.CarBrand, carForm.CarMaxSpeed, carForm.CarProductionYear, carForm.CarType);
                    (MdiParent as MainForm).EditCar(newCar, oldCar);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Car oldCar = GetSelectedCar();
            if (oldCar != null)
            {
                (MdiParent as MainForm).DeleteCar(oldCar);
            }
        }

        public abstract Car GetSelectedCar();

        public abstract void AddCar(Car car);
        public abstract void EditCar(Car car, Car oldCar);
        public abstract void DeleteCar(Car car);

        public abstract void UpdateAll(List<Car> cars);

    }

#if DEBUG
    public class ViewFormImpl : ViewForm
    {
        public override Car GetSelectedCar()
        {
            throw new NotImplementedException();
        }

        public override void AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public override void EditCar(Car car, Car oldCar)
        {
            throw new NotImplementedException();
        }

        public override void DeleteCar(Car car)
        {
            throw new NotImplementedException();
        }

        public override void UpdateAll(List<Car> cars)
        {
            throw new NotImplementedException();
        }
    }
#endif
}

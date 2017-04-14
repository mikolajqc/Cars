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
    public partial class CarForm : Form
    {
        private Car car;

        public string CarBrand
        {
            get { return brandTextBox.Text; }
        }

        public long CarMaxSpeed
        {
            get { return long.Parse(maxSpeedTextBox.Text); }
        }

        public long CarProductionYear
        {
            get { return long.Parse(productionYearTextBox.Text); }
        }

        /*
        public string CarType
        {
            get { return typeTextBox.Text; }
        }
        */

        public CarType CarType
        {
            get { return carTypeControl1.Type; }
        }

        public CarForm(Car car)
        {
            InitializeComponent();
            this.car = car;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            if (car != null)
            {
                brandTextBox.Text = car.Brand;
                maxSpeedTextBox.Text = car.MaxSpeed.ToString();
                productionYearTextBox.Text = car.ProductionYear.ToString();
                carTypeControl1.Type = car.Type;
            }
        }

        private void MaxSpeedTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                long maxSpeed = long.Parse(maxSpeedTextBox.Text);
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                errorProvider.SetError(maxSpeedTextBox, exception.Message);
            }
        }

        private void MaxSpeedTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(maxSpeedTextBox, "");
        }

        private void ProductionYearTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                long productionYear = long.Parse(productionYearTextBox.Text);
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                errorProvider.SetError(productionYearTextBox, exception.Message);
            }
        }

        private void ProductionYearTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(productionYearTextBox, "");
        }
    }
}

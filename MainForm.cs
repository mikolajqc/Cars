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
    public partial class MainForm : Form
    {
        List<Car> cars = new List<Car>();

        public MainForm()
        {
            InitializeComponent();
            this.MdiChildActivate += new EventHandler(MainForm_MdiChildActivate);
        }

        private void listViewFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewForm listViewForm = new ListViewForm();
            listViewForm.MdiParent = this;
            listViewForm.Show();
            listViewForm.UpdateAll(cars);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            ViewForm activeMdiChild = (ViewForm)this.ActiveMdiChild;
            ToolStripManager.RevertMerge(this.toolStrip1);
            ToolStripManager.Merge(activeMdiChild.toolStrip1, this.toolStrip1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //first Window
            ListViewForm listViewForm = new ListViewForm();
            listViewForm.MdiParent = this;
            listViewForm.Show();
            listViewForm.UpdateAll(cars);
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
            //calling virtual methods in ViewForm
            foreach (ViewForm viewForm in MdiChildren)
            {
                viewForm.AddCar(car);
            }
        }

    }
}

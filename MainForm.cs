﻿using System;
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

        public List<Car> Cars
        {
            get
            {
                return cars;
            }
        }


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
            listViewForm.UpdateAll();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            ViewForm activeMdiChild = (ViewForm)this.ActiveMdiChild;
            ToolStripManager.RevertMerge(toolStrip1);
            ToolStripManager.Merge(activeMdiChild.toolStrip1, toolStrip1);
            ToolStripManager.RevertMerge(statusStrip1);
            ToolStripManager.Merge(activeMdiChild.statusStrip1, statusStrip1);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ListViewForm listViewForm = new ListViewForm();
            listViewForm.MdiParent = this;
            listViewForm.Show();
            listViewForm.UpdateAll();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
            foreach (ViewForm viewForm in MdiChildren)
            {
                viewForm.AddCar(car);
            }
        }

        public void EditCar(Car car)
        {
            foreach (ViewForm viewForm in MdiChildren)
            {
                viewForm.EditCar(car);
            }

        }

        public void DeleteCar(Car car)
        {
            cars.Remove(car);

            foreach (ViewForm viewForm in MdiChildren)
            {
                viewForm.DeleteCar(car);
            }
        }

    }
}

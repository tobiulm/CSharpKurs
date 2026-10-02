using ItSchulungen.CSharpKurs.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EventsWinFormsApp
{
    public partial class EventHandlerForm : Form
    {
        public EventHandlerForm()
        {
            InitializeComponent();
        }

        private void EventHandlerForm_Load(object sender, EventArgs e)
        {
            Form1.theEmployee.DepartmentChanged += TheEmployee_DepartmentChanged;

        }

        private void TheEmployee_DepartmentChanged(DepartmentChangedEventArgs args)
        {
            outputLabel.Text = $"Die Abteilung wurde um {DateTime.Now.ToLongTimeString()} von {args.OldDepartment} auf {args.NewDepartment} geändert!";
        }

        private void AnotherEventHandler(DepartmentChangedEventArgs args)
        {
            MessageBox.Show("Die zweite Logik die ausgeführt wird wenn das Employee.DepartmentChanged Ereignis ausgelöst wurde");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.theEmployee.DepartmentChanged += AnotherEventHandler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.theEmployee.DepartmentChanged -= AnotherEventHandler;
        }
    }
}

using ItSchulungen.CSharpKurs.ClassLibrary;

namespace EventsWinFormsApp
{
    public partial class Form1 : Form
    {
        internal static Employee theEmployee;


        public Form1()
        {
            InitializeComponent();
            departmentsComboBox.DataSource = Enum.GetValues(typeof(Department));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theEmployee = new Employee();
            theEmployee.FirstName = firstNameTextBox.Text;
            theEmployee.LastName = lastNameTextBox.Text;
            theEmployee.Department = Enum.Parse<Department>(departmentsComboBox.Text);


            // theEmployee.Calcu Die Erweiterungsmethode CalculateAge gibt es in diesem Projekt nicht! Nur in ConsoleApp!!!

            outputLabel.Text = $"Der Angestellte wurde angelegt! Vorname={theEmployee.FirstName}, Nachname={theEmployee.LastName}, Abteilung={theEmployee.Department}";
            EventHandlerForm childForm = new EventHandlerForm();
            childForm.Show(this);
            button1.Enabled = false;

        }

        private void departmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (theEmployee != null)
            {
                theEmployee.Department = Enum.Parse<Department>(departmentsComboBox.Text);
            }
        }
    }
}
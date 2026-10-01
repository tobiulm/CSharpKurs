using InterfaceWinFormsApp.Prototype;
using ItSchulungen.CSharpKurs.ClassLibrary;
using ItSchulungen.CSharpKurs.InterfaceLibrary;

namespace InterfaceWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            //IHuman human = new HumanPrototype();
            IHuman human = new Human();
            human.FirstName = firstNameTextBox.Text;
            human.LastName = lastNameTextBox.Text;

            label3.Text = human.Greet();
        }
    }
}
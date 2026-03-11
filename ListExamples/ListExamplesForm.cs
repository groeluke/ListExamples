

using System.CodeDom.Compiler;

namespace ListExamples
{
    public partial class ListExamplesForm : Form
    {
        public ListExamplesForm()
        {
            InitializeComponent();
        }
        //Custom Methods below this point----------------------------------------------
        void ListExampleMethod(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Jack");
            names.Add("Jasmine");
            this.Text = names.Count.ToString();
            names.Remove("Jack");
            this.Text = names.Count.ToString();
        }

        void AddItemToListBox()
        {
            ListBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text} {CompanyTextBox.Text}");
        }

        void AddItemToComboBox()
        {
            ComboBox.Items.Add($"{LastNameTextBox.Text}, {FirstNameTextBox.Text}");
            if(ComboBox.Items.Count > 0)
            {
                ComboBox.SelectedIndex = 0;
                
            }   
        }

        void ClearListBox()
        {
            ListBox.Items.Clear();
            ComboBox.Items.Clear();
        }

        void ClearTextBoxes()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            CompanyTextBox.Text = "";
        }

        // Event handlers below this point----------------------------------------------

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ListExampleMethod(sender, e);
            AddItemToListBox();
            AddItemToComboBox();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearListBox();
            ClearTextBoxes();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //isolate company
            string[] temp = ListBox.SelectedItem.ToString().Split(" ");
            CompanyTextBox.Text = temp[1];
            //isolate first and last name
            temp = temp[0].Split(",");
            FirstNameTextBox.Text = temp[1];
            LastNameTextBox.Text = temp[0];
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //select the corosponding entry in the list box
            ListBox.SelectedIndex = ComboBox.SelectedIndex;
            //this.Text = ComboBox.SelectedIndex.ToString();
        }
    }
}

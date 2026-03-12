

using System.CodeDom.Compiler;

namespace ListExamples
{
    public partial class ListExamplesForm : Form
    {
        public ListExamplesForm()
        {
            InitializeComponent();
            SetDefaults();
            LoadTestData();
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
            if (ComboBox.Items.Count > 0)
            {
                ComboBox.SelectedIndex = 0;

            }
        }



        void ClearListBox()
        {
            ListBox.Items.Clear();
        }

        void LoadTestData()
        {
            ListBox.Items.Add("Smith,John Microsoft");
            ListBox.Items.Add("Doe,Jane Apple");
            ListBox.Items.Add("Attack,Zack Logger");
            ListBox.Items.Add("Dirt,Joe Micro");
            ListBox.Items.Add("John,Smith Google");
            ComboBox.Items.Add("Smith, John");
            ComboBox.Items.Add("Doe, Jane");
            ComboBox.Items.Add("Attack, Zack");
            ComboBox.Items.Add("Dirt, Joe");
            ComboBox.Items.Add("John, Smith");

        }


        void SetDefaults()
        {
            // clear text boxes
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            CompanyTextBox.Text = "";
            //reset combo box and list box selections
            if (ComboBox.Items.Count > 0 & ListBox.Items.Count > 0)
            {
                ComboBox.SelectedIndex = 0;
                ListBox.SelectedIndex = 0;
            }
            // disable submit button until text is entered
            SubmitButton.Enabled = false;
            FirstNameTextBox.Select();
        }

        // Event handlers below this point----------------------------------------------

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ListExampleMethod(sender, e);
            AddItemToListBox();
            AddItemToComboBox();
            SetDefaults();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

            //list are a muteable data type, so we can change the text boxes without changing the list box entry
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //select the corosponding entry in the list box
            ListBox.SelectedIndex = ComboBox.SelectedIndex;
            //this.Text = ComboBox.SelectedIndex.ToString();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text != "")
            {
                FirstNameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = true;
            }
            else
            {
                FirstNameTextBox.BackColor = Color.White;
                SubmitButton.Enabled = false;
            }
        }
        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text != "")
            {
                LastNameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = true;
            }
            else
            {
                LastNameTextBox.BackColor = Color.White;
                SubmitButton.Enabled = false;
            }
        }

        private void CompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CompanyTextBox.Text != "")
            {
                CompanyTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = true;
            }
            else
            {
                CompanyTextBox.BackColor = Color.White;
                SubmitButton.Enabled = false;
            }
        }
    }
}

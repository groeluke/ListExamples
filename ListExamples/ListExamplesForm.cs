

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

        void AddItemToListBox(object sender, EventArgs e)
        {
            if (CompanyTextBox.Text != "")
            {
                ListBox.Items.Add(CompanyTextBox.Text);
                CompanyTextBox.Clear();
            }
        }


        // Event handlers below this point----------------------------------------------

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ListExampleMethod(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

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
            
            ListExampleMethod(sender, e);
        }
    }
}

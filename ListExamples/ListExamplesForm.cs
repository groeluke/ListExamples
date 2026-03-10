

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
            names.Add("Sally");
            names.Add("Jasmine");
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
    }
}

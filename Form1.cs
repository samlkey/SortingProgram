using System.Data;
namespace CodeExercise
{
    public partial class Form1 : Form
    {
        private DataCollection data = new DataCollection();

        public Form1()
        {
            InitializeComponent();
            IDBox.MaxLength = 20;
            this.Text = "Code Exercise";
        }

        //WinForms Form1 onload
        //Sets default values for filters, calls UpdateTable() to initialize the DataGridView
        private void Form1_Load(object sender, EventArgs e)
        {
            MinTrack.Minimum = 0;
            MinTrack.Maximum = 1200;
            MinTrack.TickFrequency = 200;
            MaxTrack.Minimum = 0;
            MaxTrack.Maximum = 1200;
            MaxTrack.TickFrequency = 200;
            MaxTrack.Value = 1200;
            MinLabel.Text = MinTrack.Value.ToString();
            MaxLabel.Text = MaxTrack.Value.ToString();
            UpdateTable(data.GetData());
            string[] comboInfo = { "None", "Approved", "Declined" };
            foreach (string str in comboInfo)
            {
                StatusCombo.Items.Add(str);
            }
            StatusCombo.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //UpdateTable():
        //Updates the GridDataView present in WinForms app, using a DataTable object.
        //Param: update = List<Person> to be displayed in table 
        private void UpdateTable(List<Person> update)
        {
            dataView.DataSource = null;
            DataTable source = new DataTable();
            source.Columns.Add("ID", typeof(int));
            source.Columns.Add("First Name");
            source.Columns.Add("Last Name");
            source.Columns.Add("Status");
            source.Columns.Add("Credit Score", typeof(int));
            foreach (Person person in update)
            {
                source.Rows.Add(person.GetAppID().ToString(), person.GetFirstName(), person.GetLastName(), person.GetStatus() == true ? "Approved" : "Declined", person.GetCreditScore());

            }
            CountLabel.Text = "Total: " + update.Count.ToString();
            dataView.DataSource = source;
        }

        //Filter():
        //Creates a DataCollection with data matching the filter values, updates DataGridView through UpdateTable() when finished. 
        private void Filter()
        {
            DataCollection selection = new DataCollection();
            IEnumerable<TextBox> coll = groupBox.Controls.OfType<TextBox>();
            foreach (TextBox tb in coll)
            {
                if (!tb.Text.Equals(""))
                {
                    switch (tb.Name)
                    {
                        case "IDBox": selection.SetData(selection.QueryID(tb.Text)); break;
                        case "FirstNameBox": selection.SetData(selection.QueryFirstName(tb.Text)); break;
                        case "LastNameBox": selection.SetData(selection.QueryLastName(tb.Text)); break;
                    }
                }
            }
            if (!StatusCombo.Text.Equals("None")) selection.SetData(selection.QueryStatus(StatusCombo.Text == "Approved"));
            selection.SetData(selection.QueryMinCredit(MinTrack.Value));
            selection.SetData(selection.QueryMaxCredit(MaxTrack.Value));
            UpdateTable(selection.GetData());
        }

        //WINFORM EVENT FUNCTIONS
        private void ResetButton_Click(object sender, EventArgs e)
        {
            IEnumerable<TextBox> coll = groupBox.Controls.OfType<TextBox>();
            foreach (TextBox tb in coll)
            {
                tb.Text = ""; 
            }
            StatusCombo.SelectedIndex = 0;
            MinTrack.Value = 0;
            MaxTrack.Value = 1200;
            MinLabel.Text = "0";
            MaxLabel.Text = "1200";
            UpdateTable(data.GetData());
        }

        //User validation, ensuring only numerical values are accepted
        private void IDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("ID can only contain numerical characters");
                e.Handled = true;
            };

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        //User validation, regular expressions used to ensure only alphabetical values are accepted
        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(FirstNameBox.Text, "^[a-zA-Z_ ]*$"))
            {
                MessageBox.Show("First Name can only contain alphabetical characters");
                FirstNameBox.Text = FirstNameBox.Text.Remove(FirstNameBox.TextLength - 1);
            }
            else Filter();
        }

        //User validation, regular expressions used to ensure only alphabetical values are accepted
        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(LastNameBox.Text, "^[a-zA-Z_ ]*$"))
            {
                MessageBox.Show("Last Name can only contain alphabetical characters");
                LastNameBox.Text = LastNameBox.Text.Remove(LastNameBox.Text.Length - 1);
            }else Filter();
        }

        private void StatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void MinTrack_Scroll(object sender, EventArgs e)
        {
            MinLabel.Text = MinTrack.Value.ToString();
            Filter();
        }

        private void MaxTrack_Scroll(object sender, EventArgs e)
        {
            MaxLabel.Text = MaxTrack.Value.ToString();
            Filter();
        }
    }
}
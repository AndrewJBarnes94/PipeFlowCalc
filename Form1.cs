namespace PipeFlowCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selection = scheduleComboBox.Text;

            if (selection == "40" || selection == "80")
            {
                nominalSizeComboBox.Items.Clear();
                nominalSizeComboBox.Text = "";
                nominalSizeComboBox.Items.AddRange(new object[]
                {
                    "1/8\" DN8",
                    "1/4\" DN12",
                    "3/8\" DN10",
                    "1/2\" DN15",
                    "3/4\" DN20",
                    "1\" DN25",
                    "1 1/4\" DN32",
                    "1 1/2\" DN40",
                    "2\" DN50",
                    "2 1/2\" DN65",
                    "3\" DN80",
                    "3 1/2\"",
                    "4\" DN100",
                    "5\" DN125",
                    "6\" DN150",
                    "8\" DN200",
                    "10\" DN250",
                    "12\" DN300",
                    "14\" DN350",
                    "16\" DN400",
                    "18\" DN450",
                    "20\" DN500",
                    "24\" DN600",
                });
            } else if (selection == "120")
            {
                nominalSizeComboBox.Items.Clear();
                nominalSizeComboBox.Text = "";
                nominalSizeComboBox.Items.AddRange(new object[]
                {
                    "1/2\" DN15",
                    "3/4\" DN20",
                    "1\" DN25",
                    "1 1/4\" DN32",
                    "1 1/2\" DN40",
                    "2\" DN50",
                    "2 1/2\" DN65",
                    "3\" DN80",
                    "3 1/2\"",
                    "4\" DN100",
                    "5\" DN125",
                    "6\" DN150",
                    "8\" DN200",
                    "10\" DN250",
                    "12\" DN300",
                });
            }

        }
    }
}

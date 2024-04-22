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
            }
            else if (selection == "120")
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

        private double calculateInnerDiameterInches(double outerDiameter, double wallThickness)
        {
            return outerDiameter - (2 * wallThickness);
        }

        private double calculateFlowRateGPM(double velocity, double innerDiameter)
        {
            // Convert innerDiameter from inches to feet
            innerDiameter = innerDiameter / 12;

            // Calculate the cross sectional area
            double crossSectionalArea = Math.PI * innerDiameter * innerDiameter / 4;

            // Flow rate in ft^3/s
            double flowRate = velocity * crossSectionalArea;

            // Convert the flow rate from f^3/s to GPM and return
            return flowRate * 7.48052 * 60;
        }

        private void calculateMaxFlowRateButton_Click(object sender, EventArgs e)
        {
            string scheduleComboBoxText = scheduleComboBox.Text;
            string nominalSizeComboBoxText = nominalSizeComboBox.Text;
            double innerDiameterInches;
            double velocity;
            double flowRate;

            if (scheduleComboBoxText == "40") {
                switch (nominalSizeComboBoxText)
                {
                    case "1/8\" DN8":
                        innerDiameterInches = calculateInnerDiameterInches(0.41, 0.095);
                        velocity = double.Parse(velocityTextBox.Text);
                        flowRate = calculateFlowRateGPM(velocity, innerDiameterInches);
                        gpmFlowRateTextBox.Text = flowRate.ToString();
                        break;

                    case "1/4\" DN12":
                        innerDiameterInches = calculateInnerDiameterInches(0.54, 0.088);
                        velocity = double.Parse(velocityTextBox.Text);
                        flowRate = calculateFlowRateGPM(velocity, innerDiameterInches);
                        gpmFlowRateTextBox.Text = flowRate.ToString();
                        break;

// Need to fill in from here
                    case "":
                        break;
// To here. Then finish after 1/2 til the end.

                    case "1/2\" DN15":
                        innerDiameterInches = calculateInnerDiameterInches(0.84, 0.109);
                        velocity = double.Parse(velocityTextBox.Text);
                        flowRate = calculateFlowRateGPM(velocity, innerDiameterInches);
                        gpmFlowRateTextBox.Text = flowRate.ToString();
                        break;

                    default:
                        break;
                }

            } else if (scheduleComboBoxText == "80") {

            } else if (scheduleComboBoxText == "120") {

            } else {
            }
        }
    }
}

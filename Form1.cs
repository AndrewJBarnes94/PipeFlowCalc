namespace PipeFlowCalc
{
    public partial class pipeFlowCalcForm : Form
    {
        public pipeFlowCalcForm()
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

        private void gpmFlowRate(double outerDiameter, double wallThickness, double velocity)
        {
            // Calculate innder diameter in inches
            double innerDiameter = outerDiameter - (2 * wallThickness);
            
            // Convert innerDiameter from inches to feet
            innerDiameter = innerDiameter / 12;

            // Calculate the cross sectional area
            double crossSectionalArea = Math.PI * innerDiameter * innerDiameter / 4;

            // Flow rate in ft^3/s
            double flowRate = velocity * crossSectionalArea;

            // Convert the flow rate from f^3/s to GPM 
            flowRate = flowRate * 7.48052 * 60;
            
            // Update gpmFlowRateTextBox
            gpmFlowRateTextBox.Text = flowRate.ToString();
        }

        private void calculateMaxFlowRateButton_Click(object sender, EventArgs e)
        {
            string scheduleComboBoxText = scheduleComboBox.Text;
            string nominalSizeComboBoxText = nominalSizeComboBox.Text;
            double velocity = double.Parse(velocityTextBox.Text);

            if (scheduleComboBoxText == "40")
            {
                switch (nominalSizeComboBoxText)
                {
                    case "1/8\" DN8":
                        gpmFlowRate(0.41, 0.068, velocity);
                        break;

                    case "1/4\" DN12":
                        gpmFlowRate(0.54, 0.088, velocity);
                        break;

                    case "3/8\" DN10":
                        gpmFlowRate(0.068, 0.091, velocity);
                        break;

                    case "1/2\" DN15":
                        gpmFlowRate(0.84, 0.109, velocity);
                        break;

                    case "3/4\" DN20":
                        gpmFlowRate(1.05, 0.113, velocity);
                        break;

                    case "1\" DN25":
                        gpmFlowRate(1.315, 0.133, velocity);
                        break;

                    case "1 1/4\" DN32":
                        gpmFlowRate(1.66, 0.14, velocity);
                        break;

                    case "1 1/2\" DN40":
                        gpmFlowRate(1.9, 0.145, velocity);
                        break;

                    case "2\" DN50":
                        gpmFlowRate(2.375, 0.154, velocity);
                        break;

                    case "2 1/2\" DN65":
                        gpmFlowRate(2.875, 0.203, velocity);
                        break;

                    case "3\" DN80":
                        gpmFlowRate(3.5, 0.216, velocity);
                        break;

                    case "3 1/2\"":
                        gpmFlowRate(4.0, 0.226, velocity);
                        break;

                    case "4\" DN100":
                        gpmFlowRate(4.5, 0.237, velocity);
                        break;

                    case "5\" DN125":
                        gpmFlowRate(5.563, 0.258, velocity);
                        break;

                    case "6\" DN150":
                        gpmFlowRate(6.625, 0.28, velocity);
                        break;

                    case "8\" DN200":
                        gpmFlowRate(8.625, 0.322, velocity);
                        break;

                    case "10\" DN250":
                        gpmFlowRate(10.75, 0.365, velocity);
                        break;

                    case "12\" DN300":
                        gpmFlowRate(12.75, 406, velocity);
                        break;

                    case "14\" DN350":
                        gpmFlowRate(14.0, 0.437, velocity);
                        break;

                    case "16\" DN400":
                        gpmFlowRate(16.0, 0.5, velocity);
                        break;

                    case "18\" DN450":
                        gpmFlowRate(18.0, 0.562, velocity);
                        break;

                    case "20\" DN500":
                        gpmFlowRate(20.0, 0.593, velocity);
                        break;

                    case "24\" DN600":
                        gpmFlowRate(24.0, 0.687, velocity);
                        break;

                    default:
                        break;
                }
            }
            else if (scheduleComboBoxText == "80")
            {
                switch (nominalSizeComboBoxText)
                {
                    case "1/8\" DN8":
                        gpmFlowRate(0.41, 0.095, velocity);
                        break;

                    case "1/4\" DN12":
                        gpmFlowRate(0.54, 0.119, velocity);
                        break;

                    case "3/8\" DN10":
                        gpmFlowRate(0.068, 0.126, velocity);
                        break;

                    case "1/2\" DN15":
                        gpmFlowRate(0.84, 0.147, velocity);
                        break;

                    case "3/4\" DN20":
                        gpmFlowRate(1.05, 0.154, velocity);
                        break;

                    case "1\" DN25":
                        gpmFlowRate(1.32, 0.179, velocity);
                        break;

                    case "1 1/4\" DN32":
                        gpmFlowRate(1.66, 0.191, velocity);
                        break;

                    case "1 1/2\" DN40":
                        gpmFlowRate(1.9, 0.2, velocity);
                        break;

                    case "2\" DN50":
                        gpmFlowRate(2.375, 0.218, velocity);
                        break;

                    case "2 1/2\" DN65":
                        gpmFlowRate(2.875, 0.276, velocity);
                        break;

                    case "3\" DN80":
                        gpmFlowRate(3.5, 0.3, velocity);
                        break;

                    case "3 1/2\"":
                        gpmFlowRate(4.0, 0.318, velocity);
                        break;

                    case "4\" DN100":
                        gpmFlowRate(4.5, 0.337, velocity);
                        break;

                    case "5\" DN125":
                        gpmFlowRate(5.563, 0.375, velocity);
                        break;

                    case "6\" DN150":
                        gpmFlowRate(6.625, 0.432, velocity);
                        break;

                    case "8\" DN200":
                        gpmFlowRate(8.625, 0.5, velocity);
                        break;

                    case "10\" DN250":
                        gpmFlowRate(10.75, 0.593, velocity);
                        break;

                    case "12\" DN300":
                        gpmFlowRate(12.75, 0.687, velocity);
                        break;

                    case "14\" DN350":
                        gpmFlowRate(14.0, 0.75, velocity);
                        break;

                    case "16\" DN400":
                        gpmFlowRate(16.0, 0.843, velocity);
                        break;

                    case "18\" DN450":
                        gpmFlowRate(18.0, 0.937, velocity);
                        break;

                    case "20\" DN500":
                        gpmFlowRate(20.0, 1.031, velocity);
                        break;

                    case "24\" DN600":
                        gpmFlowRate(24.0, 0.218, velocity);
                        break;

                    default:
                        break;

                }
            }
            else if (scheduleComboBoxText == "120")
            {
                switch (nominalSizeComboBoxText)
                {
                    case "1/2\" DN15":
                        gpmFlowRate(0.84, 0.17, velocity);
                        break;

                    case "3/4\" DN20":
                        gpmFlowRate(1.05, 0.17, velocity);
                        break;

                    case "1\" DN25":
                        gpmFlowRate(1.32, 0.2, velocity);
                        break;

                    case "1 1/4\" DN32":
                        gpmFlowRate(1.66, 0.215, velocity);
                        break;

                    case "1 1/2\" DN40":
                        gpmFlowRate(1.9, 0.225, velocity);
                        break;

                    case "2\" DN50":
                        gpmFlowRate(2.375, 0.25, velocity);
                        break;

                    case "2 1/2\" DN65":
                        gpmFlowRate(2.875, 0.3, velocity);
                        break;

                    case "3\" DN80":
                        gpmFlowRate(3.5, 0.35, velocity);
                        break;

                    case "3 1/2\"":
                        gpmFlowRate(4.0, 0.35, velocity);
                        break;

                    case "4\" DN100":
                        gpmFlowRate(4.5, 0.437, velocity);
                        break;

                    case "5\" DN125":
                        gpmFlowRate(5.563, 0.5, velocity);
                        break;

                    case "6\" DN150":
                        gpmFlowRate(6.625, 0.562, velocity);
                        break;

                    case "8\" DN200":
                        gpmFlowRate(8.625, 0.718, velocity);
                        break;

                    case "10\" DN250":
                        gpmFlowRate(10.75, 0.843, velocity);
                        break;

                    case "12\" DN300":
                        gpmFlowRate(12.75, 1.0, velocity);
                        break;

                }
            }
            else
            {
            }
        }
    }
}

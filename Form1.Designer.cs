
namespace PipeFlowCalc
{
    partial class pipeFlowCalcForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            velocityTextBox = new TextBox();
            scheduleLabel = new Label();
            nominalSizeLabel = new Label();
            velocityLabel = new Label();
            scheduleComboBox = new ComboBox();
            nominalSizeComboBox = new ComboBox();
            calculateMaxFlowRateButton = new Button();
            gpmFlowRateLabel = new Label();
            gpmFlowRateTextBox = new TextBox();
            SuspendLayout();
            // 
            // velocityTextBox
            // 
            velocityTextBox.Location = new Point(917, 312);
            velocityTextBox.Name = "velocityTextBox";
            velocityTextBox.Size = new Size(250, 47);
            velocityTextBox.TabIndex = 3;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Location = new Point(80, 268);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(139, 41);
            scheduleLabel.TabIndex = 0;
            scheduleLabel.Text = "Schedule";
            // 
            // nominalSizeLabel
            // 
            nominalSizeLabel.AutoSize = true;
            nominalSizeLabel.Location = new Point(496, 268);
            nominalSizeLabel.Name = "nominalSizeLabel";
            nominalSizeLabel.Size = new Size(191, 41);
            nominalSizeLabel.TabIndex = 0;
            nominalSizeLabel.Text = "Nominal Size";
            // 
            // velocityLabel
            // 
            velocityLabel.AutoSize = true;
            velocityLabel.Location = new Point(917, 268);
            velocityLabel.Name = "velocityLabel";
            velocityLabel.Size = new Size(192, 41);
            velocityLabel.TabIndex = 1;
            velocityLabel.Text = "Velocity (ft/s)";
            // 
            // scheduleComboBox
            // 
            scheduleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            scheduleComboBox.FormattingEnabled = true;
            scheduleComboBox.Items.AddRange(new object[] { "40", "80", "120" });
            scheduleComboBox.Location = new Point(80, 312);
            scheduleComboBox.Name = "scheduleComboBox";
            scheduleComboBox.Size = new Size(302, 49);
            scheduleComboBox.TabIndex = 2;
            scheduleComboBox.SelectedIndexChanged += scheduleComboBox_SelectedIndexChanged;
            // 
            // nominalSizeComboBox
            // 
            nominalSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nominalSizeComboBox.FormattingEnabled = true;
            nominalSizeComboBox.Location = new Point(496, 310);
            nominalSizeComboBox.Name = "nominalSizeComboBox";
            nominalSizeComboBox.Size = new Size(302, 49);
            nominalSizeComboBox.TabIndex = 4;
            // 
            // calculateMaxFlowRateButton
            // 
            calculateMaxFlowRateButton.Location = new Point(82, 452);
            calculateMaxFlowRateButton.Name = "calculateMaxFlowRateButton";
            calculateMaxFlowRateButton.Size = new Size(1087, 58);
            calculateMaxFlowRateButton.TabIndex = 5;
            calculateMaxFlowRateButton.Text = "Calculate Max Flow Rate";
            calculateMaxFlowRateButton.UseVisualStyleBackColor = true;
            calculateMaxFlowRateButton.Click += calculateMaxFlowRateButton_Click;
            // 
            // gpmFlowRateLabel
            // 
            gpmFlowRateLabel.AutoSize = true;
            gpmFlowRateLabel.Location = new Point(310, 161);
            gpmFlowRateLabel.Name = "gpmFlowRateLabel";
            gpmFlowRateLabel.Size = new Size(238, 41);
            gpmFlowRateLabel.TabIndex = 10;
            gpmFlowRateLabel.Text = "Flow Rate (GPM)";
            // 
            // gpmFlowRateTextBox
            // 
            gpmFlowRateTextBox.Location = new Point(554, 161);
            gpmFlowRateTextBox.Name = "gpmFlowRateTextBox";
            gpmFlowRateTextBox.ReadOnly = true;
            gpmFlowRateTextBox.Size = new Size(308, 47);
            gpmFlowRateTextBox.TabIndex = 11;
            // 
            // pipeFlowCalcForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 685);
            Controls.Add(gpmFlowRateTextBox);
            Controls.Add(gpmFlowRateLabel);
            Controls.Add(calculateMaxFlowRateButton);
            Controls.Add(nominalSizeComboBox);
            Controls.Add(velocityTextBox);
            Controls.Add(scheduleComboBox);
            Controls.Add(velocityLabel);
            Controls.Add(nominalSizeLabel);
            Controls.Add(scheduleLabel);
            Name = "pipeFlowCalcForm";
            Text = "Pipe Flow Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private void nominalSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label scheduleLabel;
        private Label nominalSizeLabel;
        private Label velocityLabel;
        private ComboBox scheduleComboBox;
        private TextBox velocityTextBox;
        private ComboBox nominalSizeComboBox;
        private Button calculateMaxFlowRateButton;
        private Label gpmFlowRateLabel;
        private TextBox gpmFlowRateTextBox;
    }
}

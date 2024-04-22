
namespace PipeFlowCalc
{
    partial class Form1
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
            outerDiameterLabel = new Label();
            outerDiameterTextBox = new TextBox();
            innerDiameterLabel = new Label();
            innerDiameterTextBox = new TextBox();
            gpmFlowRateLabel = new Label();
            gpmFlowRateTextBox = new TextBox();
            SuspendLayout();
            // 
            // velocityTextBox
            // 
            velocityTextBox.Location = new Point(917, 204);
            velocityTextBox.Name = "velocityTextBox";
            velocityTextBox.Size = new Size(250, 47);
            velocityTextBox.TabIndex = 3;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Location = new Point(80, 160);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(139, 41);
            scheduleLabel.TabIndex = 0;
            scheduleLabel.Text = "Schedule";
            // 
            // nominalSizeLabel
            // 
            nominalSizeLabel.AutoSize = true;
            nominalSizeLabel.Location = new Point(496, 160);
            nominalSizeLabel.Name = "nominalSizeLabel";
            nominalSizeLabel.Size = new Size(191, 41);
            nominalSizeLabel.TabIndex = 0;
            nominalSizeLabel.Text = "Nominal Size";
            // 
            // velocityLabel
            // 
            velocityLabel.AutoSize = true;
            velocityLabel.Location = new Point(917, 160);
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
            scheduleComboBox.Location = new Point(80, 204);
            scheduleComboBox.Name = "scheduleComboBox";
            scheduleComboBox.Size = new Size(302, 49);
            scheduleComboBox.TabIndex = 2;
            scheduleComboBox.SelectedIndexChanged += scheduleComboBox_SelectedIndexChanged;
            // 
            // nominalSizeComboBox
            // 
            nominalSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nominalSizeComboBox.FormattingEnabled = true;
            nominalSizeComboBox.Location = new Point(496, 202);
            nominalSizeComboBox.Name = "nominalSizeComboBox";
            nominalSizeComboBox.Size = new Size(302, 49);
            nominalSizeComboBox.TabIndex = 4;
            // 
            // calculateMaxFlowRateButton
            // 
            calculateMaxFlowRateButton.Location = new Point(80, 302);
            calculateMaxFlowRateButton.Name = "calculateMaxFlowRateButton";
            calculateMaxFlowRateButton.Size = new Size(1087, 58);
            calculateMaxFlowRateButton.TabIndex = 5;
            calculateMaxFlowRateButton.Text = "Calculate Max Flow Rate";
            calculateMaxFlowRateButton.UseVisualStyleBackColor = true;
            calculateMaxFlowRateButton.Click += calculateMaxFlowRateButton_Click;
            // 
            // outerDiameterLabel
            // 
            outerDiameterLabel.AutoSize = true;
            outerDiameterLabel.Location = new Point(77, 496);
            outerDiameterLabel.Name = "outerDiameterLabel";
            outerDiameterLabel.Size = new Size(223, 41);
            outerDiameterLabel.TabIndex = 6;
            outerDiameterLabel.Text = "Outer Diameter";
            // 
            // outerDiameterTextBox
            // 
            outerDiameterTextBox.Location = new Point(321, 496);
            outerDiameterTextBox.Name = "outerDiameterTextBox";
            outerDiameterTextBox.ReadOnly = true;
            outerDiameterTextBox.Size = new Size(308, 47);
            outerDiameterTextBox.TabIndex = 7;
            // 
            // innerDiameterLabel
            // 
            innerDiameterLabel.AutoSize = true;
            innerDiameterLabel.Location = new Point(77, 549);
            innerDiameterLabel.Name = "innerDiameterLabel";
            innerDiameterLabel.Size = new Size(215, 41);
            innerDiameterLabel.TabIndex = 8;
            innerDiameterLabel.Text = "Inner Diameter";
            // 
            // innerDiameterTextBox
            // 
            innerDiameterTextBox.Location = new Point(321, 549);
            innerDiameterTextBox.Name = "innerDiameterTextBox";
            innerDiameterTextBox.ReadOnly = true;
            innerDiameterTextBox.Size = new Size(308, 47);
            innerDiameterTextBox.TabIndex = 9;
            // 
            // gpmFlowRateLabel
            // 
            gpmFlowRateLabel.AutoSize = true;
            gpmFlowRateLabel.Location = new Point(77, 602);
            gpmFlowRateLabel.Name = "gpmFlowRateLabel";
            gpmFlowRateLabel.Size = new Size(238, 41);
            gpmFlowRateLabel.TabIndex = 10;
            gpmFlowRateLabel.Text = "Flow Rate (GPM)";
            // 
            // gpmFlowRateTextBox
            // 
            gpmFlowRateTextBox.Location = new Point(321, 602);
            gpmFlowRateTextBox.Name = "gpmFlowRateTextBox";
            gpmFlowRateTextBox.ReadOnly = true;
            gpmFlowRateTextBox.Size = new Size(308, 47);
            gpmFlowRateTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 739);
            Controls.Add(gpmFlowRateTextBox);
            Controls.Add(gpmFlowRateLabel);
            Controls.Add(innerDiameterTextBox);
            Controls.Add(innerDiameterLabel);
            Controls.Add(outerDiameterTextBox);
            Controls.Add(outerDiameterLabel);
            Controls.Add(calculateMaxFlowRateButton);
            Controls.Add(nominalSizeComboBox);
            Controls.Add(velocityTextBox);
            Controls.Add(scheduleComboBox);
            Controls.Add(velocityLabel);
            Controls.Add(nominalSizeLabel);
            Controls.Add(scheduleLabel);
            Name = "Form1";
            Text = "Form1";
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
        private Label outerDiameterLabel;
        private TextBox outerDiameterTextBox;
        private Label innerDiameterLabel;
        private TextBox innerDiameterTextBox;
        private Label gpmFlowRateLabel;
        private TextBox gpmFlowRateTextBox;
    }
}

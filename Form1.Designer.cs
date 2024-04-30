
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pipeFlowCalcForm));
            velocityTextBox = new TextBox();
            scheduleLabel = new Label();
            nominalSizeLabel = new Label();
            velocityLabel = new Label();
            scheduleComboBox = new ComboBox();
            nominalSizeComboBox = new ComboBox();
            calculateMaxFlowRateButton = new Button();
            gpmFlowRateLabel = new Label();
            gpmFlowRateTextBox = new TextBox();
            pvcCheckBox = new CheckBox();
            stainlessSteelCheckBox = new CheckBox();
            menuStrip1 = new MenuStrip();
            splitter1 = new Splitter();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // velocityTextBox
            // 
            velocityTextBox.Location = new Point(924, 450);
            velocityTextBox.Name = "velocityTextBox";
            velocityTextBox.Size = new Size(250, 47);
            velocityTextBox.TabIndex = 3;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Location = new Point(87, 406);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(139, 41);
            scheduleLabel.TabIndex = 0;
            scheduleLabel.Text = "Schedule";
            // 
            // nominalSizeLabel
            // 
            nominalSizeLabel.AutoSize = true;
            nominalSizeLabel.Location = new Point(503, 406);
            nominalSizeLabel.Name = "nominalSizeLabel";
            nominalSizeLabel.Size = new Size(191, 41);
            nominalSizeLabel.TabIndex = 0;
            nominalSizeLabel.Text = "Nominal Size";
            // 
            // velocityLabel
            // 
            velocityLabel.AutoSize = true;
            velocityLabel.Location = new Point(924, 406);
            velocityLabel.Name = "velocityLabel";
            velocityLabel.Size = new Size(192, 41);
            velocityLabel.TabIndex = 1;
            velocityLabel.Text = "Velocity (ft/s)";
            // 
            // scheduleComboBox
            // 
            scheduleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            scheduleComboBox.FormattingEnabled = true;
            scheduleComboBox.Location = new Point(87, 450);
            scheduleComboBox.Name = "scheduleComboBox";
            scheduleComboBox.Size = new Size(302, 49);
            scheduleComboBox.TabIndex = 2;
            scheduleComboBox.SelectedIndexChanged += scheduleComboBox_SelectedIndexChanged;
            // 
            // nominalSizeComboBox
            // 
            nominalSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nominalSizeComboBox.FormattingEnabled = true;
            nominalSizeComboBox.Location = new Point(503, 448);
            nominalSizeComboBox.Name = "nominalSizeComboBox";
            nominalSizeComboBox.Size = new Size(302, 49);
            nominalSizeComboBox.TabIndex = 4;
            // 
            // calculateMaxFlowRateButton
            // 
            calculateMaxFlowRateButton.Location = new Point(89, 590);
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
            gpmFlowRateLabel.Location = new Point(314, 86);
            gpmFlowRateLabel.Name = "gpmFlowRateLabel";
            gpmFlowRateLabel.Size = new Size(238, 41);
            gpmFlowRateLabel.TabIndex = 10;
            gpmFlowRateLabel.Text = "Flow Rate (GPM)";
            // 
            // gpmFlowRateTextBox
            // 
            gpmFlowRateTextBox.Location = new Point(558, 86);
            gpmFlowRateTextBox.Name = "gpmFlowRateTextBox";
            gpmFlowRateTextBox.ReadOnly = true;
            gpmFlowRateTextBox.Size = new Size(308, 47);
            gpmFlowRateTextBox.TabIndex = 11;
            // 
            // pvcCheckBox
            // 
            pvcCheckBox.AutoSize = true;
            pvcCheckBox.Location = new Point(10, 56);
            pvcCheckBox.Name = "pvcCheckBox";
            pvcCheckBox.Size = new Size(110, 45);
            pvcCheckBox.TabIndex = 12;
            pvcCheckBox.Text = "PVC";
            pvcCheckBox.UseVisualStyleBackColor = true;
            pvcCheckBox.CheckedChanged += pvcCheckBox_CheckedChanged;
            // 
            // stainlessSteelCheckBox
            // 
            stainlessSteelCheckBox.AutoSize = true;
            stainlessSteelCheckBox.Location = new Point(424, 56);
            stainlessSteelCheckBox.Name = "stainlessSteelCheckBox";
            stainlessSteelCheckBox.Size = new Size(241, 45);
            stainlessSteelCheckBox.TabIndex = 13;
            stainlessSteelCheckBox.Text = "Stainless Steel";
            stainlessSteelCheckBox.UseVisualStyleBackColor = true;
            stainlessSteelCheckBox.CheckedChanged += stainlessSteelCheckBox_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 24);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(8, 742);
            splitter1.TabIndex = 15;
            splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stainlessSteelCheckBox);
            groupBox1.Controls.Add(pvcCheckBox);
            groupBox1.Location = new Point(79, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1097, 124);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pipe Material";
            // 
            // pipeFlowCalcForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 766);
            Controls.Add(groupBox1);
            Controls.Add(splitter1);
            Controls.Add(gpmFlowRateTextBox);
            Controls.Add(gpmFlowRateLabel);
            Controls.Add(calculateMaxFlowRateButton);
            Controls.Add(nominalSizeComboBox);
            Controls.Add(velocityTextBox);
            Controls.Add(scheduleComboBox);
            Controls.Add(velocityLabel);
            Controls.Add(nominalSizeLabel);
            Controls.Add(scheduleLabel);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "pipeFlowCalcForm";
            Text = "Pipe Flow Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private CheckBox pvcCheckBox;
        private CheckBox stainlessSteelCheckBox;
        private MenuStrip menuStrip1;
        private Splitter splitter1;
        private GroupBox groupBox1;
    }
}

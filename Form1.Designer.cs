
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
            scheduleLabel = new Label();
            nominalSizeLabel = new Label();
            velocityLabel = new Label();
            scheduleComboBox = new ComboBox();
            velocityTextBox = new TextBox();
            nominalSizeComboBox = new ComboBox();
            SuspendLayout();
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
            scheduleComboBox.FormattingEnabled = true;
            scheduleComboBox.Items.AddRange(new object[] { "40", "80", "120" });
            scheduleComboBox.Location = new Point(80, 204);
            scheduleComboBox.Name = "scheduleComboBox";
            scheduleComboBox.Size = new Size(302, 49);
            scheduleComboBox.TabIndex = 2;
            scheduleComboBox.SelectedIndexChanged += scheduleComboBox_SelectedIndexChanged;
            // 
            // velocityTextBox
            // 
            velocityTextBox.Location = new Point(917, 204);
            velocityTextBox.Name = "velocityTextBox";
            velocityTextBox.Size = new Size(250, 47);
            velocityTextBox.TabIndex = 3;
            // 
            // nominalSizeComboBox
            // 
            nominalSizeComboBox.FormattingEnabled = true;
            nominalSizeComboBox.Location = new Point(496, 202);
            nominalSizeComboBox.Name = "nominalSizeComboBox";
            nominalSizeComboBox.Size = new Size(302, 49);
            nominalSizeComboBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 723);
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
    }
}

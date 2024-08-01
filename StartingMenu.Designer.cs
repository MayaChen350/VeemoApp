namespace VeemoApp
{
    partial class VeemoApp
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
            components = new System.ComponentModel.Container();
            labelFrequency = new Label();
            startButton = new Button();
            appTitle = new Label();
            frequencyOption = new NumericUpDown();
            labelPercentUnit = new Label();
            labelEveryMinute = new Label();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)frequencyOption).BeginInit();
            SuspendLayout();
            // 
            // labelFrequency
            // 
            labelFrequency.AutoSize = true;
            labelFrequency.ForeColor = Color.White;
            labelFrequency.Location = new Point(22, 322);
            labelFrequency.Name = "labelFrequency";
            labelFrequency.Size = new Size(65, 15);
            labelFrequency.TabIndex = 0;
            labelFrequency.Text = "Frequency:";
            // 
            // startButton
            // 
            startButton.BackColor = Color.Indigo;
            startButton.ForeColor = SystemColors.ControlLightLight;
            startButton.Location = new Point(12, 396);
            startButton.Name = "startButton";
            startButton.Size = new Size(234, 42);
            startButton.TabIndex = 1;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // appTitle
            // 
            appTitle.Anchor = AnchorStyles.Top;
            appTitle.AutoSize = true;
            appTitle.Font = new Font("MV Boli", 25F);
            appTitle.ForeColor = Color.Orange;
            appTitle.Location = new Point(27, 52);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(201, 45);
            appTitle.TabIndex = 2;
            appTitle.Text = "Veemo App";
            appTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frequencyOption
            // 
            frequencyOption.BackColor = Color.Black;
            frequencyOption.DecimalPlaces = 2;
            frequencyOption.ForeColor = Color.White;
            frequencyOption.Location = new Point(93, 320);
            frequencyOption.Name = "frequencyOption";
            frequencyOption.Size = new Size(79, 23);
            frequencyOption.TabIndex = 4;
            frequencyOption.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelPercentUnit
            // 
            labelPercentUnit.AutoSize = true;
            labelPercentUnit.BackColor = Color.Black;
            labelPercentUnit.ForeColor = Color.WhiteSmoke;
            labelPercentUnit.Location = new Point(129, 323);
            labelPercentUnit.Name = "labelPercentUnit";
            labelPercentUnit.Size = new Size(17, 15);
            labelPercentUnit.TabIndex = 5;
            labelPercentUnit.Text = "%";
            // 
            // labelEveryMinute
            // 
            labelEveryMinute.AutoSize = true;
            labelEveryMinute.ForeColor = Color.White;
            labelEveryMinute.Location = new Point(174, 323);
            labelEveryMinute.Name = "labelEveryMinute";
            labelEveryMinute.Size = new Size(76, 15);
            labelEveryMinute.TabIndex = 6;
            labelEveryMinute.Text = "Every minute";
            // 
            // timer
            // 
            timer.Interval = 60000;
            timer.Tick += timer_Tick;
            // 
            // VeemoApp
            // 
            AcceptButton = startButton;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(258, 450);
            Controls.Add(labelEveryMinute);
            Controls.Add(labelPercentUnit);
            Controls.Add(frequencyOption);
            Controls.Add(appTitle);
            Controls.Add(startButton);
            Controls.Add(labelFrequency);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(274, 489);
            MinimumSize = new Size(274, 489);
            Name = "VeemoApp";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veemo!";
            ((System.ComponentModel.ISupportInitialize)frequencyOption).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFrequency;
        private Button startButton;
        private Label appTitle;
        private NumericUpDown frequencyOption;
        private Label labelPercentUnit;
        private Label labelEveryMinute;
        private System.Windows.Forms.Timer timer;
    }
}

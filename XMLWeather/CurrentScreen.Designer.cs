namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentWeather = new System.Windows.Forms.Label();
            this.currentWeatherBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.feelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(150, 114);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(194, 44);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.Location = new System.Drawing.Point(259, 660);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(227, 64);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "MAXLABEL";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(29, 648);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(104, 51);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.Location = new System.Drawing.Point(259, 569);
            this.minOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(227, 57);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "MIN LABEL";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(29, 557);
            this.minLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(92, 51);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(261, 261);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(44, 25);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tempLabel.Location = new System.Drawing.Point(179, 178);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(151, 108);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "17";
            this.tempLabel.Click += new System.EventHandler(this.tempLabel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 54);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(283, 28);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(165, 54);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "3 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 51);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentWeather
            // 
            this.currentWeather.AutoSize = true;
            this.currentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeather.ForeColor = System.Drawing.Color.White;
            this.currentWeather.Location = new System.Drawing.Point(29, 426);
            this.currentWeather.Name = "currentWeather";
            this.currentWeather.Size = new System.Drawing.Size(238, 51);
            this.currentWeather.TabIndex = 43;
            this.currentWeather.Text = "WEATHER";
            // 
            // currentWeatherBox
            // 
            this.currentWeatherBox.BackgroundImage = global::XMLWeather.Properties.Resources.thunderstorm;
            this.currentWeatherBox.Location = new System.Drawing.Point(292, 402);
            this.currentWeatherBox.Name = "currentWeatherBox";
            this.currentWeatherBox.Size = new System.Drawing.Size(108, 93);
            this.currentWeatherBox.TabIndex = 44;
            this.currentWeatherBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 55);
            this.label1.TabIndex = 45;
            this.label1.Text = "Feels Like";
            // 
            // feelLabel
            // 
            this.feelLabel.AutoSize = true;
            this.feelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelLabel.Location = new System.Drawing.Point(282, 317);
            this.feelLabel.Name = "feelLabel";
            this.feelLabel.Size = new System.Drawing.Size(152, 55);
            this.feelLabel.TabIndex = 46;
            this.feelLabel.Text = "label2";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.feelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentWeatherBox);
            this.Controls.Add(this.currentWeather);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(500, 769);
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentWeather;
        private System.Windows.Forms.PictureBox currentWeatherBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feelLabel;
    }
}

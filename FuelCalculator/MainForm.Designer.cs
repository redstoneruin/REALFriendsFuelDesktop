namespace FuelCalculator
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.raceTimeLabel = new System.Windows.Forms.Label();
            this.lapTimeLabel = new System.Windows.Forms.Label();
            this.lapTimeInput = new System.Windows.Forms.TextBox();
            this.maxFuelLabel = new System.Windows.Forms.Label();
            this.usageLabel = new System.Windows.Forms.Label();
            this.raceTimeInput = new System.Windows.Forms.NumericUpDown();
            this.maxFuelInput = new System.Windows.Forms.NumericUpDown();
            this.usageInput = new System.Windows.Forms.NumericUpDown();
            this.lapRaceCheckbox = new System.Windows.Forms.CheckBox();
            this.paceLapDropdown = new System.Windows.Forms.ComboBox();
            this.extraLapsSlider = new System.Windows.Forms.TrackBar();
            this.extraLapsLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.pitStopsLabel = new System.Windows.Forms.Label();
            this.lastStopFuelLabel = new System.Windows.Forms.Label();
            this.totalFuelLabel = new System.Windows.Forms.Label();
            this.lapsPerTankLabel = new System.Windows.Forms.Label();
            this.totalLapsLabel = new System.Windows.Forms.Label();
            this.pitStopsDisplay = new System.Windows.Forms.Label();
            this.lastStopFuelDisplay = new System.Windows.Forms.Label();
            this.totalFuelDisplay = new System.Windows.Forms.Label();
            this.lapsPerTankDisplay = new System.Windows.Forms.Label();
            this.totalLapsDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raceTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFuelInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraLapsSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTimeLabel
            // 
            this.raceTimeLabel.AutoSize = true;
            this.raceTimeLabel.Location = new System.Drawing.Point(13, 13);
            this.raceTimeLabel.Name = "raceTimeLabel";
            this.raceTimeLabel.Size = new System.Drawing.Size(110, 13);
            this.raceTimeLabel.TabIndex = 1;
            this.raceTimeLabel.Text = "Race Time in Minutes";
            // 
            // lapTimeLabel
            // 
            this.lapTimeLabel.AutoSize = true;
            this.lapTimeLabel.Location = new System.Drawing.Point(13, 56);
            this.lapTimeLabel.Name = "lapTimeLabel";
            this.lapTimeLabel.Size = new System.Drawing.Size(151, 13);
            this.lapTimeLabel.TabIndex = 2;
            this.lapTimeLabel.Text = "Lap Time in Format MM:SS.ms";
            // 
            // lapTimeInput
            // 
            this.lapTimeInput.Location = new System.Drawing.Point(16, 72);
            this.lapTimeInput.Name = "lapTimeInput";
            this.lapTimeInput.Size = new System.Drawing.Size(218, 20);
            this.lapTimeInput.TabIndex = 3;
            this.lapTimeInput.TextChanged += new System.EventHandler(this.lapTimeInput_TextChanged);
            // 
            // maxFuelLabel
            // 
            this.maxFuelLabel.AutoSize = true;
            this.maxFuelLabel.Location = new System.Drawing.Point(13, 101);
            this.maxFuelLabel.Name = "maxFuelLabel";
            this.maxFuelLabel.Size = new System.Drawing.Size(74, 13);
            this.maxFuelLabel.TabIndex = 4;
            this.maxFuelLabel.Text = "Maximum Fuel";
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Location = new System.Drawing.Point(13, 144);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(61, 13);
            this.usageLabel.TabIndex = 6;
            this.usageLabel.Text = "Fuel Usage";
            // 
            // raceTimeInput
            // 
            this.raceTimeInput.Location = new System.Drawing.Point(16, 30);
            this.raceTimeInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.raceTimeInput.Name = "raceTimeInput";
            this.raceTimeInput.Size = new System.Drawing.Size(218, 20);
            this.raceTimeInput.TabIndex = 8;
            this.raceTimeInput.ValueChanged += new System.EventHandler(this.raceTimeInput_ValueChanged);
            // 
            // maxFuelInput
            // 
            this.maxFuelInput.DecimalPlaces = 2;
            this.maxFuelInput.Location = new System.Drawing.Point(16, 118);
            this.maxFuelInput.Name = "maxFuelInput";
            this.maxFuelInput.Size = new System.Drawing.Size(218, 20);
            this.maxFuelInput.TabIndex = 9;
            this.maxFuelInput.ValueChanged += new System.EventHandler(this.maxFuelInput_ValueChanged);
            // 
            // usageInput
            // 
            this.usageInput.DecimalPlaces = 2;
            this.usageInput.Location = new System.Drawing.Point(16, 161);
            this.usageInput.Name = "usageInput";
            this.usageInput.Size = new System.Drawing.Size(218, 20);
            this.usageInput.TabIndex = 10;
            this.usageInput.ValueChanged += new System.EventHandler(this.usageInput_ValueChanged);
            // 
            // lapRaceCheckbox
            // 
            this.lapRaceCheckbox.AutoSize = true;
            this.lapRaceCheckbox.Location = new System.Drawing.Point(16, 305);
            this.lapRaceCheckbox.Name = "lapRaceCheckbox";
            this.lapRaceCheckbox.Size = new System.Drawing.Size(73, 17);
            this.lapRaceCheckbox.TabIndex = 11;
            this.lapRaceCheckbox.Text = "Lap Race";
            this.lapRaceCheckbox.UseVisualStyleBackColor = true;
            this.lapRaceCheckbox.CheckedChanged += new System.EventHandler(this.lapRaceCheckbox_CheckedChanged);
            // 
            // paceLapDropdown
            // 
            this.paceLapDropdown.FormattingEnabled = true;
            this.paceLapDropdown.Items.AddRange(new object[] {
            "No Pace Lap",
            "Half Pace Lap",
            "Full Pace Lap"});
            this.paceLapDropdown.Location = new System.Drawing.Point(16, 204);
            this.paceLapDropdown.Name = "paceLapDropdown";
            this.paceLapDropdown.Size = new System.Drawing.Size(218, 21);
            this.paceLapDropdown.TabIndex = 12;
            this.paceLapDropdown.Text = "No Pace Lap";
            this.paceLapDropdown.SelectedIndexChanged += new System.EventHandler(this.paceLapDropdown_SelectedIndexChanged);
            // 
            // extraLapsSlider
            // 
            this.extraLapsSlider.Location = new System.Drawing.Point(16, 254);
            this.extraLapsSlider.Maximum = 100;
            this.extraLapsSlider.Name = "extraLapsSlider";
            this.extraLapsSlider.Size = new System.Drawing.Size(218, 45);
            this.extraLapsSlider.TabIndex = 13;
            this.extraLapsSlider.TickFrequency = 10;
            this.extraLapsSlider.ValueChanged += new System.EventHandler(this.extraLapsSlider_ValueChanged);
            // 
            // extraLapsLabel
            // 
            this.extraLapsLabel.AutoSize = true;
            this.extraLapsLabel.Location = new System.Drawing.Point(13, 238);
            this.extraLapsLabel.Name = "extraLapsLabel";
            this.extraLapsLabel.Size = new System.Drawing.Size(78, 13);
            this.extraLapsLabel.TabIndex = 14;
            this.extraLapsLabel.Text = "Extra Laps: 0.0";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(16, 346);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 15;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // pitStopsLabel
            // 
            this.pitStopsLabel.AutoSize = true;
            this.pitStopsLabel.Location = new System.Drawing.Point(291, 37);
            this.pitStopsLabel.Name = "pitStopsLabel";
            this.pitStopsLabel.Size = new System.Drawing.Size(49, 13);
            this.pitStopsLabel.TabIndex = 16;
            this.pitStopsLabel.Text = "Pit Stops";
            // 
            // lastStopFuelLabel
            // 
            this.lastStopFuelLabel.AutoSize = true;
            this.lastStopFuelLabel.Location = new System.Drawing.Point(291, 79);
            this.lastStopFuelLabel.Name = "lastStopFuelLabel";
            this.lastStopFuelLabel.Size = new System.Drawing.Size(90, 13);
            this.lastStopFuelLabel.TabIndex = 17;
            this.lastStopFuelLabel.Text = "Fuel on Last Stop";
            // 
            // totalFuelLabel
            // 
            this.totalFuelLabel.AutoSize = true;
            this.totalFuelLabel.Location = new System.Drawing.Point(291, 125);
            this.totalFuelLabel.Name = "totalFuelLabel";
            this.totalFuelLabel.Size = new System.Drawing.Size(88, 13);
            this.totalFuelLabel.TabIndex = 18;
            this.totalFuelLabel.Text = "Total Fuel Usage";
            // 
            // lapsPerTankLabel
            // 
            this.lapsPerTankLabel.AutoSize = true;
            this.lapsPerTankLabel.Location = new System.Drawing.Point(291, 168);
            this.lapsPerTankLabel.Name = "lapsPerTankLabel";
            this.lapsPerTankLabel.Size = new System.Drawing.Size(77, 13);
            this.lapsPerTankLabel.TabIndex = 19;
            this.lapsPerTankLabel.Text = "Laps Per Tank";
            // 
            // totalLapsLabel
            // 
            this.totalLapsLabel.AutoSize = true;
            this.totalLapsLabel.Location = new System.Drawing.Point(291, 212);
            this.totalLapsLabel.Name = "totalLapsLabel";
            this.totalLapsLabel.Size = new System.Drawing.Size(57, 13);
            this.totalLapsLabel.TabIndex = 20;
            this.totalLapsLabel.Text = "Total Laps";
            // 
            // pitStopsDisplay
            // 
            this.pitStopsDisplay.AutoSize = true;
            this.pitStopsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitStopsDisplay.Location = new System.Drawing.Point(409, 28);
            this.pitStopsDisplay.Name = "pitStopsDisplay";
            this.pitStopsDisplay.Size = new System.Drawing.Size(33, 25);
            this.pitStopsDisplay.TabIndex = 21;
            this.pitStopsDisplay.Text = "...";
            // 
            // lastStopFuelDisplay
            // 
            this.lastStopFuelDisplay.AutoSize = true;
            this.lastStopFuelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastStopFuelDisplay.Location = new System.Drawing.Point(409, 70);
            this.lastStopFuelDisplay.Name = "lastStopFuelDisplay";
            this.lastStopFuelDisplay.Size = new System.Drawing.Size(33, 25);
            this.lastStopFuelDisplay.TabIndex = 22;
            this.lastStopFuelDisplay.Text = "...";
            // 
            // totalFuelDisplay
            // 
            this.totalFuelDisplay.AutoSize = true;
            this.totalFuelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFuelDisplay.Location = new System.Drawing.Point(409, 116);
            this.totalFuelDisplay.Name = "totalFuelDisplay";
            this.totalFuelDisplay.Size = new System.Drawing.Size(33, 25);
            this.totalFuelDisplay.TabIndex = 23;
            this.totalFuelDisplay.Text = "...";
            // 
            // lapsPerTankDisplay
            // 
            this.lapsPerTankDisplay.AutoSize = true;
            this.lapsPerTankDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapsPerTankDisplay.Location = new System.Drawing.Point(409, 159);
            this.lapsPerTankDisplay.Name = "lapsPerTankDisplay";
            this.lapsPerTankDisplay.Size = new System.Drawing.Size(33, 25);
            this.lapsPerTankDisplay.TabIndex = 24;
            this.lapsPerTankDisplay.Text = "...";
            // 
            // totalLapsDisplay
            // 
            this.totalLapsDisplay.AutoSize = true;
            this.totalLapsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLapsDisplay.Location = new System.Drawing.Point(409, 203);
            this.totalLapsDisplay.Name = "totalLapsDisplay";
            this.totalLapsDisplay.Size = new System.Drawing.Size(33, 25);
            this.totalLapsDisplay.TabIndex = 25;
            this.totalLapsDisplay.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 392);
            this.Controls.Add(this.totalLapsDisplay);
            this.Controls.Add(this.lapsPerTankDisplay);
            this.Controls.Add(this.totalFuelDisplay);
            this.Controls.Add(this.lastStopFuelDisplay);
            this.Controls.Add(this.pitStopsDisplay);
            this.Controls.Add(this.totalLapsLabel);
            this.Controls.Add(this.lapsPerTankLabel);
            this.Controls.Add(this.totalFuelLabel);
            this.Controls.Add(this.lastStopFuelLabel);
            this.Controls.Add(this.pitStopsLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.extraLapsLabel);
            this.Controls.Add(this.extraLapsSlider);
            this.Controls.Add(this.paceLapDropdown);
            this.Controls.Add(this.lapRaceCheckbox);
            this.Controls.Add(this.usageInput);
            this.Controls.Add(this.maxFuelInput);
            this.Controls.Add(this.raceTimeInput);
            this.Controls.Add(this.usageLabel);
            this.Controls.Add(this.maxFuelLabel);
            this.Controls.Add(this.lapTimeInput);
            this.Controls.Add(this.lapTimeLabel);
            this.Controls.Add(this.raceTimeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "REAL Friends Fuel";
            ((System.ComponentModel.ISupportInitialize)(this.raceTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFuelInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usageInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraLapsSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label raceTimeLabel;
        private System.Windows.Forms.Label lapTimeLabel;
        private System.Windows.Forms.TextBox lapTimeInput;
        private System.Windows.Forms.Label maxFuelLabel;
        private System.Windows.Forms.Label usageLabel;
        private System.Windows.Forms.NumericUpDown raceTimeInput;
        private System.Windows.Forms.NumericUpDown maxFuelInput;
        private System.Windows.Forms.NumericUpDown usageInput;
        private System.Windows.Forms.CheckBox lapRaceCheckbox;
        private System.Windows.Forms.ComboBox paceLapDropdown;
        private System.Windows.Forms.TrackBar extraLapsSlider;
        private System.Windows.Forms.Label extraLapsLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label pitStopsLabel;
        private System.Windows.Forms.Label lastStopFuelLabel;
        private System.Windows.Forms.Label totalFuelLabel;
        private System.Windows.Forms.Label lapsPerTankLabel;
        private System.Windows.Forms.Label totalLapsLabel;
        private System.Windows.Forms.Label pitStopsDisplay;
        private System.Windows.Forms.Label lastStopFuelDisplay;
        private System.Windows.Forms.Label totalFuelDisplay;
        private System.Windows.Forms.Label lapsPerTankDisplay;
        private System.Windows.Forms.Label totalLapsDisplay;
    }
}


namespace WaveFormRendererApp
{
    partial class WaveInformationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.bitsPer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blockAlign = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.channels = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sampleRate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.extraSize = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.encoding = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Bytes Per Second :";
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(207, 52);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(35, 13);
            this.average.TabIndex = 1;
            this.average.Text = "label2";
            // 
            // bitsPer
            // 
            this.bitsPer.AutoSize = true;
            this.bitsPer.Location = new System.Drawing.Point(207, 89);
            this.bitsPer.Name = "bitsPer";
            this.bitsPer.Size = new System.Drawing.Size(35, 13);
            this.bitsPer.TabIndex = 3;
            this.bitsPer.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bits Per Sample :";
            // 
            // blockAlign
            // 
            this.blockAlign.AutoSize = true;
            this.blockAlign.Location = new System.Drawing.Point(207, 130);
            this.blockAlign.Name = "blockAlign";
            this.blockAlign.Size = new System.Drawing.Size(35, 13);
            this.blockAlign.TabIndex = 5;
            this.blockAlign.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Block Align :";
            // 
            // channels
            // 
            this.channels.AutoSize = true;
            this.channels.Location = new System.Drawing.Point(207, 171);
            this.channels.Name = "channels";
            this.channels.Size = new System.Drawing.Size(35, 13);
            this.channels.TabIndex = 7;
            this.channels.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Channels :";
            // 
            // sampleRate
            // 
            this.sampleRate.AutoSize = true;
            this.sampleRate.Location = new System.Drawing.Point(207, 292);
            this.sampleRate.Name = "sampleRate";
            this.sampleRate.Size = new System.Drawing.Size(35, 13);
            this.sampleRate.TabIndex = 13;
            this.sampleRate.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sample Rate :";
            // 
            // extraSize
            // 
            this.extraSize.AutoSize = true;
            this.extraSize.Location = new System.Drawing.Point(207, 251);
            this.extraSize.Name = "extraSize";
            this.extraSize.Size = new System.Drawing.Size(41, 13);
            this.extraSize.TabIndex = 11;
            this.extraSize.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Extra Size :";
            // 
            // encoding
            // 
            this.encoding.AutoSize = true;
            this.encoding.Location = new System.Drawing.Point(207, 210);
            this.encoding.Name = "encoding";
            this.encoding.Size = new System.Drawing.Size(41, 13);
            this.encoding.TabIndex = 9;
            this.encoding.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Encoding :";
            // 
            // WaveInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 325);
            this.Controls.Add(this.sampleRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.extraSize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.encoding);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.channels);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.blockAlign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bitsPer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label1);
            this.Name = "WaveInformationForm";
            this.Text = "WaveInformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label bitsPer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label blockAlign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label channels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label sampleRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label extraSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label encoding;
        private System.Windows.Forms.Label label13;
    }
}
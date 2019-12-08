namespace UI_A4_HMI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnHopper = new System.Windows.Forms.Button();
            this.btnFillHeads = new System.Windows.Forms.Button();
            this.btnWeighStation = new System.Windows.Forms.Button();
            this.btnSealer = new System.Windows.Forms.Button();
            this.btnLabeller = new System.Windows.Forms.Button();
            this.btnCasePacker = new System.Windows.Forms.Button();
            this.lblStationStatus = new System.Windows.Forms.Label();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.lbHopperMinus = new System.Windows.Forms.Label();
            this.lblFillHeadMinus = new System.Windows.Forms.Label();
            this.lblSealerMinus = new System.Windows.Forms.Label();
            this.lblWeighStationMinus = new System.Windows.Forms.Label();
            this.lblLabellerMinus = new System.Windows.Forms.Label();
            this.lblCasePackerMinus = new System.Windows.Forms.Label();
            this.lblHopperPlus = new System.Windows.Forms.Label();
            this.lblFillHeadsPlus = new System.Windows.Forms.Label();
            this.lblSealerPlus = new System.Windows.Forms.Label();
            this.lblWeighStationPlus = new System.Windows.Forms.Label();
            this.lblLabellerPlus = new System.Windows.Forms.Label();
            this.lblCasePackerPlus = new System.Windows.Forms.Label();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Station";
            // 
            // btnHopper
            // 
            this.btnHopper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopper.Location = new System.Drawing.Point(144, 93);
            this.btnHopper.Name = "btnHopper";
            this.btnHopper.Size = new System.Drawing.Size(208, 75);
            this.btnHopper.TabIndex = 1;
            this.btnHopper.Text = "Hopper";
            this.btnHopper.UseVisualStyleBackColor = true;
            this.btnHopper.Click += new System.EventHandler(this.btnHopper_Click);
            // 
            // btnFillHeads
            // 
            this.btnFillHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillHeads.Location = new System.Drawing.Point(144, 190);
            this.btnFillHeads.Name = "btnFillHeads";
            this.btnFillHeads.Size = new System.Drawing.Size(208, 75);
            this.btnFillHeads.TabIndex = 2;
            this.btnFillHeads.Text = "Fill Heads";
            this.btnFillHeads.UseVisualStyleBackColor = true;
            this.btnFillHeads.Click += new System.EventHandler(this.btnFillHeads_Click);
            // 
            // btnWeighStation
            // 
            this.btnWeighStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeighStation.Location = new System.Drawing.Point(144, 388);
            this.btnWeighStation.Name = "btnWeighStation";
            this.btnWeighStation.Size = new System.Drawing.Size(208, 75);
            this.btnWeighStation.TabIndex = 3;
            this.btnWeighStation.Text = "Weigh Station";
            this.btnWeighStation.UseVisualStyleBackColor = true;
            this.btnWeighStation.Click += new System.EventHandler(this.btnWeighStation_Click);
            // 
            // btnSealer
            // 
            this.btnSealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSealer.Location = new System.Drawing.Point(144, 287);
            this.btnSealer.Name = "btnSealer";
            this.btnSealer.Size = new System.Drawing.Size(208, 75);
            this.btnSealer.TabIndex = 4;
            this.btnSealer.Text = "Sealer";
            this.btnSealer.UseVisualStyleBackColor = true;
            this.btnSealer.Click += new System.EventHandler(this.btnSealer_Click);
            // 
            // btnLabeller
            // 
            this.btnLabeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabeller.Location = new System.Drawing.Point(144, 487);
            this.btnLabeller.Name = "btnLabeller";
            this.btnLabeller.Size = new System.Drawing.Size(208, 75);
            this.btnLabeller.TabIndex = 5;
            this.btnLabeller.Text = "Labeller";
            this.btnLabeller.UseVisualStyleBackColor = true;
            this.btnLabeller.Click += new System.EventHandler(this.btnLabeller_Click);
            // 
            // btnCasePacker
            // 
            this.btnCasePacker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasePacker.Location = new System.Drawing.Point(144, 584);
            this.btnCasePacker.Name = "btnCasePacker";
            this.btnCasePacker.Size = new System.Drawing.Size(208, 75);
            this.btnCasePacker.TabIndex = 6;
            this.btnCasePacker.Text = "Case Packer";
            this.btnCasePacker.UseVisualStyleBackColor = true;
            this.btnCasePacker.Click += new System.EventHandler(this.btnCasePacker_Click);
            // 
            // lblStationStatus
            // 
            this.lblStationStatus.AutoSize = true;
            this.lblStationStatus.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationStatus.Location = new System.Drawing.Point(636, 135);
            this.lblStationStatus.Name = "lblStationStatus";
            this.lblStationStatus.Size = new System.Drawing.Size(254, 33);
            this.lblStationStatus.TabIndex = 9;
            this.lblStationStatus.Text = "Line and Error Screen";
            // 
            // rtbDetails
            // 
            this.rtbDetails.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetails.ForeColor = System.Drawing.Color.Yellow;
            this.rtbDetails.Location = new System.Drawing.Point(439, 175);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.Size = new System.Drawing.Size(636, 485);
            this.rtbDetails.TabIndex = 10;
            this.rtbDetails.Text = "";
            // 
            // lbHopperMinus
            // 
            this.lbHopperMinus.AutoSize = true;
            this.lbHopperMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHopperMinus.Location = new System.Drawing.Point(83, 92);
            this.lbHopperMinus.Name = "lbHopperMinus";
            this.lbHopperMinus.Size = new System.Drawing.Size(55, 76);
            this.lbHopperMinus.TabIndex = 11;
            this.lbHopperMinus.Text = "-";
            this.lbHopperMinus.Click += new System.EventHandler(this.lbHopperMinus_Click);
            // 
            // lblFillHeadMinus
            // 
            this.lblFillHeadMinus.AutoSize = true;
            this.lblFillHeadMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillHeadMinus.Location = new System.Drawing.Point(83, 190);
            this.lblFillHeadMinus.Name = "lblFillHeadMinus";
            this.lblFillHeadMinus.Size = new System.Drawing.Size(55, 76);
            this.lblFillHeadMinus.TabIndex = 12;
            this.lblFillHeadMinus.Text = "-";
            this.lblFillHeadMinus.Click += new System.EventHandler(this.lblFillHeadMinus_Click);
            // 
            // lblSealerMinus
            // 
            this.lblSealerMinus.AutoSize = true;
            this.lblSealerMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSealerMinus.Location = new System.Drawing.Point(83, 286);
            this.lblSealerMinus.Name = "lblSealerMinus";
            this.lblSealerMinus.Size = new System.Drawing.Size(55, 76);
            this.lblSealerMinus.TabIndex = 13;
            this.lblSealerMinus.Text = "-";
            this.lblSealerMinus.Click += new System.EventHandler(this.lblSealerMinus_Click);
            // 
            // lblWeighStationMinus
            // 
            this.lblWeighStationMinus.AutoSize = true;
            this.lblWeighStationMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeighStationMinus.Location = new System.Drawing.Point(83, 387);
            this.lblWeighStationMinus.Name = "lblWeighStationMinus";
            this.lblWeighStationMinus.Size = new System.Drawing.Size(55, 76);
            this.lblWeighStationMinus.TabIndex = 14;
            this.lblWeighStationMinus.Text = "-";
            this.lblWeighStationMinus.Click += new System.EventHandler(this.lblWeighStationMinus_Click);
            // 
            // lblLabellerMinus
            // 
            this.lblLabellerMinus.AutoSize = true;
            this.lblLabellerMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabellerMinus.Location = new System.Drawing.Point(83, 486);
            this.lblLabellerMinus.Name = "lblLabellerMinus";
            this.lblLabellerMinus.Size = new System.Drawing.Size(55, 76);
            this.lblLabellerMinus.TabIndex = 15;
            this.lblLabellerMinus.Text = "-";
            this.lblLabellerMinus.Click += new System.EventHandler(this.lblLabellerMinus_Click);
            // 
            // lblCasePackerMinus
            // 
            this.lblCasePackerMinus.AutoSize = true;
            this.lblCasePackerMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasePackerMinus.Location = new System.Drawing.Point(83, 584);
            this.lblCasePackerMinus.Name = "lblCasePackerMinus";
            this.lblCasePackerMinus.Size = new System.Drawing.Size(55, 76);
            this.lblCasePackerMinus.TabIndex = 16;
            this.lblCasePackerMinus.Text = "-";
            this.lblCasePackerMinus.Click += new System.EventHandler(this.lblCasePackerMinus_Click);
            // 
            // lblHopperPlus
            // 
            this.lblHopperPlus.AutoSize = true;
            this.lblHopperPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHopperPlus.Location = new System.Drawing.Point(358, 105);
            this.lblHopperPlus.Name = "lblHopperPlus";
            this.lblHopperPlus.Size = new System.Drawing.Size(59, 63);
            this.lblHopperPlus.TabIndex = 17;
            this.lblHopperPlus.Text = "+";
            this.lblHopperPlus.Click += new System.EventHandler(this.lblHopperPlus_Click);
            // 
            // lblFillHeadsPlus
            // 
            this.lblFillHeadsPlus.AutoSize = true;
            this.lblFillHeadsPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillHeadsPlus.Location = new System.Drawing.Point(358, 203);
            this.lblFillHeadsPlus.Name = "lblFillHeadsPlus";
            this.lblFillHeadsPlus.Size = new System.Drawing.Size(59, 63);
            this.lblFillHeadsPlus.TabIndex = 18;
            this.lblFillHeadsPlus.Text = "+";
            this.lblFillHeadsPlus.Click += new System.EventHandler(this.lblFillHeadsPlus_Click);
            // 
            // lblSealerPlus
            // 
            this.lblSealerPlus.AutoSize = true;
            this.lblSealerPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSealerPlus.Location = new System.Drawing.Point(358, 299);
            this.lblSealerPlus.Name = "lblSealerPlus";
            this.lblSealerPlus.Size = new System.Drawing.Size(59, 63);
            this.lblSealerPlus.TabIndex = 19;
            this.lblSealerPlus.Text = "+";
            this.lblSealerPlus.Click += new System.EventHandler(this.lblSealerPlus_Click);
            // 
            // lblWeighStationPlus
            // 
            this.lblWeighStationPlus.AutoSize = true;
            this.lblWeighStationPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeighStationPlus.Location = new System.Drawing.Point(358, 400);
            this.lblWeighStationPlus.Name = "lblWeighStationPlus";
            this.lblWeighStationPlus.Size = new System.Drawing.Size(59, 63);
            this.lblWeighStationPlus.TabIndex = 20;
            this.lblWeighStationPlus.Text = "+";
            this.lblWeighStationPlus.Click += new System.EventHandler(this.lblWeighStationPlus_Click);
            // 
            // lblLabellerPlus
            // 
            this.lblLabellerPlus.AutoSize = true;
            this.lblLabellerPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabellerPlus.Location = new System.Drawing.Point(358, 499);
            this.lblLabellerPlus.Name = "lblLabellerPlus";
            this.lblLabellerPlus.Size = new System.Drawing.Size(59, 63);
            this.lblLabellerPlus.TabIndex = 21;
            this.lblLabellerPlus.Text = "+";
            this.lblLabellerPlus.Click += new System.EventHandler(this.lblLabellerPlus_Click);
            // 
            // lblCasePackerPlus
            // 
            this.lblCasePackerPlus.AutoSize = true;
            this.lblCasePackerPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasePackerPlus.Location = new System.Drawing.Point(358, 596);
            this.lblCasePackerPlus.Name = "lblCasePackerPlus";
            this.lblCasePackerPlus.Size = new System.Drawing.Size(59, 63);
            this.lblCasePackerPlus.TabIndex = 22;
            this.lblCasePackerPlus.Text = "+";
            this.lblCasePackerPlus.Click += new System.EventHandler(this.lblCasePackerPlus_Click);
            // 
            // rtbLogs
            // 
            this.rtbLogs.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogs.ForeColor = System.Drawing.Color.LawnGreen;
            this.rtbLogs.Location = new System.Drawing.Point(1099, 175);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(636, 484);
            this.rtbLogs.TabIndex = 23;
            this.rtbLogs.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1383, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 33);
            this.label2.TabIndex = 24;
            this.label2.Text = "Logs";
            // 
            // pictureBox
            // 
            this.pictureBox.InitialImage = global::UI_A4_HMI.Properties.Resources.pinpng_com_green_light_png_29522;
            this.pictureBox.Location = new System.Drawing.Point(439, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(80, 80);
            this.pictureBox.TabIndex = 25;
            this.pictureBox.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(523, 56);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(375, 33);
            this.labelError.TabIndex = 26;
            this.labelError.Text = "All Stations Operating Optimally";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 686);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbLogs);
            this.Controls.Add(this.lblCasePackerPlus);
            this.Controls.Add(this.lblLabellerPlus);
            this.Controls.Add(this.lblWeighStationPlus);
            this.Controls.Add(this.lblSealerPlus);
            this.Controls.Add(this.lblFillHeadsPlus);
            this.Controls.Add(this.lblHopperPlus);
            this.Controls.Add(this.lblCasePackerMinus);
            this.Controls.Add(this.lblLabellerMinus);
            this.Controls.Add(this.lblWeighStationMinus);
            this.Controls.Add(this.lblSealerMinus);
            this.Controls.Add(this.lblFillHeadMinus);
            this.Controls.Add(this.lbHopperMinus);
            this.Controls.Add(this.rtbDetails);
            this.Controls.Add(this.lblStationStatus);
            this.Controls.Add(this.btnCasePacker);
            this.Controls.Add(this.btnLabeller);
            this.Controls.Add(this.btnSealer);
            this.Controls.Add(this.btnWeighStation);
            this.Controls.Add(this.btnFillHeads);
            this.Controls.Add(this.btnHopper);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Paint Commander";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHopper;
        private System.Windows.Forms.Button btnFillHeads;
        private System.Windows.Forms.Button btnWeighStation;
        private System.Windows.Forms.Button btnSealer;
        private System.Windows.Forms.Button btnLabeller;
        private System.Windows.Forms.Button btnCasePacker;
        private System.Windows.Forms.Label lblStationStatus;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.Label lbHopperMinus;
        private System.Windows.Forms.Label lblFillHeadMinus;
        private System.Windows.Forms.Label lblSealerMinus;
        private System.Windows.Forms.Label lblWeighStationMinus;
        private System.Windows.Forms.Label lblLabellerMinus;
        private System.Windows.Forms.Label lblCasePackerMinus;
        private System.Windows.Forms.Label lblHopperPlus;
        private System.Windows.Forms.Label lblFillHeadsPlus;
        private System.Windows.Forms.Label lblSealerPlus;
        private System.Windows.Forms.Label lblWeighStationPlus;
        private System.Windows.Forms.Label lblLabellerPlus;
        private System.Windows.Forms.Label lblCasePackerPlus;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelError;
    }
}


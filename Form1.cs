using System;
using System.Windows.Forms;
using UI_A4_HMI.Managers;
using UI_A4_HMI.Models;

namespace UI_A4_HMI {

    public partial class Form1 : Form {
        private RichTextBox details;
        private Random random = new Random();
        private PaintLineManager paintLineManager;

        public Form1() {
            InitializeComponent();
            details = rtbDetails;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Properties.Resources.pinpng_com_green_light_png_29522;
            CustomForm customForm = new CustomForm(this, btnHopper, btnSealer, btnLabeller, btnCasePacker, btnWeighStation, btnFillHeads, rtbDetails, rtbLogs, pictureBox, labelError);
            paintLineManager = new PaintLineManager(customForm);
            paintLineManager.Init();
        }

        // Show number of cans in hopper = 0 to 120
        // >> warning if less than 40
        private void btnHopper_Click(object sender, EventArgs e) {
            details.Clear();
            int random = GetRandomNumber(0, 120);
            details.Text = "\nCans in Hopper:\t\t" + random;
            // Determine warning
            if (random < 40) {

            }
        }

        // Show number of cartons = 0 to 200
        // >> warning if less than 20
        // Show if there is a jam = true/false
        // >> warning if there is a jam
        // Shows Pallets missing = true/false
        // >> warning if there is no skid pallet
        private void btnCasePacker_Click(object sender, EventArgs e) {
            details.Clear();
            int randomCartons = GetRandomNumber(0, 200);
            int randomJam = GetRandomNumber(0, 10);
            int randomPallets = GetRandomNumber(0, 10);
            String wasJam = "NO";
            String noPallets = "NO";
            if (randomJam % 2 == 0) {
                wasJam = "YES";
            }
            if (randomPallets % 2 == 0) {
                noPallets = "YES";
            }
            details.Text = "\nNumber of Cartons:\t\t" + randomCartons
                + "\n\nJammed:\t\t\t" + wasJam
                + "\n\nPallets:\t\t\t" + noPallets;
            // Determine warning
        }



        // Shows Can weight = 3900 to 4100ml
        // >> Warning when less than 3900 ml
        private void btnWeighStation_Click(object sender, EventArgs e) {
            details.Clear();
            int random = GetRandomNumber(120, 4100);
            details.Text = "\nCan Weight:\t\t" + random;

            // Determine warning
            if (random < 3900) {

            }
        }


        // Show number of lids in the hopper = 0 to 240
        // >> warning if value is less than 40 lids
        private void btnSealer_Click(object sender, EventArgs e) {
            details.Clear();
            int random = GetRandomNumber(0, 20000);
            details.Text = "\nNumber of Lids:\t\t" + random;

            // Determine warning
            if (random <= 40) {

            }
        }



        // Show Volume of paint/product = 0 to 20,000 litres
        // >> warning if less than 180 litres
        // Show Fill head down = true/false
        // >> warning if true (i.e. clogged)
        private void btnFillHeads_Click(object sender, EventArgs e) {
            details.Clear();
            int randomProduct = GetRandomNumber(0, 20000);
            int randomFillHeads = GetRandomNumber(0, 10);
            String state = "UP";
            if (randomFillHeads % 2 == 0) {
                state = "DOWN";
            }
            details.Text = "\nPaint Volume:\t\t" + randomProduct
                + "\n\nFill head:\t\t\t" + state;

            // Determine warning
            if (randomProduct <= 180) {

            }
            if (randomFillHeads % 2 == 0) {

            }
        }


        // Shows if labels are present
        // >> warning if no labels
        private void btnLabeller_Click(object sender, EventArgs e) {
            details.Clear();
            int random = GetRandomNumber(0, 10);
            String present = "YES";
            if (random % 2 == 0) {
                present = "NO";
            }
            details.Text = "\nLabels Present:\t\t" + present;

            // Determine warning
        }


        private int GetRandomNumber(int min, int max) {
           
            return random.Next(min, max);
        }

        private void lbHopperMinus_Click(object sender, EventArgs e) {

        }

        private void lblHopperPlus_Click(object sender, EventArgs e) {

        }

        private void lblFillHeadMinus_Click(object sender, EventArgs e) {

        }

        private void lblFillHeadsPlus_Click(object sender, EventArgs e) {

        }

        private void lblSealerMinus_Click(object sender, EventArgs e) {

        }

        private void lblSealerPlus_Click(object sender, EventArgs e) {

        }

        private void lblWeighStationMinus_Click(object sender, EventArgs e) {

        }
        private void lblWeighStationPlus_Click(object sender, EventArgs e) {

        }

        private void lblLabellerMinus_Click(object sender, EventArgs e) {

        }
        private void lblLabellerPlus_Click(object sender, EventArgs e) {

        }

        private void lblCasePackerMinus_Click(object sender, EventArgs e) {

        }

        private void lblCasePackerPlus_Click(object sender, EventArgs e) {

        }
    }
}

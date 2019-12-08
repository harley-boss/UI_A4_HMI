
using System.Windows.Forms;

namespace UI_A4_HMI.Models {
    class CustomForm {
        public Button btnHopper;
        public Button btnSealer;
        public Button btnLabeller;
        public Button btnCasePacker;
        public Button btnWeighStation;
        public Button btnFillHeads;
        public Form form;
        public RichTextBox console;
        public RichTextBox logs;
        public PictureBox picture;
        public Label errorLabel;

        public CustomForm(Form form, Button btnHopper,
                            Button btnSealer, Button btnLabeller,
                            Button btnCasePacker, Button btnWeighStation,
                            Button btnFillHeads,
                            RichTextBox console,
                            RichTextBox logs,
                            PictureBox pictureBox,
                            Label errorLabel) {
            this.form = form;
            this.btnHopper = btnHopper;
            this.btnSealer = btnSealer;
            this.btnLabeller = btnLabeller;
            this.btnCasePacker = btnCasePacker;
            this.btnWeighStation = btnWeighStation;
            this.btnFillHeads = btnFillHeads;
            this.console = console;
            this.logs = logs;
            this.picture = pictureBox;
            this.errorLabel = errorLabel;
        }
    }
}

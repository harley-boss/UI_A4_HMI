using System;
using System.Windows.Forms;
using UI_A4_HMI.Models;
using UI_A4_HMI.Utilities;
using static UI_A4_HMI.Models.Hopper;
using static UI_A4_HMI.Models.Labeller;

namespace UI_A4_HMI.Managers {

    class PaintLineManager : HopperObserver,
                             CasePickerObserver, 
                             WeighStationObserver,
                             LabellerObserver,
                             FillHeadObserver,
                             SealerObserver {

        private Hopper hopper;
        private CasePacker casePacker;
        private FillHead fillHead;
        private Labeller labeller;
        private Sealer sealer;
        private WeighStation weighStation;
        private Boolean isInError;
        private delegate void SafeCallDelegate(string text);
        private CustomForm customForm;

        public PaintLineManager(CustomForm customForm) {
            this.customForm = customForm;
            hopper = new Hopper(this);
            casePacker = new CasePacker(this);
            weighStation = new WeighStation(this);
            fillHead = new FillHead(this);
            labeller = new Labeller(this);
            sealer = new Sealer(this);
        }

        public void Init() {
            hopper.Init();
            casePacker.Init();
            weighStation.Init();
            fillHead.Init();
            labeller.Init();
            sealer.Init();
        }

        private void HandleError(ErrorTypes error, String message = null, double count = -1) {
            if (isInError) {
                return;
            }
            ThreadHelper.SetText(customForm.form, customForm.logs, "-----------------------------------------------------------\n"
                                            + error + "\n" + message + "\n" + count
                                            + "\n-----------------------------------------------------------");

            // If there is an error all flow needs to stop
            isInError = true;
            customForm.picture.Image = Properties.Resources.pngkey_com_flashing_lights_png_853491;
            ThreadHelper.SetText(customForm.form, customForm.errorLabel, message);

            // Update the UI
            switch (error) {
                case ErrorTypes.HOPPER:
                    break;
                case ErrorTypes.CASE_PACKER:
                    break;
                case ErrorTypes.LABELLER:
                    break;
                case ErrorTypes.SEALER:
                    break;
                case ErrorTypes.WEIGH_STATION:
                    break;
                case ErrorTypes.FILL_HEAD:
                    break;
                case ErrorTypes.IS_JAMMED:
                    break;
                case ErrorTypes.FILL_HEAD_DOWN:
                    break;
            }
        }

        private void HandleWarning(ErrorTypes error, String message = null, double count = -1) {
            customForm.picture.Image = Properties.Resources.SeekPng_com_yellow_circle_png_1738244;
            ThreadHelper.SetText(customForm.form, customForm.errorLabel, message);
        }

        public void onCasePickerError(String error, double count) {
            HandleError(ErrorTypes.CASE_PACKER, error, count);
        }

        public void onHopperError(string error, double count) {
            HandleError(ErrorTypes.HOPPER, error, count);
        }

        public void onSealerError(string error, double count) {
            HandleError(ErrorTypes.SEALER, error, count);
        }

        public void onWeighStationError(String error, double count) {
            HandleError(ErrorTypes.WEIGH_STATION, error, count);
        }

        public void isJammed(String error) {
            HandleError(ErrorTypes.IS_JAMMED, error);
        }

        public void onLabellerError(string error) {
            HandleError(ErrorTypes.LABELLER, error);
        }

        public void onFillHeadError(string error, double count) {
            HandleError(ErrorTypes.FILL_HEAD, error, count);
        }

        public void onFillHeadsDown(string error) {
            HandleError(ErrorTypes.FILL_HEAD_DOWN, error);
        }

        public void isJammed() {
            HandleError(ErrorTypes.IS_JAMMED);
        }

        public void onCasePickerWarning(string error, double count) {
            HandleWarning(ErrorTypes.CASE_PACKER, error, count);
        }
    }
}

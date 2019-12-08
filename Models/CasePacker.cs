using System;
using UI_A4_HMI.Utilities;
using static UI_A4_HMI.Utilities.PaintTimer;

namespace UI_A4_HMI.Models {
    class CasePacker : TimerEventObserver {

        private static double MINIMUM = 0;
        private static double MAXIMUM = 200;
        private static int ERROR_LEVEL = 20;
        private static int WARNING_LEVEL = 50;
        private static int DURATION = 5;
        private static String error = "CASE COUNT ERROR - Add more cartons";
        private static String warning = "CASE COUNT WARNING - Carton levels becoming low";
        private CasePickerObserver observer;
        private PaintTimer paintTimer;
        Random random = new Random();

        public CasePacker(CasePickerObserver observer) {
            this.observer = observer;
            paintTimer = new PaintTimer(this);
        }

        public void Init() {
            paintTimer.StartTimer(DURATION);
        }

        public void ClearError() {
            paintTimer.Stop();
            paintTimer.StartTimer(DURATION);
        }

        private double GenerateRandomValue() {
            return random.NextDouble() * (MAXIMUM - MINIMUM) + MINIMUM;
        }

        private Boolean GenerateIsJam() {
            return random.Next(0, 10) == 2;
        }

        void TimerEventObserver.onTimerEvent() {
            Boolean wasError = false;
            if (GenerateIsJam()) {
                observer.isJammed();
                wasError = true;
            }
            double count = GenerateRandomValue();
            if (count < ERROR_LEVEL) {
                observer.onCasePickerError(error, count);
                wasError = true;
            } else if (count < WARNING_LEVEL) {
                observer.onCasePickerWarning(warning, count);
            }
            if (!wasError) {
                ClearError();
            }
        }
    }

    public interface CasePickerObserver {
        void onCasePickerError(String error, double count);
        void onCasePickerWarning(String error, double count);
        void isJammed();
    }
}

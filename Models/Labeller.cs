using System;
using UI_A4_HMI.Utilities;
using static UI_A4_HMI.Utilities.PaintTimer;

namespace UI_A4_HMI.Models {
    class Labeller : TimerEventObserver {
        private static int DURATION = 5;
        private static String error = "LABELLER ERROR - No labels present";
        private LabellerObserver observer;
        private PaintTimer paintTimer;
        Random random = new Random();

        public Labeller(LabellerObserver observer) {
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

        private void generateWarning() {
            if (GenerateLabellerError()) {
                observer.onLabellerError(error);
            }
        }

        public void onTimerEvent() {
            generateWarning();
        }

        private Boolean GenerateLabellerError() {
            return random.Next(0, 10) == 2;
        }

        public interface LabellerObserver {
            void onLabellerError(String error);
        }
    }
}

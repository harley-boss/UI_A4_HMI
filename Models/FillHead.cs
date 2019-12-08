using System;
using UI_A4_HMI.Utilities;
using static UI_A4_HMI.Utilities.PaintTimer;

namespace UI_A4_HMI.Models {
    class FillHead : TimerEventObserver {

        private static double MINIMUM = 0;
        private static double MAXIMUM = 20000;
        private static int WARNING_LEVEL = 180;
        private static int DURATION = 5;
        private static String error = "FILL HEAD WARNING - Increase fluid level in fill heads";
        private static String fillHeadsError = "FILL HEADS CLOGGED - Clean fill heads";
        private FillHeadObserver observer;
        private PaintTimer paintTimer;
        Random random = new Random();

        public FillHead(FillHeadObserver observer) {
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

        private Boolean GenerateFillHeadsAreDown() {
            return random.Next(0, 10) == 2;
        }

        void TimerEventObserver.onTimerEvent() {
            Boolean wasError = false;
            if (GenerateFillHeadsAreDown()) {
                observer.onFillHeadsDown(fillHeadsError);
                wasError = true;
            }
            double count = GenerateRandomValue();
            if (count < WARNING_LEVEL) {
                observer.onFillHeadError(error, count);
                wasError = true;
            }
            if (!wasError) {
                ClearError();
            }
        }
    }

    public interface FillHeadObserver {
        void onFillHeadError(String error, double count);
        void onFillHeadsDown(String error);
    }
}

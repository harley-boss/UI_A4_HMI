using System;
using UI_A4_HMI.Utilities;
using static UI_A4_HMI.Utilities.PaintTimer;

namespace UI_A4_HMI.Models {
    class WeighStation : TimerEventObserver {

        private static double MINIMUM = 3900;
        private static double MAXIMUM = 4100;
        private static int WARNING_LEVEL = 3900;
        private static int DURATION = 5;
        private static String error = "WEIGH STATION WARNING - Paint weight invalid, remove can";
        private WeighStationObserver observer;
        private PaintTimer paintTimer;
        Random random = new Random();

        public WeighStation(WeighStationObserver observer) {
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

        void TimerEventObserver.onTimerEvent() {
            Boolean wasError = false;
            double count = GenerateRandomValue();
            if (count < WARNING_LEVEL) {
                observer.onWeighStationError(error, count);
                wasError = true;
            }
            if (!wasError) {
                ClearError();
            }
        }
    }

    public interface WeighStationObserver {
        void onWeighStationError(String error, double count);
    }
}

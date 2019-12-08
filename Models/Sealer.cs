using System;
using UI_A4_HMI.Utilities;
using static UI_A4_HMI.Utilities.PaintTimer;

namespace UI_A4_HMI.Models {
    class Sealer : TimerEventObserver {

        private static double MINIMUM = 0;
        private static double MAXIMUM = 240;
        private static int WARNING_LEVEL = 40;
        private static int DURATION = 5;
        private static String error = "SEALER WARNING - Add more lids";
        private SealerObserver observer;
        private PaintTimer paintTimer;
        Random random = new Random();

        public Sealer(SealerObserver observer) {
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
                observer.onSealerError(error, count);
                wasError = true;
            }
            if (!wasError) {
                ClearError();
            }
        }
    }

    public interface SealerObserver {
        void onSealerError(String error, double count);
    }
}

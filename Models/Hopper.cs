using System;
using UI_A4_HMI.Utilities;
using static UI_A4_HMI.Utilities.PaintTimer;


namespace UI_A4_HMI.Models {
    class Hopper : TimerEventObserver {
        private static double MINIMUM = 0;
        private static double MAXIMUM = 120;
        private static int WARNING_LEVEL = 40;
        private static int DURATION = 5;
        private static String error = "CASE COUNT WARNING - Increase can count";
        private HopperObserver observer;
        private PaintTimer paintTimer;
        Random random = new Random();

        public Hopper(HopperObserver observer) {
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
            double count = GenerateRandomValue();
            if (count < WARNING_LEVEL) {
                observer.onHopperError(error, count);
            }
        }

        public void onTimerEvent() {
            generateWarning();
        }

        public double GenerateRandomValue() {
            return random.NextDouble() * (MAXIMUM - MINIMUM) + MINIMUM;
        }

        public interface HopperObserver {
            void onHopperError(String error, double count);
        }
    }
}

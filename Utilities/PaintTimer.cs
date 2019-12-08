using System.Timers;

namespace UI_A4_HMI.Utilities {
    
    class PaintTimer {

        private Timer timer;
        private TimerEventObserver observer;

        public PaintTimer(TimerEventObserver observer) {
            this.observer = observer;
            
        }

        public void StartTimer(int interval) {
            timer = new Timer(1000 * interval);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
            timer.Start();
        }

        public void Stop() {
            timer.Stop();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e) {
            observer.onTimerEvent();
        }

        public interface TimerEventObserver {
            void onTimerEvent();
        }
    }
}

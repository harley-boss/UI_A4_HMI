using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_A4_HMI.Utilities {
    class ThreadHelper {
        delegate void SetTextCallback(Form f, Control ctrl, string text);

        public static void SetText(Form form, Control ctrl, string text) {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            } else {
                ctrl.Text = text;
            }
        }

        public static void AppendText(Form form, Control ctrl, string text) {
            if (ctrl.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            } else {
                ctrl.Text += text;
            }
        }
    }
}

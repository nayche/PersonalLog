using System;
using System.Windows.Forms;

namespace PersonalLog
{
    public static class Utilities
    {
        public static void ErrorMsgBox (string Message)
        {
            MessageBox.Show(Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void WarningMsgBox(string Message)
        {
            MessageBox.Show(Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void InfoMsgBox(string Message)
        {
            MessageBox.Show(Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

    
}

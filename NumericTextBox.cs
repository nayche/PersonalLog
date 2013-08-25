using System;

namespace PersonalLog
{
    class NumericTextBox: System.Windows.Forms.TextBox
    {
        //Fileds
        private bool xAllowBackSpace = false;

        //Methods
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            //if (xAllowBackSpace || char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //else { e.Handled = true; }
            
        }

        //Properties
        public bool AllowBackSpace
        {
            set { this.xAllowBackSpace = value; }
            get { return this.xAllowBackSpace; }
            
        }

        
    }
}

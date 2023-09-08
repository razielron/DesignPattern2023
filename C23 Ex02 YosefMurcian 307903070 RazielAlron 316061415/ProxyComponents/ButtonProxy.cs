using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProxyComponents
{
    public class ButtonProxy : Button
    {
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (!IsDesignMode() && base.IsHandleCreated)
                {
                    base.Invoke(new Action(() => base.Text = value));
                }
                else
                {
                    base.Text = value;
                }
            }
        }

        public new bool Enabled
        {
            get
            {
                return base.Enabled;
            }
            set
            {
                if (!IsDesignMode() && base.IsHandleCreated)
                {
                    base.Invoke(new Action(() => base.Enabled = value));
                }
                else
                {
                    base.Enabled = value;
                }
            }
        }

        private bool IsDesignMode()
        {
            return DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }
    }
}

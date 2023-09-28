using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProxyComponents
{
    public class PictureBoxProxy : PictureBox
    {
        public new string ImageLocation
        {
            get
            {
                return base.ImageLocation;
            }
            set
            {
                if (!IsDesignMode() && base.IsHandleCreated)
                {
                    base.Invoke(new Action(() => base.ImageLocation = value));
                }
                else
                {
                    base.ImageLocation = value;
                }
            }
        }

        public new PictureBoxSizeMode SizeMode
        {
            get
            {
                return base.SizeMode;
            }
            set
            {
                if (!IsDesignMode() && base.IsHandleCreated)
                {
                    base.Invoke(new Action(() => base.SizeMode = value));
                }
                else
                {
                    base.SizeMode = value;
                }
            }
        }

        private bool IsDesignMode()
        {
            return DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }
    }
}

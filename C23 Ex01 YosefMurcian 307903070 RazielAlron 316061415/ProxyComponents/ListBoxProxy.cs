using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProxyComponents
{
    public class ListBoxProxy : ListBox
    {
        private bool IsDesignMode()
        {
            return DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        public new object DataSource
        {
            get
            {
                return base.DataSource;
            }
            set
            {
                if (!IsDesignMode() && base.IsHandleCreated)
                {
                    base.Invoke(new Action(() => base.DataSource = value));
                }
                else
                {
                    base.DataSource = value;
                }
            }
        }

        public new string DisplayMember
        {
            get
            {
                return base.DisplayMember;
            }
            set
            {
                if (!IsDesignMode() && base.IsHandleCreated)
                {
                    base.Invoke(new Action(() => base.DisplayMember = value));
                }
                else
                {
                    base.DisplayMember = value;
                }
            }
        }
    }
}

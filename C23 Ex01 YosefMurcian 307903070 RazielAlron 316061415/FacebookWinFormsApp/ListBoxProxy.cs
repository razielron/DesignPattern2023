using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ListBoxProxy : ListBox
    {
        public new object DataSource
        {
            get
            {
                return base.DataSource;
            }
            set
            {
                if (base.IsHandleCreated)
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
                if (base.IsHandleCreated)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
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
                if (base.IsHandleCreated) 
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
                if (base.IsHandleCreated)
                {
                    base.Invoke(new Action(() => base.Enabled = value));
                }
                else
                {
                    base.Enabled = value;
                }
            }
        }
    }
}

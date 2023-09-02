using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
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
                if (base.IsHandleCreated)
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
                if (base.IsHandleCreated)
                {
                    base.Invoke(new Action(() => base.SizeMode = value));
                }
                else
                {
                    base.SizeMode = value;
                }
            }
        }
    }
}

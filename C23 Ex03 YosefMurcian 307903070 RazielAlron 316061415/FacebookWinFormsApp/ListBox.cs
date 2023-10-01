using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class ListBox
    {
        private System.Windows.Forms.ListBox m_ListBoxControl;

        public ListBox(System.Windows.Forms.ListBox listBoxControl)
        {
            this.m_ListBoxControl = listBoxControl;
        }

        public void DisplayData(IEnumerable<string> data)
        {
            m_ListBoxControl.DataSource = data;
        }
    }
}

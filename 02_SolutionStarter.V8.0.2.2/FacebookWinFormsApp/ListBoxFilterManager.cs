using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class ListBoxFilterManager
    {
        private IEnumerable<ListBoxDataModel> m_AllData;
        private IEnumerable<ListBoxDataModel> m_FilteredData;

        public ListBoxFilterManager(IEnumerable<ListBoxDataModel> allData)
        {
            m_AllData = allData;
            m_FilteredData = allData;
        }

        public List<ListBoxDataModel> GetDisplayedData()
        {
            return m_FilteredData.ToList();
        }

        public List<ListBoxDataModel> FilterData(string filter)
        {
            m_FilteredData = m_AllData
                .Where(x => x.DisplayName.ToLower().Contains(filter.ToLower()));

            return m_FilteredData.ToList();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class ListBoxFilterManager<T>
    {
        private List<ListBoxDataModel<T>> m_AllData;
        private List<ListBoxDataModel<T>> m_FilteredData;

        public ListBoxFilterManager(List<ListBoxDataModel<T>> allData)
        {
            m_AllData = allData;
            m_FilteredData = allData;
        }

        public List<ListBoxDataModel<T>> GetDisplayedData()
        {
            return m_FilteredData.ToList();
        }

        public List<ListBoxDataModel<T>> FilterData(string filter)
        {
            m_FilteredData = m_AllData
                .Where(x => x.DisplayName?.ToLower().Contains(filter.ToLower()) ?? false)
                .ToList();

            return m_FilteredData;
        }
    }
}

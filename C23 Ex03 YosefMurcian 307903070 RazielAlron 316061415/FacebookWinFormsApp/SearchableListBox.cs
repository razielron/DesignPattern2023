using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class SearchableListBox<T> : IListBoxDecorator
    {
        private IListBox m_DecoratedListBox;
        private TextBox m_SearchTextBox;
        private ListBoxFilterManager<T> m_FilterManager;

        public SearchableListBox(IListBox decoratedListBox, TextBox searchTextBox, ListBoxFilterManager<T> filterManager)
        {
            m_DecoratedListBox = decoratedListBox;
            m_SearchTextBox = searchTextBox;
            m_FilterManager = filterManager;
            m_SearchTextBox.TextChanged += OnSearchTextBoxTextChanged;
        }

        public void DisplayData(IEnumerable<string> data)
        {
            m_DecoratedListBox.DisplayData(data);
        }

        public void Search()
        {
            string searchText = m_SearchTextBox.Text;
            var filteredData = m_FilterManager.FilterData(searchText);
            m_DecoratedListBox.DisplayData(filteredData.Select(item => item.DisplayName));
        }

        private void OnSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }

}

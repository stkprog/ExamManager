using System.Collections;

namespace ExamManager {
    public class ListViewColumnSorter : IComparer {

        private int ColumnToSort;

        private SortOrder OrderOfSort;

        private CaseInsensitiveComparer ObjectCompare;

        public ListViewColumnSorter() {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y) {
            int compareResult;

            ListViewItem listViewX, listViewY;
            listViewX = (ListViewItem)x;
            listViewY = (ListViewItem)y;

            compareResult = ObjectCompare.Compare(listViewX.SubItems[ColumnToSort].Text, listViewY.SubItems[ColumnToSort].Text);

            if (OrderOfSort == SortOrder.Ascending) {
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending) {
                return (-compareResult);
            }
            else {
                return 0;
            }
        }

        public int SortColumn {
            set {
                ColumnToSort = value;
            }
            get {
                return ColumnToSort;
            }
        }

        public SortOrder Order {
            set {
                OrderOfSort = value;
            }
            get {
                return OrderOfSort;
            }
        }

    }
}

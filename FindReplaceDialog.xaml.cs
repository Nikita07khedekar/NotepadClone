using System.Windows;

namespace NotepadClone
{
    /// <summary>
    /// Interaction logic for FindReplaceDialog.xaml
    /// </summary>
    public partial class FindReplaceDialog : Window
    {
        public FindReplaceDialog()
        {
            InitializeComponent();
        }

        public string SearchText => txtSearch.Text;
        public string ReplaceText => txtReplace.Text;

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}

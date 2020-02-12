using System;
using System.Windows;

namespace FormCases
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Button is clicked");
        }

        private void CaseDescription(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (TestDescription.Name == "Description")
            {
                TestDescription.Text = "";
            }
        }

        private void BrowseButton(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                // Set filter for file extension and default file extension
                DefaultExt = ".xlsx",
                Filter = "XLSX Files (*.xlsx)|*.xlsx|XLS Files (*.xls)|*.xls|PDF Files (*.pdf)|*.pdf"
            };

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
            }
        }

        private void PlaceholderGotFocus(object sender, RoutedEventArgs e)
        {
            if (TestDescription.Text != "")
            {
                TestDescription.Text = string.Empty;
            }
        }

        private void PlaceholderLostFocus(object sender, RoutedEventArgs e)
        {
            if (TestDescription.Text == string.Empty)
            {
                TestDescription.Text = "Test Description";
            }
        }
    }
}
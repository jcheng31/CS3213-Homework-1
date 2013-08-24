using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace KwicKwakKwoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            String titleContents = TitleBox.Text;
            String ignoreContents = IgnoreBox.Text;

            List<String> titles = SplitStringIntoLines(titleContents);
            List<String> ignores = SplitStringIntoLines(ignoreContents);

            StringBuilder kwicBuilder = new StringBuilder();

            List<String> kwicResults = Controller.GenerateKwicIndex(titles, ignores);
            foreach (string kwicResult in kwicResults)
            {
                kwicBuilder.AppendLine(kwicResult);
            }
            KwicBox.Text = kwicBuilder.ToString();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text Files (*.txt)|*.txt";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;

                // Check which button is selected
                switch ( ((Button)sender).Tag.ToString() )
                {
                    case "title":
                        TitleBox.Text = File.ReadAllText(filename);
                        break;
                    case "ignored":
                        IgnoreBox.Text = File.ReadAllText(filename);
                        break;
                }
            }
        }

        private static List<String> SplitStringIntoLines(string titleContents)
        {
            string[] lines = titleContents.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return new List<string>(lines);
        }
    }
}

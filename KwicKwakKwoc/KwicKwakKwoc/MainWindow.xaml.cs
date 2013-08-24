﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private static List<String> SplitStringIntoLines(string titleContents)
        {
            string[] lines = titleContents.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            return new List<string>(lines);
        }
    }
}

using System;
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

namespace ReversWordsWPF
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

        private void buttonSplittingString_Click(object sender, RoutedEventArgs e)
        {
            SplittingStringIntoWords splittingStringIntoWords = new SplittingStringIntoWords();

            List<string> listSplitString = splittingStringIntoWords.Print(textBoxSplittingString.Text);
            for (int i = 0; i < listSplitString.Count(); i++)
            {
                listBoxSplitString.Items.Add(listSplitString[i]);
            }
        }

        private void buttonCleanSplittingString_Click(object sender, RoutedEventArgs e)
        {
            textBoxSplittingString.Clear();
            listBoxSplitString.Items.Clear();
        }

        private void buttonRearrangingWords_Click(object sender, RoutedEventArgs e)
        {
            RearrangingWordsInSentence rearrangingWords = new RearrangingWordsInSentence();

            string result = rearrangingWords.RearrangingWords(textBoxRearrangingWords.Text);
            labelRearrangingWords.Content = result;
           
        }

        private void buttonCleanRearrangingWords_Click(object sender, RoutedEventArgs e)
        {
            textBoxRearrangingWords.Clear();
            labelRearrangingWords.Content = "";
        }
    }
}

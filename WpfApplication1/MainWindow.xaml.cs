using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public string MyText = "Click";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, MouseButtonEventArgs e)
        {
            var textBlock = ((TextBlock) sender);
            textBlock.Text = textBlock.Text == MyText ? MyText + "ed again" : MyText;
        }
    }
}
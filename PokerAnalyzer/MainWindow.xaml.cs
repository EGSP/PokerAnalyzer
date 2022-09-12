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
using PokerAnalyzer.Code.Cards;
using PokerAnalyzer.Code.Functions;
using Table = PokerAnalyzer.Code.Table;

namespace PokerAnalyzer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _stackSize;
        private readonly Stack<Card> _cardStack;

        public MainWindow()
        {
            InitializeComponent();

            var stack = Table.Functions.CreateStack() as IList<Card> ?? throw new Exception();

            _stackSize = 52;
            _cardStack = new Stack<Card>(stack.Shuffle().Shuffle().Shuffle());
            UpdateStackLabel();
        }

        private void PutCardClick(object sender, RoutedEventArgs e)
        {
            if (_cardStack.Count <= 0)
            {
                MessageBox.Show("Колода закончилась");
                return;
            }

            var card = _cardStack.Pop();
            UpdateStackLabel();
            PlaceToGrid(card);
        }

        private void UpdateStackLabel()
        {
            StackCount.Content = _cardStack.Count;
        }

        private void PlaceToGrid(Card card)
        {
            var gridChildren = TableCardGrid.Children.Count;

            var cardLabel = new Label() { Content = card, FontFamily = new FontFamily("Trebuchet MS") };
            TableCardGrid.Children.Add(cardLabel);

            Grid.SetColumn(cardLabel, gridChildren % 5);
            Grid.SetRow(cardLabel, (int)(gridChildren / 5));
        }
    }
}
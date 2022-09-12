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

namespace PokerAnalyzer.Visual.Controls
{
    /// <summary>
    /// Логика взаимодействия для CardElement.xaml
    /// </summary>
    public partial class CardElement : UserControl
    {
        public CardElement()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public Image Suit => SuitIcon;
        public Image Rang => RangIcon;
    }

}


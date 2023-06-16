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

namespace FinancialPlanner.View.UserControls
{
    /// <summary>
    /// Interaction logic for MonthTab.xaml
    /// </summary>
    public partial class MonthTab : UserControl
    {
        public MonthTab()
        {
            InitializeComponent();
        }

        private string fill;
        private bool active;
        public string Fill
        {
            get { return fill; }
            set 
            { 
                fill = value;
                var converter = new BrushConverter();
                var brush = (Brush)converter.ConvertFromString(fill);
                this.Background.Fill = brush;
            }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set 
            { 
                text = value;
                TextBlock.Text = text;
            }
        }

        public void Active(bool activate)
        {
            if(activate)
            {
                //This is active
                BorderOne.Fill = Background.Fill;
                BorderOne.Opacity = .45;
                BorderTwo.Fill = Background.Fill;
                BorderTwo.Opacity = .45;
            }
            else
            {
                //This is not active
                var converter = new BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#000000");
                BorderOne.Fill = brush;
                BorderOne.Opacity = 100;
                BorderTwo.Fill = brush;
                BorderTwo.Opacity = 100;

            }
        }

    }
}

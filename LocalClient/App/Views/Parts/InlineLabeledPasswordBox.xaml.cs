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

namespace FriendlyBudget.LocalClient.App.Views.Parts
{
    /// <summary>
    /// Interaction logic for InlineLabeledPasswordBox.xaml
    /// </summary>
    public partial class InlineLabeledPasswordBox : UserControl
    {
        public InlineLabeledPasswordBox()
        {
            InitializeComponent();
        }

        string label = "";
        string textBox = "";

        public string LabelContent
        {
            get { return label; }
            set
            {
                label = value;
            }
        }
        public string TextBox
        {
            get { return textBox; }
            set
            {
                textBox = value;
            }
        }
    }
}

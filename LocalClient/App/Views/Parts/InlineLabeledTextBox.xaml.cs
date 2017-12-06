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
    /// Interaction logic for InlineLabeledTextBox.xaml
    /// </summary>
    public partial class InlineLabeledTextBox : UserControl
    {
        public InlineLabeledTextBox()
        {
            InitializeComponent();
        }

        public string LocalLabel { get; set; }
        public string LocalText { get; set; }
    }
}

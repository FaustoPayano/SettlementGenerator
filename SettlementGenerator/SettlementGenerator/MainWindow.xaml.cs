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

namespace SettlementGenerator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void HelpMenuListBox_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) {}

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e) {
            int numberOfPayments;

            if (Int32.TryParse(paymentTextBox.Text, out numberOfPayments)) {
                if (numberOfPayments > 5) {
                    PaymentEmoticon.Kind = MaterialDesignThemes.Wpf.PackIconKind.EmoticonSad;
                }
                else {
                    PaymentEmoticon.Kind = MaterialDesignThemes.Wpf.PackIconKind.EmoticonHappy;
                }
            }
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e) {
            TypeOfActionTakenComboBox.Visibility = Visibility.Visible;
            UniqueIdentifierTextBox.Visibility = Visibility.Visible;

        }

        private void NoActionTakenRadioButton_OnChecked(object sender, RoutedEventArgs e) {
            TypeOfActionTakenComboBox.SelectedIndex = -1;
            UniqueIdentifierTextBox.Text = String.Empty;
            TypeOfActionTakenComboBox.Visibility = Visibility.Collapsed;
            UniqueIdentifierTextBox.Visibility = Visibility.Collapsed;
        }
    }
}
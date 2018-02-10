using System;
using System.Windows;
using System.Windows.Controls;

namespace Lapka1 {
    /// <inheritdoc>
    ///     <cref></cref>
    /// </inheritdoc>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private UserDateModel _dateModel;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            this._dateModel = new UserDateModel(new DateTime(1970,1,2));
        }

        private void CalendarDatechanged(object sender, SelectionChangedEventArgs ebat)
        {
            try
            {
                var selectedDate = Cal.SelectedDate;
                _dateModel.SelectedDate = selectedDate;
                TextBlockAge.Text = $"Facts about you:\nYour Western Zodiak sign is {_dateModel.WesetrnZodiac}" +
                    $"\nYour Chinese Zodiak sing is {_dateModel.ChineseZodiac}\n"
                    + (_dateModel.IsBirthday ? $"And today you are {_dateModel.UserAge}! Happy Birthday!" : $"You are {_dateModel.UserAge}. Feeling old yet?");
            } catch (ArgumentException)
            {
                MessageBox.Show("Please enter valid date!");
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Lapka1.Annotations;

namespace Lapka1
{
    internal class UserViewModel : INotifyPropertyChanged
    {
        private UserDateModel _birthdayModel;

        public DateTime BirthDate
        {
            get { return _birthdayModel?.SelectedDate??DateTime.Today; }
            set
            {

                try
                {
                    if (_birthdayModel==null)
                        _birthdayModel = new UserDateModel();
                    _birthdayModel.SelectedDate = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TextToShow));
                }
                catch
                {
                    MessageBox.Show("Please enter valid date!");
                }
            }
        }

        public string TextToShow
        {
            get
            {
                return _birthdayModel != null
                    ? $"Facts about you:{Environment.NewLine}Your Western Zodiak sign is {_birthdayModel.WesetrnZodiac}{Environment.NewLine}Your Chinese Zodiak sing is {_birthdayModel.ChineseZodiac}{Environment.NewLine}" +
                      (_birthdayModel.IsBirthday
                          ? $"And today you are {_birthdayModel.UserAge}! Happy Birthday!"
                          : $"You are {_birthdayModel.UserAge}. Feeling old yet?")
                    : $"Facts about you:{Environment.NewLine}You haven't cosen any date!";
            }
        }
        internal UserViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
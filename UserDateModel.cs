using System;
using System.Diagnostics;
using System.Windows;

namespace Lapka1
{
    internal class UserDateModel
    {
        private DateTime? _selectedDate;
        public int UserAge { get; private set; }

        public bool IsBirthday => _selectedDate != null && _selectedDate.Value.DayOfYear == DateTime.Today.DayOfYear;

        public DateTime? SelectedDate
        {
            get => _selectedDate ?? /*NANI Operator*/ DateTime.Today;
            set
            {
                _selectedDate = value ?? new DateTime(1970, 1, 2);
                var days = (DateTime.Today - _selectedDate).Value.Days;
                UserAge = days / 365;
                if (days < 0 || UserAge > 135)
                {
                    throw new ArgumentException("Please enter valid date");
                }
            }
        }

//        public 
//
        public string WesetrnZodiac
        {
            get
            {
                SelectedDate = SelectedDate ?? DateTime.Today;
                switch (SelectedDate.Value.Month)
                {
                    case 1 when SelectedDate.Value.Day >= 20:
                    case 2 when SelectedDate.Value.Day <= 18:
                        return "Aquarius";
                    case 2 when SelectedDate.Value.Day >= 19:
                    case 3 when SelectedDate.Value.Day <= 20:
                        return "Pisces";
                    case 3 when SelectedDate.Value.Day >= 21:
                    case 4 when SelectedDate.Value.Day <= 19:
                        return "Aries";
                    case 4 when SelectedDate.Value.Day >= 20:
                    case 5 when SelectedDate.Value.Day <= 20:
                        return "Taurus";
                    case 5 when SelectedDate.Value.Day >= 21:
                    case 6 when SelectedDate.Value.Day <= 20:
                        return "Gemini";
                    case 6 when SelectedDate.Value.Day >= 21:
                    case 7 when SelectedDate.Value.Day <= 22:
                        return "Cancer";
                    case 7 when SelectedDate.Value.Day >= 23:
                    case 8 when SelectedDate.Value.Day <= 22:
                        return "Leo";
                    case 8 when SelectedDate.Value.Day >= 23:
                    case 9 when SelectedDate.Value.Day <= 22:
                        return "Virgo";
                    case 9 when SelectedDate.Value.Day >= 23:
                    case 10 when SelectedDate.Value.Day <= 22:
                        return "Libra";
                    case 10 when SelectedDate.Value.Day >= 23:
                    case 11 when SelectedDate.Value.Day <= 21:
                        return "Scorpio";
                    case 11 when SelectedDate.Value.Day >= 23:
                    case 12 when SelectedDate.Value.Day <= 21:
                        return "Sagittarius";
                    case 12 when SelectedDate.Value.Day >= 22:
                    case 1 when SelectedDate.Value.Day <= 19:
                        return "Capicorn";
                    default:
                        return string.Empty;
                }
            }
        }

        public string ChineseZodiac
        {
            get
            {
                SelectedDate = SelectedDate ?? DateTime.Today;
                switch(SelectedDate.Value.Year % 12) {
                    case 0 when SelectedDate.Value.DayOfYear > 24:
                        return "Monkey";
                    case 1 when SelectedDate.Value.DayOfYear > 24:
                        return "Rooster";
                    case 2 when SelectedDate.Value.DayOfYear > 24:
                        return "Doge";
                    case 3 when SelectedDate.Value.DayOfYear > 24:
                        return "Pig";
                    case 4 when SelectedDate.Value.DayOfYear > 24:
                        return "Rat";
                    case 5 when SelectedDate.Value.DayOfYear > 24:
                        return "Ox";
                    case 6 when SelectedDate.Value.DayOfYear > 24:
                        return "Tiger";
                    case 7 when SelectedDate.Value.DayOfYear > 24:
                        return "Rabbit";
                    case 8 when SelectedDate.Value.DayOfYear > 24:
                        return "Dragon";
                    case 9 when SelectedDate.Value.DayOfYear > 24:
                        return "Snake";
                    case 10 when SelectedDate.Value.DayOfYear > 24:
                        return "Horse";
                    case 11 when SelectedDate.Value.DayOfYear > 24:
                        return "Goat";
                    default:
                        return string.Empty;
                }
            }
        }

        public UserDateModel(DateTime? selectedDate)
        {
            _selectedDate = selectedDate;
        }
    }
}

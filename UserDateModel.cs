using System;
//Not used usings

namespace Lapka1
{
    internal class UserDateModel
    {
        private DateTime _selectedDate;
        internal int UserAge { get; private set; }

        internal bool IsBirthday => _selectedDate.DayOfYear == DateTime.Today.DayOfYear;

        internal DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                _selectedDate = value;
                var days = (DateTime.Today - _selectedDate).Days;
                UserAge = days / 365;
                if (days < 0 || UserAge > 135)
                {
                    throw new ArgumentException("Please enter valid date");
                }
            }
        }

        internal string WesetrnZodiac
        {
            get
            {
                switch (SelectedDate.Month)
                {
                    case 1 when SelectedDate.Day >= 20:
                    case 2 when SelectedDate.Day <= 18:
                        return "Aquarius";
                    case 2 when SelectedDate.Day >= 19:
                    case 3 when SelectedDate.Day <= 20:
                        return "Pisces";
                    case 3 when SelectedDate.Day >= 21:
                    case 4 when SelectedDate.Day <= 19:
                        return "Aries";
                    case 4 when SelectedDate.Day >= 20:
                    case 5 when SelectedDate.Day <= 20:
                        return "Taurus";
                    case 5 when SelectedDate.Day >= 21:
                    case 6 when SelectedDate.Day <= 20:
                        return "Gemini";
                    case 6 when SelectedDate.Day >= 21:
                    case 7 when SelectedDate.Day <= 22:
                        return "Cancer";
                    case 7 when SelectedDate.Day >= 23:
                    case 8 when SelectedDate.Day <= 22:
                        return "Leo";
                    case 8 when SelectedDate.Day >= 23:
                    case 9 when SelectedDate.Day <= 22:
                        return "Virgo";
                    case 9 when SelectedDate.Day >= 23:
                    case 10 when SelectedDate.Day <= 22:
                        return "Libra";
                    case 10 when SelectedDate.Day >= 23:
                    case 11 when SelectedDate.Day <= 21:
                        return "Scorpio";
                    case 11 when SelectedDate.Day >= 23:
                    case 12 when SelectedDate.Day <= 21:
                        return "Sagittarius";
                    case 12 when SelectedDate.Day >= 22:
                    case 1 when SelectedDate.Day <= 19:
                        return "Capicorn";
                    default:
                        return string.Empty;
                }
            }
        }

        internal string ChineseZodiac
        {
            get
            {
                switch(SelectedDate.Year % 12) {
                    case 0 when SelectedDate.DayOfYear > 24:
                        return "Monkey";
                    case 1 when SelectedDate.DayOfYear > 24:
                        return "Rooster";
                    case 2 when SelectedDate.DayOfYear > 24:
                        return "Doge";
                    case 3 when SelectedDate.DayOfYear > 24:
                        return "Pig";
                    case 4 when SelectedDate.DayOfYear > 24:
                        return "Rat";
                    case 5 when SelectedDate.DayOfYear > 24:
                        return "Ox";
                    case 6 when SelectedDate.DayOfYear > 24:
                        return "Tiger";
                    case 7 when SelectedDate.DayOfYear > 24:
                        return "Rabbit";
                    case 8 when SelectedDate.DayOfYear > 24:
                        return "Dragon";
                    case 9 when SelectedDate.DayOfYear > 24:
                        return "Snake";
                    case 10 when SelectedDate.DayOfYear > 24:
                        return "Horse";
                    case 11 when SelectedDate.DayOfYear > 24:
                        return "Goat";
                    default:
                        return string.Empty;
                }
            }
        }

        internal UserDateModel()
        {
        }
    }
}

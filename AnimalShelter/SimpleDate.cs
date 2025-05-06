using System;

namespace AnimalShelter
{
    public class SimpleDate
    {
        public DateTime Date { get; set; }

        public SimpleDate() => Date = DateTime.MinValue;

        public SimpleDate(int day, int month, int year)
        {
            Date = new DateTime(year, month, day);
        }

        public SimpleDate(DateTime dateTime)
        {
            Date = dateTime;
        }

        public int Day => Date.Day;
        public int Month => Date.Month;
        public int Year => Date.Year;

        public static SimpleDate CurrentDate => new SimpleDate(DateTime.Now);

        public string CalculateAge(SimpleDate currentDate)
        {
            int years = currentDate.Year - Year;
            int months = currentDate.Month - Month;
            int days = currentDate.Day - Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(currentDate.Year,
                    currentDate.Month == 1 ? 12 : currentDate.Month - 1);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            return $"{years} years, {months} and {days} days";
        }

        public override string ToString()
        {
            return Date.ToString("dd-MM-yyyy");
        }
    }
}

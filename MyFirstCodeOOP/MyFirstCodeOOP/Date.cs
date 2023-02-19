﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class Date
    {
        public int _year;
        public int _month;
        public int _day;

        #region Constructor
        public Date(int year, int month, int day) //Method Constructor
        {
            #region Propieties
            this._year = year;
            this._month = ValidateMonth(month);
            this._day = ValidateDay(day, month);
            #endregion
        }
        #endregion

        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }

        private int ValidateDay(int day, int month)
        {
            if (month == 2)
            {
                if (day >= 1 && day <= 28)
                {
                    return day;
                }
                throw new DayException("The day is invalid");

            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day >= 1 && day <= 31)
                {
                    return day;
                }

            }
            else
            {
                if (day >= 1 && day <= 30)
                {
                    return day;
                }

            }

            throw new DayException("The day is invalid");

        }

        private int ValidateMonth(int month)
        {
            if (month >=1 && month <= 12)
            {
                return month;
            }
            throw new MonthException("The month is invalid!");

           
        }












    }



}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }
        public bool Isactive { get; set; }

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return string.Format("----EMPLOYEE----\n\t" +
               " Id: {0} \n\t" +
               " First Name: {1} \n\t" +
               " Last Name: {2} \n\t" +
               " Birth Date: {3} \n\t" +
               " Hiring Date: {4} \n\t" +
               " Is Active?: {5}",
               Id,
               FirstName,
               Lastname,
               BirthDate,
               HiringDate,
               Isactive);

            /* ----"Interpolacion"----
             * 
             * return $"-----EMPLOYEE----- \n\t" +
                $"ID: {Id} \n\t" +
                $"First Name: {FirstName} \n\t " +
                $"Last Name:{Lastname} \n\t " +
                $"Birth Date: {BirthDate} \n\t" +
                $" Hiring Date: {HiringDate} \n\t" +
                $" Is Active: {Isactive}";
            */
        }



        #endregion





        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Services
{
    public class Customer
    {
        string _name; // field, alan
        string _surname;

        string _creditCardNo;
        public string CreditCardNo
        {
            get
            {
                // **** **** **** 1234
                return "**** **** **** " + _creditCardNo.Substring(15);
            }
            set
            {
                _creditCardNo = value;
            }
        } // property, özellik

        public bool ErkekMi { get; set; }

        public string Cinsiyet
        {
            get
            {
                //return ErkekMi ? "Erkek" : "Kadın";
                if (ErkekMi)
                    return "Erkek";
                return "Kadın";
            }
        }
        public string TitleNameSurname => ErkekMi ? "Mr " + _name + " " + _surname : "Ms " + _name + " " + _surname;

        public void Setname(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public void Setsurname(string surname)
        {
            _surname = surname;
        }


        public string GetSurname()
        {
            return _surname;
        }

        public void DisplayNameSurnam() // method, behavior, davranış
        {

        }

    }
}

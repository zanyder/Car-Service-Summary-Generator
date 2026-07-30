using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Byfielda
{
    class CarServiceSummary
    {
        // Variables
        private static int Count = 0;
        private readonly int IdentificationNumber;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _Make;
        private string _Model;
        private string _Year;
        private string _Colour;
        private bool _EngOilChange;
        private bool _TransOilChange;
        private bool _AirFilterChange;
        private decimal _Price;

        // ACCESSORS/MUTATORS
        #region
        public int ID
        {
            get { return IdentificationNumber; }
            
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Phone
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Make
        {
            get { return _Make; }
            set { _Make = value; }
        }

        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public string Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        public string Colour
        {
            get { return _Colour; }
            set { _Colour = value; }
        }

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public bool EngOilChange
        {
            get { return _EngOilChange; }
            set { _EngOilChange = value;}
        }

        public bool TransOilChange
        {
            get {  return _TransOilChange; }
            set { _TransOilChange = value;}
        }

        public bool AirFilterChange
        {
            get { return _AirFilterChange; }
            set { _AirFilterChange = value;}
        }
        #endregion

        // METHODS
        static void IncrementServiceCount()
        {
            Count++;
        }
        public string GetServiceData()
        {
            string summaryDetails = "";
             
            return summaryDetails;
        }

        
        // CONSTRUCTORS
        public CarServiceSummary()
        {
            IncrementServiceCount();
            IdentificationNumber = Count;
        }
        public CarServiceSummary(string firstName, string lastName, string phone,
            string make, string model, string year, string colour, decimal cost
            , bool engOilChange, bool transOilChange, bool airFilterChange)
            : this()
        {
            
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
            Price = cost;
            EngOilChange = engOilChange;
            TransOilChange = transOilChange;
            AirFilterChange = airFilterChange;
        }

        /*public carServiceSummary(carServiceSummary summary)
        {
            FirstName=summary.FirstName;
            LastName=summary.LastName;
            Phone=summary.Phone;
            Make=summary.Make;
            Model=summary.Model;
            Year=summary.Year;
            Colour = summary.Colour;
            Price = summary.Price;
            EngOilChange=summary.EngOilChange;
            TransOilChange=summary.TransOilChange;
            AirFilterChange=summary.AirFilterChange;
        }*/
    }


}

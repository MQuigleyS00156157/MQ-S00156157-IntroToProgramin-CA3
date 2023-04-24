using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_IntroPrograming_MQs00156157
{
    internal class Passanger
    {
        private string FirstName;
        private string LastName;
        private int _Age;
        private string _Gender;
        private string OccupationCode;
        private string NativeCountryCode;
        private string _Destination;
        private string DepartionPortCode;
        private string ManifestIDCode;
        private string _ArrivalDate;

        public string FName
        
             {
                get { return FirstName; }
                set { FirstName = value; }
            }
        
        public string LName
        {
            get { return LastName; }
            set { LastName = value; }
        }
            
          public int Age
        {
            get { return _Age; }
            set { _Age = value; }

        }

        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }

        }

        public string Occupation
        {
            get { return OccupationCode; }
            set { OccupationCode = value; }

        }

        public string NativeCountry
        {
            get { return NativeCountryCode; }
            set { NativeCountryCode = value; }
        }

        public string Destination
        {
            get { return _Destination; }
            set { _Destination = value; }
        }

        public string DepartionPort
        {
            get { return DepartionPortCode; }
            set{ DepartionPortCode = value; }
        }

        public string Manifest
        {
            get { return ManifestIDCode; }
            set { ManifestIDCode = value; }
        }

        public string ArrivalDate
        {
            get { return _ArrivalDate; }
            set { _ArrivalDate = value; }
        }

        public Passanger(string fn, string ln, int a, string g, string oc, string ncc, string d, string dpc, string mIDc, string ad)
        {
            FirstName = fn;
            LastName = ln;
            Age = a;
            Gender = g;
            OccupationCode = oc;
            NativeCountryCode = ncc;
            Destination = d;
            DepartionPortCode = dpc;
            ManifestIDCode = mIDc;
            ArrivalDate = ad;
        }
        public override string ToString() 
        {
            return "FirstName " + FirstName + "LastName " + LastName + "Age " + Age + "Gender " + Gender +"Occupation " + OccupationCode + "NativeCountry " + NativeCountryCode + "Destination " + Destination + "DepartaionPortCode " + DepartionPortCode + "ManifestIDCode " +ManifestIDCode + "ArrivaleDate" + ArrivalDate;
        }
       

    }
}

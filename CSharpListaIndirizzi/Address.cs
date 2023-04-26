using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressClass
{
    public class Address
    {
        //ATTRIBUTES

        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;

        //CONTRUCTORS
        public string dateAddress(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }


        //METHODS
        public override string ToString()
        {
            return "\n\nNome: " + this.name
                 + "\nCognome: " + this.surname
                 + "\nVia: " + this.street
                 + "\nCittà: " + this.city
                 + "\nProvincia: " + this.province
                 + "\nZIP: " + this.zip;
        }


    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Address
    {
        public string Name { get; set; }
        public string Last { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }

        public Address(string name, string last, string street, string city, string province, string zip)
        {
            if(name != null)
                Name = name;
            else
                throw new ArgumentNullException(nameof(name));

            if(last != null)
                Last = last;
            else 
                throw new ArgumentNullException(nameof(last));

            if(street != null)
                Street = street;
            else
                throw new ArgumentNullException(nameof(street));

            if(city != null)
                City = city;
            else 
                throw new ArgumentNullException(nameof(city));

            if(province != null)
                Province = province;
            else 
                throw new ArgumentNullException(nameof(province));

            if(zip != null)
                Zip = zip;
            else 
                throw new ArgumentNullException(nameof(zip));

        }
    }
}

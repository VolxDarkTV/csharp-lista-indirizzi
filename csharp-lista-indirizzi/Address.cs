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
            if(!string.IsNullOrEmpty(name))
                Name = name;
            else
                throw new ArgumentNullException(nameof(name));
            
            if (!string.IsNullOrEmpty(last))
                Last = last;
            else 
                throw new ArgumentNullException(nameof(last));

            if(!string.IsNullOrEmpty(street))
                Street = street;
            else
                throw new ArgumentNullException(nameof(street));

            if(!string.IsNullOrEmpty(city))
                City = city;
            else 
                throw new ArgumentNullException(nameof(city));

            if(!string.IsNullOrEmpty(province))
                Province = province;
            else 
                throw new ArgumentNullException(nameof(province));

            if(!string.IsNullOrEmpty(zip))
                Zip = zip;
            else 
                throw new ArgumentNullException(nameof(zip));

        }
    }
}

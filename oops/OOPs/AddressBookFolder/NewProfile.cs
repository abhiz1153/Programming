using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AddressBookFolder
{
    class NewProfile
    {

        private List<AddressClass> profilelist = new List<AddressClass>();

        public List<AddressClass> ProfileList
        {
            get { return this.profilelist; }
            set { this.profilelist = value; }
        }
    }
}

using System;
using System.Collections.Generic;

namespace exceptions {
    class AddressBook {
        public Dictionary<int, Contact> ContactList = new Dictionary<int, Contact> ();

        public void AddContact (Contact contact) {
            int count = ContactList.Count;
            if(!ContactList.ContainsValue(contact))
            {
                ContactList.Add (count, contact);
            }
            if (ContactList.Count == ContactList.Count) {
                count++;
            }
        }

        public Contact GetByEmail (string email) {
            foreach (var contact in ContactList.Values) {

                if (ContactList.ContainsValue (contact)) {
                    if (contact.Email == email) {
                        return contact;
                    }
                }
            }
            return null;
        }
    }
}
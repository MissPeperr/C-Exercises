using System;
using System.Collections.Generic;

namespace exceptions {
    class AddressBook {

        // created a dictionary that contains all contacts
            // each contact has an ID
        public Dictionary<int, Contact> ContactList = new Dictionary<int, Contact> ();

        // a method to add contacts to the ContactList Dictionary
        public void AddContact (Contact contact) {
            // a counter that is set to the length of the ContactList
            int count = ContactList.Count;
            /*
                if the ContactList does NOT have the contact
                   => add the contact to ContactList
            */
            if(!ContactList.ContainsValue(contact))
            {
                ContactList.Add (count, contact);
            }
            /*
                 if the current ContactList length is equal to the current ContactList length 
                 => add 1 to the ContactList length
            */
            if (ContactList.Count == ContactList.Count) {
                count++;
            }
        }

        // a method to search the ContactList by email
        public Contact GetByEmail (string email) {
            // loop over the contacts in ContactList
            foreach (var contact in ContactList.Values) {

                /*
                    if the ContactList contains the value of the current contact
                        => if the current contact.Email == the email
                            => return the whole contact
                */
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
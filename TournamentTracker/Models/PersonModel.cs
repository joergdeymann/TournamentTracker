﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNumber { get; set; }

        public string Fullname
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

        }

        public PersonModel()
        {

        }
        public PersonModel(string firstName, string lastName, string emailAddress, string cellphoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellPhoneNumber = cellphoneNumber;
        }

    }
}


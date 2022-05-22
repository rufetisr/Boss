using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossProg
{
    class Employer
    {
        public Employer(int id, string name, string surname, string username, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }

        public Employer()
        {

        }

        public Employer(int id, string name, string surname, string sheher, string phone, short age, string company, List<string> vacancies)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Sheher = sheher;
            Phone = phone;
            Age = age;
            Company = company;
            Vacancies = vacancies;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sheher { get; set; }
        public string Phone { get; set; }
        public short Age { get; set; }
        public string Company { get; set; }
        public List<string> Vacancies { get; set; }


    }
}



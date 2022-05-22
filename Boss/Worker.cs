using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossProg
{
    class Worker
    {
        public Worker()
        {

        }
        public Worker(int id, string name, string surname, string username, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }

        public Worker(int id, string name, string surname, string sheher, string phone, short age, CV cV)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Sheher = sheher;
            Phone = phone;
            Age = age;
            CV = cV;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sheher { get; set; }
        public string Phone { get; set; }
        public short Age { get; set; }
        public CV CV { get; set; }

        public override string ToString()
        {
            return $"\t\t--CV--\nName: {Name}\nSurname: {Surname}\nSeher: {Sheher}\nPhone: {Phone}\nAge: {Age}" + "\n" + CV.ToString();
        }
    }
}



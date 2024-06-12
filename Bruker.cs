using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class Bruker
    {
        public string _name;
        private int _age;
        private string _email;
        private string _hobby;

        private List<Bruker> _friends;


        public Bruker(string Name, int Age, string Email, string Hobby)
        {
            _name = Name;
            _age = Age;
            _email = Email;
            _hobby = Hobby;
            _friends = new List<Bruker>();
        }


        public void PrintUserInfo()
        {
        
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"Age {_age}");
                Console.WriteLine($"Email {_email}");
                Console.WriteLine($"Hobby {_hobby}");

        }

        public void AddFriend(Bruker bruker)
        {
            _friends.Add(bruker);
        }

        public void Showallfriends()
        {
            foreach (var bruker in _friends)
            {
                bruker.PrintUserInfo();
            }
        }



    }
}

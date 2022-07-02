using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Var11.Data
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string Login { get; set; }
        [BsonElement]
        public string Email { get; set; }
        public static List<User> Users = new List<User>();

        public User(string name, string login, string email)
        {
            Name = name;
            Login = login;
            Email = email;
        }

        public static void SaveUser(string name, string login, string email)
        {
            if (Checking(email))
            {
                User us = new User(name, login, email);
                Users.Add(us);
                MongoClient client = new MongoClient();
                var db = client.GetDatabase("PrepProg");
                var collection = db.GetCollection<User>("users");
                collection.InsertOne(us);
            }
            else
            {
                Console.WriteLine("Такой пользователь уже существует");
            }
            
        }
        public static List<User> GetUsers()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("PrepProg");
            var collection = db.GetCollection<User>("users");
            Users = collection.Find(x => true).ToList();
            return Users;
        }
        public static bool Checking(string email)
        {
            foreach(var item in GetUsers())
            {
                if(email == item.Email)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            return true;
        }
    }
    
}

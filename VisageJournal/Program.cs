﻿using DAL.Beton;
using DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json").Build();
string connectionString = config.GetConnectionString("VisageJournal");

IMongoClient client = new MongoClient(connectionString);

IMongoDatabase db = client.GetDatabase("test");

var collection = db.GetCollection<BsonDocument>("Users");

UserDAL dal = new UserDAL(collection);


//User user = new User
//{
//    FirstName = "Pasha",
//    LastName = "Ahsap",
//    Email = "email@gmail.com",
//    Password = "password",
//    UserName = "Mitsu",
//    Interests = new BsonArray
//    {
//        {"Hacking"},
//        {"Jogging" },
//        {"Joking" },
//        {"Running" }
//    }
//};
//dal.Add(user);

Console.WriteLine(dal.GetByID(2));

//var somethign = new BsonDocument
//{
//    {
//        "_id","2"
//    },
//    {
//        "nothign","nothing"
//    }
//};

//collection.InsertOne(somethign);
//Console.WriteLine("Connected successfully!");
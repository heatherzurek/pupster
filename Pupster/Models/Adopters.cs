
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Pupster;

namespace Pupster.Models
{
  public class Result
  {
    public int Id {get; set;}
    public int AdopterId {get; set;}
    public int DogId {get; set;}

    public Result (int adopterId, int dogId, int id = 0)
    {
      AdopterId = adopterId;
      DogId = dogId;
      Id = id;
    }

    public int Loop(string question1, string question2, string question3, bool question4, bool question5, bool question6, bool question7, bool question8, int id)
    {
      List<Dog> allDogs = new List<Dog> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM dogs;";
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      int score = 0;
      while(rdr.Read())
      {
        int dogId = rdr.GetInt32(0);
        string dogName = rdr.GetString(1);
        string dogImage = rdr.GetString(2);
        string sex = rdr.GetString(3);
        string breed = rdr.GetString(4);
        string color = rdr.GetString(5);
        string size = rdr.GetString(6);
        string age = rdr.GetString(7);
        bool neuteredSpayed = rdr.GetBoolean(8);
        bool shots = rdr.GetBoolean(9);
        string activity = rdr.GetString(10);
        bool goodWithDogs = rdr.GetBoolean(11);
        bool goodWithCats = rdr.GetBoolean(12);
        bool goodWithKids = rdr.GetBoolean(13);
        bool houseTrained = rdr.GetBoolean(14);
        bool goodAlone = rdr.GetBoolean(15);
        string needsDescription = rdr.GetString(16);
        Dog newDog = new Dog(dogName, dogImage, sex, breed, color, size, age, neuteredSpayed, shots, activity, goodWithDogs, goodWithCats, goodWithKids, houseTrained, goodAlone, needsDescription, id);


        Console.WriteLine(question2);
        Console.WriteLine(age);
        //this is grabbing the values from the database and looping through each dog as expected. we just need to figure out the forloop logic. and how to push it into arrays.
        if (age == question1)
        {
          score +=1;
        }
        if (sex == question2)
        {
          score +=1;
        }
        if (size == question3)
        {
          score +=1;
        }
        if (goodWithKids == question4)
        {
          score +=1;
        }
        if (goodWithCats == question5)
        {
          score +=1;
        }
        if (goodWithDogs == question6)
        {
          score +=1;
        }
        if (houseTrained == question7)
        {
          score +=1;
        }
        if (goodAlone == question8)
        {
          score +=1;
        }

      }


      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }

      Console.WriteLine(score);
      return score;
    }

}
}

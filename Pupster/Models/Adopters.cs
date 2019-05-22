
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Pupster;

namespace Pupster.Models
{
  public class Adopter
  {
    public int Id {get; set;}

    public Adopter (int adopterId = 0)
    {
      Id = adopterId;
    }

    public void Result(string question1, string question2, string question3, bool question4, bool question5, bool question6, bool question7, bool question8)
    {
      List<Dog> allDogs = Dog.GetAll();
      List<int> model = new List<int>{};
      // int score = 0;
      foreach (Dog dog in allDogs)
      {
        int score = 0;
        int dogId = dog.Id;
        int adopterId = Id;
        score = dog.Score(question1, question2, question3, question4, question5, question6, question7, question8, adopterId);
        MySqlConnection conn = DB.Connection();
        conn.Open();
        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"INSERT INTO dog_score (dog_id, score) VALUES (@dogId, @score);";
        cmd.Parameters.AddWithValue("@dogId", dogId);
        cmd.Parameters.AddWithValue("@score", score);
        var rdr = cmd.ExecuteReader() as MySqlDataReader;
        conn.Close();

        if (conn != null)
        {
          conn.Dispose();
        }
      }

    }

    public static List<Dog> GetSortedResults()
    {

      List<Dog> dogInfo = new List<Dog> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT dogs.* FROM dog_score JOIN dogs ON (dog_score.dog_id = dogs.id) ORDER BY dog_score.score DESC;";
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int id = rdr.GetInt32(0);
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
        dogInfo.Add(newDog);
      }
      return dogInfo;
    }


    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM dog_score;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }


  }
}

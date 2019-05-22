
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

    public static List<int> GetSortedResults()
    {
      List<int> allSortedIds = new List<int> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT dog_id FROM dog_score ORDER BY score DESC;";
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int dogId= rdr.GetInt32(1);
        allSortedIds.Add(dogId);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allSortedIds;
    }




    // public static List<Adopter> GetAllResults()
    // {
    //   List<Adopter> allSortedAdopters = new List<Adopter> {};
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   var cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM dog_score SORT BY score DESC;";
    //   var rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   while(rdr.Read())
    //   {
    //     int id = rdr.GetInt32(0);
    //     int dogId= rdr.GetInt32(1);
    //     int score = rdr.GetInt32(2);
    //
    //     Dog newAdopter = new Adopter(dogId, score, id);
    //     allSortedAdopters.Add(newAdopter);
    //   }
    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    //   return allSortedAdopters;
    // }

    // public void SortResults()
    // {
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   var cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM dog_score ORDER BY score DESC;";
    //   conn.Close();
    //   Console.WriteLine("test");
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    // }


  }
}

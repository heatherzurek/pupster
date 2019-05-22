
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
      }
      //
      // return score;
    }


  // public int Score(string question1, string question2, string question3, bool question4, bool question5, bool question6, bool question7, bool question8, int id)
  // {
  //   int score = 0;
  //   if (age == question1)
  //   {
  //     score +=1;
  //   }
  //   if (sex == question2)
  //   {
  //     score +=1;
  //   }
  //   if (size == question3)
  //   {
  //     score +=1;
  //   }
  //   if (goodWithKids == question4)
  //   {
  //     score +=1;
  //   }
  //   if (goodWithCats == question5)
  //   {
  //     score +=1;
  //   }
  //   if (goodWithDogs == question6)
  //   {
  //     score +=1;
  //   }
  //   if (houseTrained == question7)
  //   {
  //     score +=1;
  //   }
  //   if (goodAlone == question8)
  //   {
  //     score +=1;
  //   }
  //   return score;
  // }

}
}

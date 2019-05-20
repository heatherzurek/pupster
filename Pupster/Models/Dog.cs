using System;
using MySql.Data.MySqlClient;
using Pupster;

namespace Pupster.Models
{
  public class Dog
  {
    public int Id {get; set;}

    public string DogScore(string activityAnswer, )
    {
      foreach(var dog in Pupster)
      {
        int score = 0;

        if(@SELECT activity_level FROM dogs CONTAINS %@activityAnswer%)
        {
          score += 5;
        }
        return "@dogName + score"
      }
    }
  }
}

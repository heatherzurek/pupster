using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Pupster;

namespace Pupster.Models
{
  public class Adopter
  {
    private string _name;
    private int _id;

    public Adopter(string name, int id = 0 )
    {
      _name = name;
      _id = id;
    }

    public string GetName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Adopter> GetAll()
      {
        List<Adopter> allAdopters = new List<Adopter> {};
        MySqlConnection conn = DB.Connection();
        conn.Open();
        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM adopters;";
        var rdr = cmd.ExecuteReader() as MySqlDataReader;
        while(rdr.Read())
        {
          string adopterName = rdr.GetString(0);
          int adopterId = rdr.GetInt32(1);
          Adopter newAdopter = new Adopter(adopterName, adopterId);
          allAdopters.Add(newAdopter);
        }
        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
        return allAdopters;
      }

    // public static List<Dog> GetAll()
    // {
    //   List<Dog> allDogs = new List<Dog> {};
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   var cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM dogs;";
    //   var rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   while(rdr.Read())
    //   {
    //     int Id = rdr.GetInt32(0);
    //     string dogName = rdr.GetString(1);
    //     image recipeRating = rdr.GetBlob(2);
    //     string dogSex = rdr.GetString(3);
    //     string dogBreed = rdr.GetString(4);
    //     string dogColor = rdr.GetString(5);
    //     string dogSize = rdr.GetString(6);
    //     string dogAge = rdr.GetString(7);
    //     int neuteredSpayed = rdr.GetInt32(8);
    //     int shots = rdr.GetInt32(9);
    //     string dogActivity = rdr.GetString(10);
    //     int goodWithDogs = rdr.GetInt32(11);
    //     int goodWithCats = rdr.GetInt32(12);
    //     int goodWithKids = rdr.GetInt32(13);
    //     int houseTrained = rdr.GetInt32(14);
    //   }
    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    //   return allDogs;
    // }
    //
    // public static List<Dog> GetDetails()
    // {
    //   List<Dog> allDogs = new List<Dog> {};
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   var cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM dogs;";
    //   var rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   while(rdr.Read())
    //   {
    //     int Id = rdr.GetInt32(0);
    //     string dogSex = rdr.GetString(3);
    //     string dogSize = rdr.GetString(6);
    //     string dogAge = rdr.GetString(7);
    //     string dogActivity = rdr.GetString(10);
    //     int goodWithDogs = rdr.GetInt32(11);
    //     int goodWithCats = rdr.GetInt32(12);
    //     int goodWithKids = rdr.GetInt32(13);
    //     int houseTrained = rdr.GetInt32(14);
    //     int goodAlone = rdr.GetInt32(15);
    //     int needsDescription = rdr.GetInt32(16);
    //   }
    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    //   return allDogs;
    // }



  }
}
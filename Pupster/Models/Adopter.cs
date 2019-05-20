using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Pupster;

namespace Pupster.Models
{
  public class Adopter
  {
    public int Id {get; set;}

    // arr [rdr.GetString(3), rdr.GetString(6), rdr.GetString(7), rdr.GetString(10), rdr.GetBool(11), rdr.GetBool(12), rdr.GetBool(13), rdr.GetBool(14)];

    // public static Dog DogMatchScore(string sex, string size, string age, string activity_level, bool good_with_dogs, bool good_with_cats, bool good_with_kids, bool good_alone, bool house_trained)
    // {
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   var cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM recipes WHERE ingredients LIKE (@searchedIngredient);";
    //   cmd.Parameters.AddWithValue("@searchedIngredient", "%" + searchedIngredient + "%");
    //   // MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   var rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   int recipeId = 0;
    //   string recipeName = "";
    //   int recipeRating = 0;
    //   string recipeIngredients = "";
    //   string recipeInstructions = "";
    //   while(rdr.Read())
    //   {
    //     recipeId = rdr.GetInt32(0);
    //     recipeName = rdr.GetString(1);
    //     recipeRating = rdr.GetInt32(2);
    //     recipeIngredients = rdr.GetString(3);
    //     recipeInstructions = rdr.GetString(4);
    //   }
    //   Recipe newRecipe = new Recipe(recipeName, recipeRating, recipeIngredients, recipeInstructions, recipeId);
    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    //   return newRecipe;
    // }
    //
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

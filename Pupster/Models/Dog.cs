
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Pupster;

namespace Pupster.Models
{
  public class Dog
  {
    public int Id {get; set;}
    public string Name {get; set;}
    public string Photo {get; set;}
    public string Sex {get; set;}
    public string Breed {get; set;}
    public string Color {get; set;}
    public string Size {get; set;}
    public string Age {get; set;}
    public bool NeuteredSpayed {get; set;}
    public bool Shots {get; set;}
    public string Activity {get; set;}
    public bool GoodWithDogs {get; set;}
    public bool GoodWithCats {get; set;}
    public bool GoodWithKids {get; set;}
    public bool HouseTrained {get; set;}
    public bool GoodAlone {get; set;}
    public string NeedsDescription {get; set;}

    public Dog (string name, string photo, string sex, string breed, string color, string size, string age, bool neuteredSpayed, bool shots, string activity, bool goodWithDogs, bool goodWithCats, bool goodWithKids, bool houseTrained, bool goodAlone, string needsDescription, int id = 0)
    {
      Name = name;
      Photo = photo;
      Sex = sex;
      Breed = breed;
      Color = color;
      Size = size;
      Age = age;
      NeuteredSpayed = neuteredSpayed;
      Shots = shots;
      Activity = activity;
      GoodWithDogs = goodWithDogs;
      GoodWithCats = goodWithCats;
      GoodWithKids = goodWithKids;
      HouseTrained = houseTrained;
      GoodAlone = goodAlone;
      NeedsDescription = needsDescription;
      Id = id;
    }

    public override bool Equals(System.Object otherDog)
    {
      if (!(otherDog is Dog))
      {
        return false;
      }
      else
      {
        Dog newDog = (Dog) otherDog;
        bool idEquality = this.Id.Equals(newDog.Id);
        bool NameEquality = this.Name.Equals(newDog.Name);
        bool PhotoEquality = this.Photo.Equals(newDog.Photo);
        bool SexEquality = this.Sex.Equals(newDog.Sex);
        bool BreedEquality = this.Breed.Equals(newDog.Breed);
        bool ColorEquality = this.Color.Equals(newDog.Color);
        bool SizeEquality = this.Size.Equals(newDog.Size);
        bool AgeEquality = this.Age.Equals(newDog.Age);
        bool NeuteredSpayedEquality = this.NeuteredSpayed.Equals(newDog.NeuteredSpayed);
        bool ShotsEquality = this.Shots.Equals(newDog.Shots);
        bool ActivityEquality = this.Activity.Equals(newDog.Activity);
        bool GoodWithDogsEquality = this.GoodWithDogs.Equals(newDog.GoodWithDogs);
        bool GoodWithCatsEquality = this.GoodWithCats.Equals(newDog.GoodWithCats);
        bool GoodWithKidsEquality = this.GoodWithKids.Equals(newDog.GoodWithKids);
        bool HouseTrainedEquality = this.HouseTrained.Equals(newDog.HouseTrained);
        bool GoodAloneEquality = this.GoodAlone.Equals(newDog.GoodAlone);
        bool NeedsDescriptionEquality = this.NeedsDescription.Equals(newDog.NeedsDescription);
        return (idEquality && NameEquality && PhotoEquality && SexEquality && BreedEquality && ColorEquality && SizeEquality && AgeEquality && NeuteredSpayedEquality && ShotsEquality && ActivityEquality && GoodWithDogsEquality && GoodWithCatsEquality && GoodWithKidsEquality && HouseTrainedEquality && GoodAloneEquality && NeedsDescriptionEquality);
      }
    }

    public override int GetHashCode()
    {
      return this.Id.GetHashCode();
    }


    public static List<Dog> GetAll()
    {
      List<Dog> allDogs = new List<Dog> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM dogs;";
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

      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allDogs;
    }

    public static Dog Find(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM dogs WHERE id = (@searchId);";
      MySqlParameter searchId = new MySqlParameter();
      searchId.ParameterName = "@searchId";
      searchId.Value = id;
      cmd.Parameters.Add(searchId);
      // cmd.Parameters.AddWithValue("@searchId", searchId);
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      int dogId = 0;
      string dogName = "";
      string dogPhoto = "";
      string dogSex = "";
      string dogBreed = "";
      string dogColor = "";
      string dogSize = "";
      string dogAge = "";
      bool neuteredSpayed = false;
      bool shots = false;
      string dogActivity = "";
      bool goodWithDogs = false;
      bool goodWithCats = false;
      bool goodWithKids = false;
      bool houseTrained = false;
      bool goodAlone = false;
      string needsDescription = "";
      while(rdr.Read())
      {
        dogId = rdr.GetInt32(0);
        dogName = rdr.GetString(1);
        dogPhoto = rdr.GetString(2);
        dogSex = rdr.GetString(3);
        dogBreed = rdr.GetString(4);
        dogColor = rdr.GetString(5);
        dogSize = rdr.GetString(6);
        dogAge = rdr.GetString(7);
        neuteredSpayed = rdr.GetBoolean(8);
        shots = rdr.GetBoolean(9);
        dogActivity = rdr.GetString(10);
        goodWithDogs = rdr.GetBoolean(11);
        goodWithCats = rdr.GetBoolean(12);
        goodWithKids = rdr.GetBoolean(13);
        houseTrained = rdr.GetBoolean(14);
        goodAlone = rdr.GetBoolean(15);
        needsDescription = rdr.GetString(16);
      }

      Dog foundDog = new Dog(dogName, dogPhoto, dogSex, dogBreed, dogColor, dogSize, dogAge, neuteredSpayed, shots, dogActivity, goodWithDogs, goodWithCats, goodWithKids, houseTrained, goodAlone, needsDescription, dogId);
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return foundDog;
    }



    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO dogs (name, photo, sex, breed, color, size, age, neutered_spayed, shots_up_to_date, activity_level, good_with_dogs, good_with_cats, good_with_kids, house_trained, good_alone, needs_description) VALUES (@name, @photo, @sex, @breed, @color, @size, @age, @neuteredSpayed, @shots, @activity, @goodWithDogs, @goodWithCats, @goodWithKids, @houseTrained, @goodAlone, @needsDescription);";
      cmd.Parameters.AddWithValue("@name", Name);
      cmd.Parameters.AddWithValue("@photo", Photo);
      cmd.Parameters.AddWithValue("@sex", Sex);
      cmd.Parameters.AddWithValue("@breed", Breed);
      cmd.Parameters.AddWithValue("@color", Color);
      cmd.Parameters.AddWithValue("@size", Size);
      cmd.Parameters.AddWithValue("@age", Age);
      cmd.Parameters.AddWithValue("@neuteredSpayed", NeuteredSpayed);
      cmd.Parameters.AddWithValue("@shots", Shots);
      cmd.Parameters.AddWithValue("@activity", Activity);
      cmd.Parameters.AddWithValue("@goodWithDogs", GoodWithDogs);
      cmd.Parameters.AddWithValue("@goodWithCats", GoodWithCats);
      cmd.Parameters.AddWithValue("@goodWithKids", GoodWithKids);
      cmd.Parameters.AddWithValue("@houseTrained", HouseTrained);
      cmd.Parameters.AddWithValue("@goodAlone", GoodAlone);
      cmd.Parameters.AddWithValue("@needsDescription", NeedsDescription);
      cmd.ExecuteNonQuery();
      Id = (int) cmd.LastInsertedId;
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public void DeleteDog(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM dogs WHERE id = @thisId;";
      cmd.Parameters.AddWithValue("@thisId", Id);
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public void Edit(string name, string photo, string sex, string breed, string color, string size, string age, bool neuteredSpayed, bool shots, string activity, bool goodWithDogs, bool goodWithCats, bool goodWithKids, bool houseTrained, bool goodAlone, string needsDescription, int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"UPDATE dogs SET (name = @name, photo = @photo, sex = @sex, breed = @breed, color = @color, size = @size, age = @age, neuteredSpayed = @neuteredSpayed, shots = @shots, activity = @activity, goodWithDogs = @goodWithDogs, goodWithCats = @goodWithCats, goodWithKids = @goodWithKids, houseTrained = @houseTrained, goodAlone = @goodAlone, needsDescription = @needsDescription) WHERE id = @searchId);";
      cmd.Parameters.AddWithValue("@searchId", id);
      cmd.Parameters.AddWithValue("@name", name);
      cmd.Parameters.AddWithValue("@photo", photo);
      cmd.Parameters.AddWithValue("@sex", sex);
      cmd.Parameters.AddWithValue("@breed", breed);
      cmd.Parameters.AddWithValue("@color", color);
      cmd.Parameters.AddWithValue("@size", size);
      cmd.Parameters.AddWithValue("@age", age);
      cmd.Parameters.AddWithValue("@neuteredSpayed", neuteredSpayed);
      cmd.Parameters.AddWithValue("@shots", shots);
      cmd.Parameters.AddWithValue("@activity", activity);
      cmd.Parameters.AddWithValue("@goodWithDogs", goodWithDogs);
      cmd.Parameters.AddWithValue("@goodWithCats", goodWithCats);
      cmd.Parameters.AddWithValue("@goodWithKids", goodWithKids);
      cmd.Parameters.AddWithValue("@houseTrained", houseTrained);
      cmd.Parameters.AddWithValue("@goodAlone", goodAlone);
      cmd.Parameters.AddWithValue("@needsDescription", needsDescription);
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM dogs;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }


  }
}

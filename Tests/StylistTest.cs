using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Salon
{
  public class StylistTest : IDisposable
  {
    public StylistTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
    }
    public void Dispose()
    {
      Stylist.DeleteAll();
    }

    [Fact]
    public void T1_DBEmptyAtFirst()
    {
      int result = Stylist.GetAll().Count;

      Assert.Equal(0, result);
    }

    [Fact]
    public void T2_Equal_ReturnsTrueIfStylistIsSame()
    {
      Stylist firstStylist = new Stylist("Clementine", "Clips", "L.4 Specialist");
      Stylist secondStylist = new Stylist("Clementine", "Clips", "L.4 Specialist");

      Assert.Equal(firstStylist, secondStylist);
    }

    [Fact]
    public void T3_Save_SavesToDB()
    {
      Stylist testStylist = new Stylist("Clementine", "Clips", "L.4 Specialist");
      testStylist.Save();

      List<Stylist> result = Stylist.GetAll();
      List<Stylist> testList = new List<Stylist>{testStylist};

      Assert.Equal(testList, result);
    }

    [Fact]
    public void T4_1_Save_AssignsIdToStylist()
    {
      Stylist testStylist = new Stylist("Clementine", "Clips", "L.4 Specialist");
      testStylist.Save();

      Stylist savedStylist = Stylist.GetAll()[0];
      int result = savedStylist.GetId();
      int testId = testStylist.GetId();

      Assert.Equal(testId, result);
    }

    [Fact]
    //Additional test for GetId as it was built and passed the test from the outset
    public void T4_2_Save_AssignsIdToStylist()
    {
      Stylist testStylist = new Stylist("Clementine", "Clips", "L.4 Specialist");
      testStylist.Save();

      Stylist savedStylist = Stylist.GetAll()[0];
      int result = savedStylist.GetId();

      Assert.Equal(true, (result > 0));
    }

    [Fact]
    public void T5_Find_FindsStylistInDB()
    {
      Stylist testStylist = new Stylist("Clementine", "Clips", "L.4 Specialist");
      testStylist.Save();

      Stylist foundStylist = Stylist.Find(testStylist.GetId());

      Assert.Equal(testStylist, foundStylist);
    }

    [Fact]
    public void T6_Update_UpdatesStylistInDB()
    {
      string firstName = "Jake";
      string lastName = "Shears";
      string expertise = "Lvl. 5 Master";

      Stylist testStylist = new Stylist(firstName, lastName, expertise);
      testStylist.Save();

      string newFirstName = "Yakul";
      string newLastName = "Scizor";
      string newExpertise = "Lvl. 15 Grand Master";

      testStylist.Update(newFirstName, newLastName, newExpertise);

      string resultFirst = testStylist.GetFirstName();
      string resultLast = testStylist.GetLastName();
      string resultExpertise = testStylist.GetExpertise();

      Assert.Equal(newFirstName, resultFirst);
      Assert.Equal(newLastName, resultLast);
      Assert.Equal(newExpertise, resultExpertise);
    }
  }
}

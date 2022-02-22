using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

namespace Allergies.TestTools
{
  [TestClass]
  public class ClassNameTests
  {
    AllergyChecker testAllergy = new AllergyChecker();

    [TestMethod]
    public void AllergyChecker_AllergicToEggs_Eggs()
    {
      Assert.AreEqual("Egg", testAllergy.AllergyCheck(1));
    }

    [TestMethod]
    public void AllergyChecker_AllergicToStrawberriesEggs_StrawberriesEggs()
    {
      Assert.AreEqual("Strawberries, Egg", testAllergy.AllergyCheck(9));
    }

    [TestMethod]
    public void AllergyChecker_AllergicToAll_All()
    {
      Assert.AreEqual("Cats, Pollen, Chocolate, Tomatoes, Strawberries, Shellfish, Peanuts, Egg", testAllergy.AllergyCheck(255));
    }
  }
}

// https://medium.com/@LindaVivah/learn-how-to-read-binary-in-5-minutes-dac1feb991e

// 142.88.42.212
// 255.255.255.255
// ipconfig


// 1      1    1     0   1  1  0  1  =237
// 128  64  32  16  8  4  2  1 

// 1+ 4 + 8 + 32 + 64 + 128

// 1  0  1  1 = 11
// 8  4  2  1

// 1 + 2 + 8

// 22
// 16 8  4  2  1
// 1  0  1  1  0


// 9
// 8  4  2  1
// 1  0  0  1

// 15
// 16 8  4  2  1
//  0 1  1  1  1


// 1300
// 2048  1024  512  256  128   64  32  16  8  4  2  1
// cats 

// 0       1     



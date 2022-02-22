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
      Assert.AreEqual("eggs", testAllergy.AllergyCheck(1));
    }
  }
}






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


// 1300
// 2048  1024  512  256  128   64  32  16  8  4  2  1
// cats 

// 0       1     



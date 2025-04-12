using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int> {

            {"Apple", 3 },
            {"Kiwi", 2 },
            {"Pineapple", 1 }
        
        };
        
        //Act
        int result = Fruits.GetFruitQuantity(fruits, "Kiwi");
        

        //Assert
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int> {

            {"Apple", 3 },
            {"Kiwi", 2 },
            {"Pineapple", 1 }

        };

        //Act
        int result = Fruits.GetFruitQuantity(fruits, "Banana");


        //Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int> { };


        //Act
        int result = Fruits.GetFruitQuantity(fruits, "");


        //Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = null;


        //Act
        int result = Fruits.GetFruitQuantity(fruits, null);


        //Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        /// Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>
        {
            {"Lemon", 6 }
        };

        // Act
        int result = Fruits.GetFruitQuantity(fruits, null);

        // Assert
        Assert.AreEqual(0, result);
    }
}

using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        //Arrange
        string input = "";
        string [] expected = { };
        //Act
        string[] result = CsvParser.ParseCsv(input);
        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //Arrange
        string input = "1";
        string[] expected = { "1" };
        //Act
        string[] result = CsvParser.ParseCsv(input);
        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        //Arrange
        string input = "1, 2, 3";
        string[] expected = { "1", "2", "3" };
        //Act
        string[] result = CsvParser.ParseCsv(input);
        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        //Arrange
        string input = "1, 2, 3";
        string[] expected = { "1", "2", "3" };
        //Act
        string[] result = CsvParser.ParseCsv(input);
        //Assert
        Assert.AreEqual(expected, result);
    }
}

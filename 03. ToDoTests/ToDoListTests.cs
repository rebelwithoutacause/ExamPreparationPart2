using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        ToDoList toDoList = new ToDoList();
        string taskTitle = "Coding";
        DateTime dueDate = DateTime.Now.AddDays(1);

        // Act
        toDoList.AddTask(taskTitle, dueDate);

        // Assert
        string result = toDoList.DisplayTasks();
       
        Assert.IsTrue(result.Contains(taskTitle));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        ToDoList toDoList = new ToDoList();
        string taskTitle = "Coding";
        DateTime dueDate = DateTime.Now.AddDays(1);
        toDoList.AddTask(taskTitle, dueDate);

        // Act
        toDoList.CompleteTask(taskTitle);

        // Assert
        string result = toDoList.DisplayTasks();
        Assert.IsTrue(result.Contains("[✓] Coding"));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Act + Assert
        Assert.That(() => _toDoList.CompleteTask("INVALID_TASK"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        string expected = "To-Do List:";

        // Act
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange 
        for (int i = 1, year = 1994; i <= 2; i++, year += 3)
        {
            _toDoList.AddTask($"task{i}", new DateTime(year, 08, 26));
        }

        string expected = "To-Do List:"
            + Environment.NewLine
            + $"[ ] task1 - Due: 08/26/1994"
            + Environment.NewLine
            + $"[ ] task2 - Due: 08/26/1997";

        // Act
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

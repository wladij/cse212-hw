using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities.
    // Expected Result: The item with the highest priority is returned.
    // Defect(s) Found: None after fixing. 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Sue", 5);
        priorityQueue.Enqueue("Tim", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Sue", result);
        
    }

    [TestMethod]
    // Scenario: Two items have the same highest priority.
    // Expected Result: The first item added should be removed first.
    // Defect(s) Found: Queue returned the last item instead of the first when priorities were equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Sue", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Bob", result);
        
        
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Highest priority item is the last one in the queue.
    // Expected Result: Last item should be returned.
    // Defect(s) Found: Last queue element was not considered.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Sue", 2);
        priorityQueue.Enqueue("Tim", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Tim", result);
        
        
    }
    
    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException with correct message.
    // Defect(s) Found: None after fixing.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        
        
    }

    

    
}
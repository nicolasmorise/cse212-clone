using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and ensure the highest priority
    // Expected Result: Items should be dequeued in order of highest priority first.
    // Defect(s) Found: Original code skipped the last element in the search loop
    // and did not remove the item from the queue after returning it.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("A", 1);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 3);

        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority.
    // Expected Result: Items should be dequeued in FIFO order when priorities are equal.
    // Defect(s) Found: Original code used >= when comparing priorities, which caused 
    // later items with the same priority to be selected instead of the earliest item.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("A", 5);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 5);

        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
    }

    // Add more test cases as needed below.
}
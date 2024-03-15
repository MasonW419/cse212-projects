public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);


        
        // Test Cases

        // Test 1
        // Scenario: Test to see if the priority queue can dequeue from highest to lowest
        // Expected Result: 5,4,3,2,1
        Console.WriteLine("Test 1");
        var testQueue1 = new PriorityQueue();
        testQueue1.Enqueue("five", 5);
        testQueue1.Enqueue("four", 4);
        testQueue1.Enqueue("three", 3);
        testQueue1.Enqueue("two", 2);
        testQueue1.Enqueue("one", 1);


        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 
        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();
        
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below


        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();



        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();
        testQueue1.Enqueue();
    }
}
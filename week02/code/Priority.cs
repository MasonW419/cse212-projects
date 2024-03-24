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

        Console.WriteLine("");
        for(int i = 0; i < 10; i++) {
            testQueue1.Dequeue();
        }


        // Defect(s) Found:  Skipped the first value to Dequeue

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: None
        var testQueue2 = new PriorityQueue();
        testQueue2.Enqueue("three", 3);
        testQueue2.Enqueue("two", 2);
        testQueue2.Enqueue("one", 1);
        testQueue2.Enqueue("five", 5);
        testQueue2.Enqueue("four", 4);
        for(int i = 0; i < 10; i++) {
            testQueue2.Dequeue();
        }
        
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 2 and a half
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2 (Double Check)");

        // Defect(s) Found: Almost got me, skipped the last number in the queue
        var testQueue2h = new PriorityQueue();
        testQueue2h.Enqueue("one", 1);
        testQueue2h.Enqueue("two", 2);
        testQueue2h.Enqueue("three", 3);
        testQueue2h.Enqueue("four", 4);
        testQueue2h.Enqueue("five", 5);
        for(int i = 0; i < 10; i++) {
            testQueue2h.Dequeue();
        }


        // Test 3
        // Scenario: Test for duplicate, the duplicates in front should go out first
        // Expected Result: 
        Console.WriteLine("Test 3");

        // Defect(s) Found: None
        var tQ3 = new PriorityQueue();
        tQ3.Enqueue("first", 5);
        tQ3.Enqueue("third", 4);
        tQ3.Enqueue("fourth", 3);
        tQ3.Enqueue("fifth", 2);
        tQ3.Enqueue("second", 5);
        for(int i = 0; i < 10; i++) {
            tQ3.Dequeue();
        }


        // testQueue1.Enqueue();
        // testQueue1.Enqueue();
        // testQueue1.Enqueue();
        // testQueue1.Enqueue();
        // testQueue1.Enqueue();



        // testQueue1.Enqueue();
        // testQueue1.Enqueue();
        // testQueue1.Enqueue();
        // testQueue1.Enqueue();
        // testQueue1.Enqueue();
    }
}
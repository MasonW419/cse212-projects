public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        bool root = false;
        bool left = false;
        bool right = false;
        if (Data == value) {
            root = true;
        }
        else {
            if (Left is not null) {
                left = Left.Contains(value);
            }
            if (Right is not null) {
                right = Right.Contains(value);
            }
            root = left || right;
        }
        return root;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        int center = 1;
        int sides = 0;
        if(Left is not null || Right is not null) {
            center++;
            sides = Math.Max(IterateHeight(Left), IterateHeight(Right));
        }
        return center + sides; // Replace this line with the correct return statement(s)
    }
    private int IterateHeight(Node? node, bool start = false) {
        int leftHeight = 0;
        int rightHeight = 0;
        int center = 0; 
        // Console.WriteLine($"This Node: {node.Data}");
        if(start == true) {
            center = 1;
        }
        if (node.Left is not null) {
            // Console.WriteLine($"Left Not Null, {node.Left.Data}");
            leftHeight = 1 + IterateHeight(node.Left);
        }
        if (node.Right is not null) {
            // Console.WriteLine($"Right Not Null {node.Right.Data}");
            rightHeight = 1 + IterateHeight(node.Right);
        }
        if (node.Left is null && node.Right is null) {
            // Console.WriteLine("Both are Null");
        } 
        
        // Console.WriteLine($"Returned: {Math.Max(leftHeight, rightHeight)}");
        // Console.WriteLine();
        return center + Math.Max(leftHeight, rightHeight);
    }
}
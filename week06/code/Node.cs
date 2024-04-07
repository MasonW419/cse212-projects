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
        return 1 + Math.Max(IterateHeight(Left), IterateHeight(Right)); // Replace this line with the correct return statement(s)
    }
    private int IterateHeight(Node? node) {
        int leftHeight = 0;
        int rightHeight = 0;
        if (node.Left is null && node.Right is null) {
            Console.WriteLine("Stopped");
            return 0;
        } 
        // else {
        //     if(node.Left is not null) {
        //         leftHeight = 1 + IterateHeight(Left);
        //     }
        //     if(node.Right is not null) {
        //         rightHeight = 1 + IterateHeight(Right);
        //     }
        // }
        // if (node.Left is not null || node.Right is not null) {
        // if(node.Left is not null)
        //     leftHeight = 1 + IterateHeight(Left);
        // if(node.Right is not null) {
        //     rightHeight = 1 + IterateHeight(Right);
        // }
        // }
        return Math.Max(leftHeight, rightHeight);
    }
}
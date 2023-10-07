static void levelOrder(Node root){
    if (root == null)
    {
        return;
    }

    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        Node current = queue.Dequeue();
        Console.Write(current.data + " ");

        if (current.left != null)
        {
            queue.Enqueue(current.left);
        }

        if (current.right != null)
        {
            queue.Enqueue(current.right);
        }
    }
}


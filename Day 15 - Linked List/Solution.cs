public static  Node insert(Node head,int data)
{
// Create a new node with the given data
    Node newNode = new Node(data);

    // If the list is empty, set the new node as the head
    if (head == null)
    {
        head = newNode;
    }
    else
    {
        // Traverse to the end of the list
        Node current = head;
        while (current.next != null)
        {
            current = current.next;
        }

        // Insert the new node at the end
        current.next = newNode;
    }

    // Return the reference to the head of the updated list
    return head;
}


public static Node removeDuplicates(Node head){
    if (head == null)
    {
        return null;
    }

    Node current = head;

    while (current.next != null)
    {
        if (current.data == current.next.data)
        {
            current.next = current.next.next; // Skip the duplicate node
        }
        else
        {
            current = current.next; // Move to the next node
        }
    }

    return head;
}

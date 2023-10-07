class Solution {
    //Write your code here
    private Stack<char> stack = new Stack<char>();
    private Queue<char> queue = new Queue<char>();
    
    // Method to push a character onto a stack.
    private void pushCharacter(char ch) {
        stack.Push(ch);
    }

    // Method to enqueue a character in the queue.
    private void enqueueCharacter(char ch) {
        queue.Enqueue(ch);
    }

    // Method to pop and return the character at the top of the stack.
    private char popCharacter() {
        return stack.Pop();
    }

    // Method to dequeue and return the first character in the queue.
    private char dequeueCharacter() {
        return queue.Dequeue();
    }
}
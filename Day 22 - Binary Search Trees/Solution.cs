static int getHeight(Node root){
    // Base case: if the root is null, return -1 (height of an empty tree)
    if (root == null) {
        return -1;
    }

    // Recursively calculate the height of the left and right subtrees
    int leftHeight = getHeight(root.left);
    int rightHeight = getHeight(root.right);

    // Return the maximum height between the left and right subtrees plus 1 (for the current node)
    return Math.Max(leftHeight, rightHeight) + 1;
}


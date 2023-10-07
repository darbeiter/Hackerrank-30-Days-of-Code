public Difference(int [] elements)
{
    this.elements = elements;
}

public void computeDifference()
{
    int max = int.MinValue;
    int min = int.MaxValue;

    // Find the maximum and minimum elements in the array
    foreach (int element in elements)
    {
        if (element > max)
            max = element;
        if (element < min)
            min = element;
    }

    // Calculate the maximum absolute difference
    maximumDifference = Math.Abs(max - min);
}


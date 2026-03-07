public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
 
    public static double[] MultiplesOf(double number, int length)
{
    /// Creates a new array where it can store the numbers based on the lenght input to set the size of the array
    double[] results = new double[length];
    /// Make a lop where it will finish when i is bigger then lenght
    for (int i = 0; i < length; i++)
    {
        ///the results[i as the index number] is equal the multiplier of i + 1
        results[i] = number * (i + 1);
    }

    return results;
}
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        /// Find the start element
        int startIndex = data.Count - amount;
        /// Take the right part from the start to the last
        List<int> rightPart = data.GetRange(startIndex, amount);
        /// Take the left part from the first index to the start index
        List<int> leftPart = data.GetRange(0, startIndex);
        /// Clear list
        data.Clear();
        /// Arrange the list with rigth and left part
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}

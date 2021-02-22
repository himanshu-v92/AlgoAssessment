namespace TGS.Challenge
{
    /*
         Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
         are equal to the sum of all the items to the right of the index.

         Constraints: 0 <= N <= 100 000

         Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
         Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

         If no index exists then output -1

         There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */

    public class EquivalenceIndex
    {
        public int Find(int[] numbers)
        {
            //storing length of the array
            int length = numbers.Length;

            //variable to store sum of all elements of array
            int sumOfArr = 0;

            //variable to store left sum
            int leftSum = 0;

            //computing sum of the array elements
            for (int i = 0; i < length; i++)
            {
                sumOfArr += numbers[i];
            }

            //finding the equivalence index
            for (int i = 0; i < length; i++)
            {
                //subtracting current index element from the total sum 
                sumOfArr -= numbers[i];

                //if remaining sum is equal to the left sum then return the index
                if (leftSum == sumOfArr) return i;

                leftSum += numbers[i];
            }

            //returning -1 if index is not found
            return -1;
        }
    }
}

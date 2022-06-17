using Algorithms.Main;

namespace Algorithms.Tests
{
    public class SortingTests
    {
        private readonly Sorting _target;

        public SortingTests()
        {
            _target = new Sorting();
        }

        [Theory, MemberData(nameof(ArrayData))]
        public void InsertionSort_Numbers_Test(int[] inputArray, int[] expectedArray)
        {
            int[] result = _target.InsertionSort(inputArray);

            Assert.Equal(expectedArray, result);
        }

        #region Internal Implementation

        public static IEnumerable<object[]> ArrayData => 
            new List<object[]>
            {
                new object[]
                { 
                    new int[] { 5, 3, 12, 8, 0, 1, 9, 4, 17, 32 },
                    new int[] { 0, 1, 3, 4, 5, 8, 9, 12, 17, 32 }
                },
            };

        #endregion
    }
}
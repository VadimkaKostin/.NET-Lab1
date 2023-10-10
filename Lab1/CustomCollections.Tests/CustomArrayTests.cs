using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections.Tests
{
    public class CustomArrayTests : CollectionTestsBase
    {
        #region Index
        [Fact]
        public void Index_CallToEmptyCollection_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var collection = new CustomArray<int>();

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                // Act
                int value = collection[0];
            });
        }

        [Fact]
        public void Index_ProperIndex_ReturnsProperElement()
        {
            // Arrange
            var testElements = new List<int>() { 1, 2, 3 };
            var collection = new CustomArray<int>(testElements);

            // Act
            int first = collection[0];
            int second = collection[1];
            int third = collection[2];

            // Assert
            Assert.Equal(testElements[0], first);
            Assert.Equal(testElements[1], second);
            Assert.Equal(testElements[2], third);
        }

        [Fact]
        public void Index_IndexOutOfRange_ReturnsProperElement()
        {
            // Arrange
            int count = 5;
            var collection = new CustomArray<int>(GetDefaultSetForCollection(count));

            int actualPositiveIndex = 7;
            int expectedPositiveIndex = actualPositiveIndex % count;

            int actualNegativeIndex = -2;
            int expectedNegativeIndex = (count + actualNegativeIndex % count) % count;

            // Act
            var expectedElementPositive = collection[expectedPositiveIndex];
            var actualElementPositive = collection[actualPositiveIndex];

            var expectedElementNegative = collection[expectedNegativeIndex];
            var actualElementNegative = collection[actualNegativeIndex];

            // Assert
            Assert.Equal(expectedElementPositive, actualElementPositive);
            Assert.Equal(expectedElementNegative, actualElementNegative);
        }
        #endregion

        #region Add
        [Fact]
        public void Add_NewElement_AddedToTheEnd()
        {
            // Arrange
            var collection = new CustomArray<int>(GetDefaultSetForCollection());
            int valueToAdd = 6;

            // Act
            collection.Add(valueToAdd);

            // Assert
            Assert.Equal(6, collection.Last());
        }

        [Fact]
        public void Add_NewElement_CountIncrements()
        {
            // Arrange
            var collection = new CustomArray<int>();
            int defaultCount = collection.Count;

            // Act
            collection.Add(0);

            // Assert
            Assert.Equal(1, collection.Count - defaultCount);
        }

        [Fact]
        public void Add_NullElement_ThrowsArgumentNullException()
        {
            // Arrange
            var collection = new CustomArray<TestItem>();

            // Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                // Act
                collection.Add(null);
            });
        }
        #endregion

        #region Clear
        [Fact]
        public void Clear_EmptyCollection()
        {
            // Arrange
            var collection = new CustomArray<int>(GetDefaultSetForCollection());

            // Act
            collection.Clear();

            // Assert
            Assert.Empty(collection);
        }
        #endregion

        #region Contains
        [Fact]
        public void Contains_ElementPassed_ReturnsResultOfExistence()
        {
            // Arrange
            var collection = new CustomArray<int>() { 1, 2, 3 };

            // Act
            bool result1 = collection.Contains(2);
            bool result2 = collection.Contains(4);

            //Assert
            Assert.True(result1);
            Assert.False(result2);
        }

        [Fact]
        public void Clear_NullElement_ThrowsArgumentNullException()
        {
            // Arrange
            var collection = new CustomArray<TestItem>();

            // Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                // Act
                collection.Contains(null);
            });
        }
        #endregion

        #region CopyTo
        [Fact]
        public void CopyTo_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            var collection = new CustomArray<int>();
            int[] arrayCopyTo = null;
            int indexCopyTo = 0;

            // Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                // Act
                collection.CopyTo(arrayCopyTo, indexCopyTo);
            });
        }

        [Fact]
        public void CopyTo_ArrayDoesNotFitIntoTheRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var collection = new CustomArray<int>() { 4, 5, 6 };
            var arrayCopyTo = new int[] { 1, 2, 3 };
            int indexCopyTo = 2;

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                // Act
                collection.CopyTo(arrayCopyTo, indexCopyTo);
            });
        }

        [Fact]
        public void CopyTo_CorrectArrayAndIndex_SuccessfullCopying()
        {
            // Arrange
            var collection = new CustomArray<int>() { 4, 5, 6 };
            var arrayCopyTo = new int[6] { 1, 2, 3, 0, 0, 0 };
            var indexCopyTo = 3;

            // Act
            collection.CopyTo(arrayCopyTo, indexCopyTo);

            // Assert
            Assert.Equal(collection[0], arrayCopyTo[3]);
            Assert.Equal(collection[1], arrayCopyTo[4]);
            Assert.Equal(collection[2], arrayCopyTo[5]);
        }
        #endregion
    }
}

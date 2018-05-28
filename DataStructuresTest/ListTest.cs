using DataStructures;
using System;
using Xunit;

namespace DataStructuresTest
{
    public class ListTest
    {
        [Fact]
        public void SimpleAddToListTest()
        {
            //Arrange
            int numberOne = 7;
            List<int> listOfNumbers = new List<int>();
            listOfNumbers.Add(numberOne);
            listOfNumbers.Add(numberOne + 1);
            listOfNumbers.Add(numberOne + 1);
            listOfNumbers.Add(numberOne + 2);
            listOfNumbers.Add(numberOne + 3);
            listOfNumbers.Add(numberOne + 4);
            listOfNumbers.Add(numberOne + 1);
            listOfNumbers.Add(numberOne + 6);
            listOfNumbers.Add(numberOne + 6);
            listOfNumbers.Add(numberOne + 7);
            listOfNumbers.Add(numberOne + 2);
            listOfNumbers.Add(numberOne + 2);
            listOfNumbers.Add(numberOne + 3);
            listOfNumbers.Add(numberOne + 9);
            listOfNumbers.Add(numberOne + 7);
            listOfNumbers.Add(numberOne);


            //Act
            int actualOnZero = listOfNumbers.Get(15);
            //Assert

            Assert.Equal(numberOne, actualOnZero);
        }

        [Fact]
        public void ReturnCantOfListSimpleTest()
        {
            //Arrange
            List<string> ABCAlphabet = new List<string>(4);
            //Act
            //Assert
            Assert.Equal(0, ABCAlphabet.Count());
        }

        [Fact]
        public void ReturnQuantityOfListAddingTest()
        {
            //Arrange
            List<string> ABCAlphabet = new List<string>();
            ABCAlphabet.Add("a");
            ABCAlphabet.Add("b");
            ABCAlphabet.Add("f");
            ABCAlphabet.Add("g");
            ABCAlphabet.Add("4");
            ABCAlphabet.Add("t");
            //Act
            //Assert
            Assert.Equal(6, ABCAlphabet.Count());
        }

        [Fact]
        public void RemoveOneItemTest()
        {
            //Arrange
            List<string> ABCAlphabet = new List<string>();
            ABCAlphabet.Add("a");
            ABCAlphabet.Add("b");
            ABCAlphabet.Add("f");
            ABCAlphabet.Add("g");
            ABCAlphabet.Add("y");
            ABCAlphabet.Add("4");
            ABCAlphabet.Add("t");
            //Act
            ABCAlphabet.Remove("b");
            //Assert
            Assert.Equal(6, ABCAlphabet.Count());
        }

        [Fact]
        public void RemoveOneItemComplexTest()
        {
            //Arrange
            List<string> Expectedphabet = new List<string>();
            Expectedphabet.Add("a");
            Expectedphabet.Add("b");
            Expectedphabet.Add("f");
            Expectedphabet.Add("g");
            Expectedphabet.Add("y");
            Expectedphabet.Add("t");

            List<string> ABCAlphabet = new List<string>();
            ABCAlphabet.Add("a");
            ABCAlphabet.Add("b");
            ABCAlphabet.Add("f");
            ABCAlphabet.Add("g");
            ABCAlphabet.Add("y");
            ABCAlphabet.Add("4");
            ABCAlphabet.Add("t");
            //Act
            ABCAlphabet.Remove("4");
            //Assert
            Assert.Equal(Expectedphabet, ABCAlphabet);
        }

        [Fact]
        public void RemoveAtOneItemComplexTest()
        {
            //Arrange
            List<string> Expectedphabet = new List<string>();
            Expectedphabet.Add("a");
            Expectedphabet.Add("b");
            Expectedphabet.Add("f");

            List<string> ABCAlphabet = new List<string>();
            ABCAlphabet.Add("a");
            ABCAlphabet.Add("b");
            ABCAlphabet.Add("f");
            ABCAlphabet.Add("5");
            //Act
            ABCAlphabet.RemoveAt(3);
            //Assert
            Assert.Equal(Expectedphabet, ABCAlphabet);
        }

        [Fact]
        public void RemoveWithItemFailTest()
        {
            //Arrange
            List<string> Expectedphabet = new List<string>();
            Expectedphabet.Add("a");
            Expectedphabet.Add("b");
            Expectedphabet.Add("f");

            List<string> ABCAlphabet = new List<string>();
            ABCAlphabet.Add("a");
            ABCAlphabet.Add("b");
            ABCAlphabet.Add("f");
            ABCAlphabet.Add("5");
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ABCAlphabet.RemoveAt(4));
        }

        [Fact]
        public void InsertItemInIndexTest()
        {
            //Arrange
            List<string> Expectedphabet = new List<string>();
            Expectedphabet.Add("a");
            Expectedphabet.Add("f");
            Expectedphabet.Add("b");
            Expectedphabet.Add("5");

            List<string> ABCAlphabet = new List<string>();
            ABCAlphabet.Add("a");
            ABCAlphabet.Add("f");
            ABCAlphabet.Add("5");
            //Act
            ABCAlphabet.Insert("b", 2);
            //Assert
            Assert.Equal(Expectedphabet, ABCAlphabet);
        }

        [Fact]
        public void ObteinedIndexOfItemTest()
        {
            //Arrange
            List<string> ABCAlphabet = new List<string>();
            ABCAlphabet.Add("a");
            ABCAlphabet.Add("f");
            ABCAlphabet.Add("5");
            //Act

            //Assert
            Assert.Equal(2, ABCAlphabet.IndexOf("5"));
        }
    }
}

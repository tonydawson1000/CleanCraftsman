using CleanCraftsman;
using System;
using Xunit;

namespace CleanCraftsmanTests
{
    public class StackTest
    {
        private readonly Stack stack = new();

        [Fact]
        public void AfterPushingXAndY_WillPopYThenX()
        {
            //Arrange

            //Act
            stack.Push(99);
            stack.Push(88);

            //Assert
            Assert.Equal(88, stack.Pop());
            Assert.Equal(99, stack.Pop());
        }

        [Fact]
        public void AfterPushingX_WillPopX()
        {
            //Arrange

            //Act
            stack.Push(99);

            //Assert
            Assert.Equal(99, stack.Pop());


            //Act
            stack.Push(88);

            //Assert
            Assert.Equal(88, stack.Pop());
        }

        [Fact]
        public void PoppingEmptyStack_ThrowsUnderflow()
        {
            //Arrange

            //Act
            Action act = () => stack.Pop();

            //Assert
            UnderflowException exception = Assert.Throws<UnderflowException>(act);

            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal("Stack is Empty, Nothing to Pop", exception.Message);
        }

        [Fact]
        public void AfterTwoPushes_SizeIsTwo()
        {
            //Arrange

            //Act
            stack.Push(0);
            stack.Push(0);

            //Assert
            Assert.Equal(2, stack.GetSize());
        }

        [Fact]
        public void AfterOnePushAndOnePop_IsEmpty()
        {
            //Arrange

            //Act
            stack.Push(0);
            stack.Pop();

            //Assert
            Assert.True(stack.IsEmpty());
            Assert.Equal(0, stack.GetSize());
        }

        [Fact]
        public void AfterOnePush_IsNotEmpty()
        {
            //Arrange

            //Act
            stack.Push(0);

            //Assert
            Assert.False(stack.IsEmpty());
            Assert.Equal(1, stack.GetSize());
        }
    }
}

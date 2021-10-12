using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using XOGame;
using Xunit;

namespace XOGames.Test
{
    public class Tests
    {
        //Given array of size 3x3.
        //For example,

        //var input = new char[,] {
        // { 'o', 'x', 'o' },
        // { 'x', 'o', 'x' },
        // { 'x', 'x', ' ' }
        //};

        //    Write a C# method for the XO game which determine the game situation as follows.

        //1. The game is not over yet.
        //2. The game is over and O is a winner.
        //3. The game is over and X is a winner.
        //4. The game is over and they both draw.
        //5. The game input state is invalid.
        [Fact]
        //1. The game is not over yet.
        public void TheGameIsNotOverYetData()
        {
            char[,] array2D = new char[,] { 
                                { 'o', 'x', 'o' },
                                { 'x', 'o', 'x' },
                                { 'x', 'x', ' ' }};
            XOServices svc = new XOServices();
            var result = svc.CheckWinArray2D(array2D);
            Assert.False(result);

            //string[] xoData = new string[9] {
            //             "o", "x", "o" ,
            //             "x", "o", "x" ,
            //             "x", "x", "" };

            //XOServices svc = new XOServices();
            //var result = svc.CheckWin(xoData);
            ////result.Should().BeFalse();
            //Assert.False(result);
        }

        [Fact]
        //2. The game is over and O is a winner.
        public void TheGameIsOverAndOIsAWinner()
        {
            char[,] array2D = new char[,] {
                                { 'o', 'x', 'o' },
                                { 'x', 'o', 'x' },
                                { 'x', 'x', 'o' }};
            XOServices svc = new XOServices();
            var result = svc.CheckWinArray2D(array2D);
            Assert.True(result);

            //string[] xoData = new string[9] {
            //             "o", "x", "o" ,
            //             "x", "o", "x" ,
            //             "x", "x", "o" };

            //XOServices svc = new XOServices();
            //var result = svc.CheckWin(xoData);
            ////result.Should().BeTrue();
            //Assert.True(result);
        }

        [Fact]
        //3. The game is over and X is a winner.
        public void TheGameIsOverAndXIsAWinner()
        {
            char[,] array2D = new char[,] {
                                { 'o', 'x', 'o' },
                                { 'x', 'o', 'x' },
                                { 'x', 'x', 'x' }};
            XOServices svc = new XOServices();
            var result = svc.CheckWinArray2D(array2D);
            Assert.True(result);
            //string[] xoData = new string[9] {
            //             "o", "x", "o" ,
            //             "x", "o", "x" ,
            //             "x", "x", "x" };

            //XOServices svc = new XOServices();
            //var result = svc.CheckWin(xoData);
            ////result.Should().BeTrue();
            //Assert.True(result);
        }

        [Fact]
        //4. The game is over and they both draw.
        public void TheGameIsOverAndTheyBothDraw()
        {
            char[,] array2D = new char[,] {
                                { 'o', 'x', 'o' },
                                { 'x', 'o', 'x' },
                                { 'x', 'o', 'x' }};
            XOServices svc = new XOServices();
            var result = svc.CheckWinArray2D(array2D);
            Assert.False(result);

            //string[] xoData = new string[9] {
            //             "o", "x", "o" ,
            //             "x", "o", "x" ,
            //             "x", "o", "x" };

            //XOServices svc = new XOServices();
            //var result = svc.CheckWin(xoData);
            ////result.Should().BeFalse();
            //Assert.False(result);
        }

        [Fact]
        //5. The game input state is invalid.
        public void TheGameInputStateIsInvalid()
        {
            char[,] array2D = new char[,] {
                                { 'a', '2', 'o' },
                                { 'x', 'o', 'x' },
                                { 'x', 'o', 'x' }};
            XOServices svc = new XOServices();
            var result = svc.CheckWinArray2D(array2D);
            Assert.False(result);
            //string[] xoData = new string[9] {
            //             "a", "b", "o" ,
            //             "x", "o", "x" ,
            //             "x", "o", "x" };

            //XOServices svc = new XOServices();
            //var result = svc.CheckWin(xoData);
            ////result.Should().BeFalse();
            //Assert.False(result);
        }
    }
}
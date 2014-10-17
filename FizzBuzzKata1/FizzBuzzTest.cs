using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzKata1
{
    public class FizzBuzzTest
    {
        FizzBuzz _fizzBuzz = new FizzBuzz();
        //TODO: 
        // 1 -- 1
        // 2 -- 2
        // 3 -- fizz
        // 4 -- 4
        // 5 -- buzz
        //... 15 -- fizzbuzz

        [Fact]
        public void AnswerShoulReturnOneWhenOne()
        {
            Assert.Equal("1", _fizzBuzz.Answer(1));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        public void Answer_Should_Return_Number_When_Not_Divisible_By3or5(int n)
        {
            Assert.Equal(n.ToString(), _fizzBuzz.Answer(n));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void Answer_Should_Return_Fizz_When_Divisible_By3(int n)
        {
            Assert.Equal("Fizz", _fizzBuzz.Answer(n));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void Answer_Should_Return_Fizz_When_Divisible_By5(int n)
        {
            Assert.Equal("Buzz", _fizzBuzz.Answer(n));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void Answer_Should_Return_Fizz_When_Divisible_By15(int n)
        {
            Assert.Equal("FizzBuzz", _fizzBuzz.Answer(n));
        }
    }
}

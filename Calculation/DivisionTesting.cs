using System;
using FluentAssertions;
using Domain;

namespace Calculation
{
    public class DivisionTesting
    {
        [Fact]
        public void Division_of_4_by_2_should_be_2()
        {
            var div = new Calculator().Division(4, 2);
            div.Should().Be(2);
        }

        [Fact]
        public void Division_of_9_by_3_should_be_3()
        {
            var div = new Calculator().Division(9, 3);
            div.Should().Be(3);
        }

        [Fact]
        public void Division_of_9_by_0_should_be_0()
        {
            var div = new Calculator().Division(9, 0);
            div.Should().Be(0);
        }

        [Fact]
        public void Division_of_16_by_4_should_be_4() => new Calculator().Division(16, 4).Should().Be(4);
    }
}
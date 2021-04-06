using CalculatorLib;
using System;
using System.Collections.Generic;
using Xunit;

namespace CalculatorLibTests
{
    public class SimpleCalculatorTest
    {
        [Fact]
        public void SimpleCalculator_Calculate_AdditionOperation_Calculated()
        {
            //Arrange

            List<IOperation> operations = new()
            {
                new AdditionOperation()
            };

            SimpleCalculator simpleCalculator = new( operations );

            //Act

            int result = simpleCalculator.Calculate( "2+2" );

            //Assert

            Assert.Equal( 4, result );
        }

        [Fact]
        public void SimpleCalculator_Calculate_SubstractionOperation_Calculated()
        {
            //Arrange

            List<IOperation> operations = new()
            {
                new SubstractionOperation()
            };

            SimpleCalculator simpleCalculator = new( operations );

            //Act

            int result = simpleCalculator.Calculate( "2-2" );

            //Assert

            Assert.Equal( 0, result );
        }

        [Fact]
        public void SimpleCalculator_Calculate_MultiplicationOperation_Calculated()
        {
            //Arrange

            List<IOperation> operations = new()
            {
                new MultiplicationOperation()
            };

            SimpleCalculator simpleCalculator = new( operations );

            //Act

            int result = simpleCalculator.Calculate( "2*3" );

            //Assert

            Assert.Equal( 6, result );
        }

        [Fact]
        public void SimpleCalculator_Calculate_DivisionOperation_Calculated()
        {
            //Arrange

            List<IOperation> operations = new()
            {
                new DivisionOperation()
            };

            SimpleCalculator simpleCalculator = new( operations );

            //Act

            int result = simpleCalculator.Calculate( "30/11" );

            //Assert

            Assert.Equal( 2, result );
        }
    }
}

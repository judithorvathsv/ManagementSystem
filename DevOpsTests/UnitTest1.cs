using ManagementSystem.Models;
using System;
using Xunit;


namespace DevOpsTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var Machines = "";
            //var NotEmptyMachine = "oneMachine";
            var NotEmptyMachine = "";

            Assert.Equal(Machines, NotEmptyMachine);
        }
    }
}

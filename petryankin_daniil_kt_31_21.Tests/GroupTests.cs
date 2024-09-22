using petryankin_daniil_kt_31_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petryankin_daniil_kt_31_21.Tests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidGroupName_KT3121_True()
        {
            // arrange
            var testGroup = new Group
            {
                GroupName = "KT-31-21"
            };

            // act
            var result = testGroup.IsValidGroupName();

            // assert
            Assert.True(result);
        }
    }
}

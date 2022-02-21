using System;
using Xunit;
using SimpleApi.Controllers;
namespace SimpleApi.Tests
{
    public class UnitTest1
    {  
        ValuesController obj=new ValuesController();
      
        [Fact]
        public void Test1()
        {
            var temp=obj.Get(1);
            Assert.Equal("Romeeta",temp); 
        }
    }
}

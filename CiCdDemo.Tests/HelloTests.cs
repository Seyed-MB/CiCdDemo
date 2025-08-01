using Xunit;
using CiCdDemo;

namespace CiCdDemo.Tests;

public class HelloTests
{
    [Fact]
    public void SayHello_ShouldReturnHelloWorld()
    {
        var result = Hello.SayHello();
        Assert.Equal("Hello, World!", result);
    }
}
using System.Text;
using FluentAssertions;
using Xunit;

namespace Programming_Aptitude.Question1;

public class Test
{
    [Fact]
    public void GivenDoubleAndAnimalTypesForGenericList_DoSomething_PrintsFooNumberAndFooAnimal()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        
        Question1.Main(Array.Empty<string>());

        var expectedOutput = new StringBuilder();
        expectedOutput.AppendLine("Foo Number");
        expectedOutput.AppendLine("Foo Animal");

        stringWriter.ToString().Should().BeEquivalentTo(expectedOutput.ToString());
    }
}
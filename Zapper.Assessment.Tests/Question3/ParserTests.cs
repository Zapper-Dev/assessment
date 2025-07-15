using Zapper.Assessment.Question3;

namespace Zapper.Assessment.Tests.Question3;

public class ParserTests
{
    [Fact]
    public void Fact1()
    {
        const string input = "06Amount0599.0009Reference06foobar";

        var expected = new Dictionary<string, string>
        {
            {"Amount", "99.00"},
            {"Reference", "foobar"}
        };

        var parts = CodeParser.FindParts(input);
        
        Assert.Equal(expected, parts.ToList());
    }
    
    [Fact]
    public void CodeParser_ZeroLengthPart()
    {
        const string input = "06Amount0599.0009Reference06foobar00";

        var expected = new Dictionary<string, string>
        {
            {"Amount", "99.00"},
            {"Reference", "foobar"}
        };

        var parts = CodeParser.FindParts(input);
        
        Assert.Equal(expected, parts.ToList());
    }
    
    [Fact]
    public void CodeParser_ZeroLengthCode()
    {
        const string input = "";

        var expected = new Dictionary<string, string>();

        var parts = CodeParser.FindParts(input);
        
        Assert.Equal(expected, parts.ToList());
    }
    
    [Fact]
    public void CodeParser_RepeatingElement()
    {
        const string input = "06Amount0599.0009Reference06foobar09Reference10helloworld";

        var expected = new Dictionary<string, string>
        {
            {"Amount", "99.00"},
            {"Reference", "helloworld"}
        };

        var parts = CodeParser.FindParts(input);
        
        Assert.Equal(expected, parts.ToList());
    }
    
    [Fact]
    public void CodeParser_Example1()
    {
        const string input = "04Name03Joe07Surname04Soap";

        var expected = new Dictionary<string, string>
        {
            {"Name", "Joe"},
            {"Surname", "Soap"}
        };

        var parts = CodeParser.FindParts(input);
        
        Assert.Equal(expected, parts.ToList());
    }
}
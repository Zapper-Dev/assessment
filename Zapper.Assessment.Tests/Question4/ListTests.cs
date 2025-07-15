using Zapper.Assessment.Question4;

namespace Zapper.Assessment.Tests.Question4;

public class ListTests
{
    private readonly Assessment.Question4.IList<string> _list = new CustomList<string>();
    
    [Fact]
    public void LengthTest()
    {
        Assert.Equal(0, _list.Length());
        _list.Append("hello");
        Assert.Equal(1, _list.Length());
        _list.Append("world");
        Assert.Equal(2, _list.Length());
    }

    [Fact]
    public void RemoveAtTest()
    {

    }
    
    [Fact]
    public void PrependAndGetTest()
    {
        _list.Prepend("foo");
        _list.Prepend("bar");
        
        Assert.Equal("bar", _list.Get(0));
        Assert.Equal("foo", _list.Get(1));
    }

    [Fact]
    public void AppendAndGetTest()
    {
        _list.Append("foo");
        _list.Append("bar");
        
        Assert.Equal("foo", _list.Get(0));
        Assert.Equal("bar", _list.Get(1));
    }

    [Fact]
    public void InsertAtTest()
    {
        _list.Append("foo");
        _list.Append("bar");
        
        _list.InsertAt("waldo", 1);
        
        Assert.Equal("waldo", _list.Get(1));
    }
    
    [Fact]
    public void InsertAtBeginningTest()
    {
        _list.Append("foo");
        _list.Append("bar");
        
        _list.InsertAt("waldo", 0);
        
        Assert.Equal("waldo", _list.Get(0));
    }
    
    [Fact]
    public void InsertAtEndTest()
    {
        _list.Append("foo");
        _list.Append("bar");
        
        _list.InsertAt("waldo", 2);
        
        Assert.Equal("waldo", _list.Get(2));
    }

}
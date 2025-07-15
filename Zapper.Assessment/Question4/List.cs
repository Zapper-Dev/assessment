namespace Zapper.Assessment.Question4;

public class ListNode<T>
{
    public T? Value { get; set; }
    public ListNode<T>? Next { get; set; }
    public ListNode<T>? Prev { get; set; }
}


public interface IList<T>
{
    int Length();
    T? Get(int index);
    void Prepend(T item);
    void Append(T item);
    void InsertAt(T item, int index);
}

public class CustomList<T> : IList<T>
{
    public int Length() {
        throw new NotImplementedException();
    }

    public T? Get(int index) {
        throw new NotImplementedException();
    }

    public void Prepend(T item) {
        throw new NotImplementedException();
    }

    public void Append(T item) {
        throw new NotImplementedException();
    }

    public void InsertAt(T item, int index) {
        throw new NotImplementedException();
    }
}
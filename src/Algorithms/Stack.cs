namespace C__Algorithm;

public class Stack
{
    private readonly List<Object> _stackItems;
    public Stack()
    {
        _stackItems = new();
    }


    public void Push(object obj)
    {
        if(obj == null)
        {
            throw new InvalidOperationException("There are no items to push"); 
        }
        _stackItems.Add(obj);
    }

    public Object Pop()
    {
        if (_stackItems.Count == 0)
        {
            throw new InvalidOperationException("The stack is already empty");
        }
        int lastIndex = _stackItems.Count - 1;
        object poppedItem = _stackItems[lastIndex];
        return poppedItem;
    }

    public void Clear()
    {
        _stackItems.Clear();
    }
}
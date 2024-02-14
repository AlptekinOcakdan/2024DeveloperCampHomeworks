namespace Generics;

class MyList<T>
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T value)
    {
        _count++;
        _tempArray = _array;
        _array = new T[_count];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_count - 1] = value;
    }
    private int _count;

    public int Count
    {
        get { return _array.Length; }
    }
}
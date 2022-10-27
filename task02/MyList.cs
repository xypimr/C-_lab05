namespace task02;

public class MyList<T>
{
    private T[] _array;

    public MyList()
    {
        _array = Array.Empty<T>();
    }
    public MyList(int n)
    {
        _array = new T[n];
    }
    
    public void Add(T elem)
    {
        Array.Resize(ref _array, _array.Length+1);
        _array[_array.Length-1] = elem;
    }
    
    public T this[int i]
    {
        get
        {
            return _array[i];
        }
        set
        {
            _array[i] = value;
        }
        
    }

    public int Capacity
    {
        get
        {
            // int t = 0;
            // for (int i = 0; i < _array.Length; i++)
            // {
            //     if (_array[i]!= null)
            //     {
            //         t++;
            //     }
            // }
            //
            // return t;
            return _array.Length;

        }
        
    }
}
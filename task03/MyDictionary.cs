using System.Collections;
namespace task03;

public class MyDictionary<TKey, TValue> : IEquatable<MyDictionary<TKey, TValue>>
{
    private KeyValuePair<TKey, TValue>[] data;
    private int size;
    
    public bool Equals(MyDictionary<TKey, TValue>? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return data.Equals(other.data);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((MyDictionary<TKey, TValue>)obj);
    }

    public override int GetHashCode()
    {
        return data.GetHashCode();
    }

    public static bool operator ==(MyDictionary<TKey, TValue>? left, MyDictionary<TKey, TValue>? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(MyDictionary<TKey, TValue>? left, MyDictionary<TKey, TValue>? right)
    {
        return !Equals(left, right);
    }

    public MyDictionary()
    {
        data = new KeyValuePair<TKey, TValue>[0];
        size = 0;
    }

    public void Add(TKey key, TValue value)
    {
        KeyValuePair<TKey, TValue> item = new KeyValuePair<TKey, TValue>(key, value);
        int sizet = size;
        size++;
        KeyValuePair<TKey, TValue>[] datat = new KeyValuePair<TKey, TValue>[size];
        for (int i = 0; i < sizet; i++)
        {
            datat[i] = data[i];
        }
        datat[sizet] = item;
        data = datat;
    }

    public KeyValuePair<TKey, TValue> this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
    public int Capacity
    {
        get
        {
            // int cap = 0;
            // for (int i = 0; i < size; i++)
            // {
            //     if (data[i].Key != null && data[i].Value != null)
            //     {
            //         cap++;
            //     }
            // }
            // return cap;
            return data.Length;

        }
    }
    public IEnumerator GetEnumerator()
    {
        return data.GetEnumerator();
    }
}
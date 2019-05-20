using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    internal Queue<T> circularBuffer;
    internal int _capacity;

    public CircularBuffer(int capacity)
    {
        circularBuffer = new Queue<T>(capacity);
        _capacity = capacity;
    }

    public T Read()
    {
       if(CheckBufferEmpty())
            throw new InvalidOperationException("Empty Buffer cannot be read.");
       
        return circularBuffer.Dequeue();
    }
    
    public void Write(T value)
    {
        if(CheckBufferFull())
            throw new InvalidOperationException("Buffer is full.");
        else
            circularBuffer.Enqueue(value);
    }
    
    public void Overwrite(T value)
    {
        if (CheckBufferFull())
        {
            circularBuffer.Dequeue();            
        }        

        Write(value);
    }

    public void Clear()
    {
        if (CheckBufferEmpty())
            return;
        circularBuffer.Clear();
    }

    #region private Methods

    private bool CheckBufferEmpty()
    {
        if (circularBuffer.Count == 0)
            return true;
        else
            return false;
    }
    private bool CheckBufferFull()
    {
        if (circularBuffer.Count == _capacity)
            return true;

        else
            return false;
    }
    #endregion
}
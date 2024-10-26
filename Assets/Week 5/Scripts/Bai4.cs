using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai4 <T>
{
    public List<T> items = new List<T>();
    public virtual void AddItem(T item)
    {
        this.items.Add(item);
    }
    public virtual void RemoveItem(T item)
    {
        if (this.items.Contains(item))
        {
            this.items.Remove(item);
        }
        else
        {
            Debug.Log("trong danh sach khong co " + item);
        }
    }
    public virtual void DisplayIteams()
    {
        foreach(T item in this.items)
        {
            Debug.Log(item);
        }
    }
}

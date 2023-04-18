using System;
using UnityEngine;

public abstract class Money<T>: MonoBehaviour
{
    public abstract event Action<T> OnChangeMoney;
    public T Value;
    public abstract void Add(T count);
}

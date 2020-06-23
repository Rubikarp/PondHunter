using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;

public class GameEvent : MonoBehaviour
{
    public static GameEvent current;

    private void Awake()
    {
        current = this;
    }

    public event Action onInsectEat;
    public void InsectEat()
    {
        onInsectEat?.Invoke();
    }

}

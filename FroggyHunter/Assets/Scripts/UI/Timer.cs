﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private Slider slider = null;

    [SerializeField] private float maxTimer = 60f;
    public float remainingTime = 30f;
    [SerializeField] private bool lookTime = false;
    [Space(15)]
    [SerializeField] private bool partyIsOver = false;
    [SerializeField] private UnityEvent onEnd;

    private void Start()
    {
        remainingTime = maxTimer;
        slider.maxValue = maxTimer;

        partyIsOver = false;
    }

    private void Update()
    {
        if (remainingTime > maxTimer)
        {
            remainingTime = maxTimer;
        }

        if (remainingTime > 0 & !lookTime)
        {
            remainingTime -= Time.deltaTime;
            slider.value = remainingTime;
        }

        if (remainingTime <= 0 && !partyIsOver)
        {
            partyIsOver = true;
            onEnd?.Invoke();
        }
    }

}

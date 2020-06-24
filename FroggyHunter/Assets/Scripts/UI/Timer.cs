using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Slider slider = null;

    [SerializeField] private float maxTimer = 60f;
    public float remainingTime = 30f;

    [SerializeField] private bool partyIsOver = false;

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

        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            slider.value = remainingTime;
        }

        if (remainingTime > 0 && !partyIsOver)
        {
            partyIsOver = true;
        }
    }

}

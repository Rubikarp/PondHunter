using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstinctJauge : MonoBehaviour
{
    [Header("Component")]
    private InputHandler input = null;

    [Header("Variables")]
    [SerializeField] private float maxInstinct = 2f;
    [SerializeField] private float instinct = 2f;

    [SerializeField] private float consumSpeed = 1f;
    [SerializeField] private float regenSpeed = 0.5f;
    
    private void Awake()
    {
        input = InputHandler.Instance;
    }

    void Start()
    {
        instinct = maxInstinct;
    }

    void Update()
    {
        if (input.shoot)
        {
            if (instinct > 0)
            {
                Time.timeScale = 0.5f;
                instinct -= consumSpeed * Time.deltaTime;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
        else
        {
            Time.timeScale = 1f;

            if (instinct < maxInstinct)
            {
                instinct += regenSpeed * Time.deltaTime;
            }
        }
    }
}

using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class InstinctJauge : MonoBehaviour
{
    [Header("Component")]
    private InputHandler input = null;
    [SerializeField] private Slider slider = null;
    [SerializeField] Volume slowMoVolume = null;

    [Header("Variables")]
    [SerializeField] private float maxInstinct = 2f;
    [SerializeField] private float instinct = 2f;

    [SerializeField] private float instinctTimeScale = 0.3f;

    [SerializeField] private float consumSpeed = 1f;
    [SerializeField] private float regenSpeed = 0.5f;
    
    private void Awake()
    {
        input = InputHandler.Instance;
    }

    void Start()
    {
        instinct = maxInstinct;
        slider.maxValue = maxInstinct;

    }

    void Update()
    {
        if (input.shoot)
        {
            if (instinct > 0)
            {
                StaminaConsume();
                OnFocus();
            }
            else
            {
                EndFocus();
            }
        }
        else
        {
            EndFocus();

            StaminaRecover();
        }

        slider.value = instinct;
    }

    //Retour à TimeScale de 1
    private void EndFocus()
    {
        if (slowMoVolume.weight > 0.01)
        {
            slowMoVolume.weight = Mathf.Lerp(slowMoVolume.weight, 0, 3 * Time.deltaTime);
        }

        Time.timeScale = 1f;
    }

    //Ralentissement du temps
    private void OnFocus()
    {
        Time.timeScale = Mathf.Lerp(Time.timeScale, instinctTimeScale, 10 * Time.deltaTime);

        slowMoVolume.weight = Mathf.Lerp(slowMoVolume.weight, 1, 10 * Time.deltaTime);
    }

    private void StaminaConsume()
    {
        instinct -= consumSpeed * Time.deltaTime;
    }

    private void StaminaRecover()
    {
        if (instinct < maxInstinct)
        {
            instinct += regenSpeed * Time.deltaTime;
        }
        else
        {
            instinct = maxInstinct;
        }
    }

}

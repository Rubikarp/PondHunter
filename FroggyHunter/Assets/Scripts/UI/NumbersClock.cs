using UnityEngine;
using TMPro;

public class NumbersClock : MonoBehaviour
{
    [SerializeField] private Timer timer = null;
    [SerializeField] private TextMeshProUGUI text = null;

    [SerializeField] private float sec;
    [SerializeField] private float centSec;

    void Update()
    {
        if(timer.remainingTime > 0)
        {
            sec = Mathf.FloorToInt(timer.remainingTime % 60);
            centSec = Mathf.FloorToInt((timer.remainingTime * 100) % 100);

            text.text = sec.ToString("00") + ":" + centSec.ToString("00");
        }
        else
        {
            text.text = "00 : 00";
        }
    }
}

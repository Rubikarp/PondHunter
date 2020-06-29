using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AiguilleHorloge : MonoBehaviour
{
    [SerializeField] private Slider time = null;
    [SerializeField] private float multiplier = 1;

    void Update()
    {
        float rot = time.value / time.maxValue * 360 * multiplier;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }
}

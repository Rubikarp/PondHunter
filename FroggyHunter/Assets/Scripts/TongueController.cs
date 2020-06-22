using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueController : MonoBehaviour
{
    [Header("Component")]
    private InputHandler input = null;
    private Transform aimZone = null;

    [Header("Variables")]
    [SerializeField] private float range = 3f;
    private void Awake()
    {
        input = InputHandler.Instance;
        aimZone = gameObject.transform.parent;
    }

    private void Update()
    {
        Vector3 aimDir = input.aimVector.magnitude > 1? input.aimVector.normalized : input.aimVector;

        transform.position = aimZone.position + aimDir * range;

    }
}

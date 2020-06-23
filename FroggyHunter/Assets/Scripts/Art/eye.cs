using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    [SerializeField] float range = 0.2f;
    [SerializeField] float lookSpeed = 5.0f;
    [SerializeField] Transform target = null;
    private Vector2 originePos = Vector2.zero;
    private Vector2 lookingVec = Vector2.zero;

    void Start()
    {
        originePos = transform.position;
    }

    void Update()
    {
        float distanceX = target.position.x - transform.position.x;
        float distanceY = target.position.y - transform.position.y;

        lookingVec = new Vector2(distanceX, distanceY).magnitude > 1? new Vector2(distanceX, distanceY).normalized : new Vector2(distanceX, distanceY);

        transform.position = originePos + lookingVec.normalized * range;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TongueShoot : MonoBehaviour
{
    [Header("Component")]
    private InputHandler input = null;

    [Header("Variables")]
    [SerializeField] private float radius = 3f;

    private void Awake()
    {
        input = InputHandler.Instance;
    }

    private void Update()
    {
        //Quand tu tires
        if (input.shootExit)
        {
            Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, radius);

            foreach (Collider2D hit in hits)
            {
                if (hit.CompareTag("Insect"))
                {
                    Destroy(hit.gameObject);
                }
            }
        }

    }

    private void OnDrawGizmos()
    {
        Handles.color = Color.red;
        Handles.DrawWireDisc(transform.position, transform.forward, radius);
    }
}

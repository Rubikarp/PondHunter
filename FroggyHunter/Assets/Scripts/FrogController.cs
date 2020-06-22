using UnityEngine;
using UnityEngine.InputSystem;

public class FrogController : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private RestrictedArea gameArea = null;

    [Header("Variables")]
    [SerializeField] private float speed = 5f;


    public void MoveFrog()
    {
        transform.position += new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0) * speed * Time.deltaTime;
    }

}

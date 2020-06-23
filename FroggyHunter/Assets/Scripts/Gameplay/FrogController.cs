using UnityEngine;

public class FrogController : MonoBehaviour
{
    [Header("Component")]
    private InputHandler input = null;
    [SerializeField] private RestrictedArea gameArea = null;

    [Header("Variables")]
    [SerializeField] private float speed = 5f;

    private void Awake()
    {
        input = InputHandler.Instance;
    }

    private void Update()
    {
        Vector3 moveDir = input.moveVector.magnitude > 1 ? input.moveVector.normalized : input.moveVector;

        //Si il est dans la zone il peut bouger comme il veut
        if (gameArea.InZone(transform))
        {
            transform.position += moveDir * speed * Time.deltaTime;
        }
        else 
        //Il veut revenir dans la zone de jeu
        if (gameArea.CanMoveInDir(transform, moveDir))
        {
            transform.position += moveDir * speed * Time.deltaTime;
        }
    }
}

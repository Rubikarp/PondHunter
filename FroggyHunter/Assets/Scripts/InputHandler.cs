using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    [Header("Inputs")]

    [HeaderAttribute("Left Stick")]
    public Vector2 moveVector;

    [HeaderAttribute("Right Stick")]
    public Vector2 aimVector;

    [HeaderAttribute("TongueShoot")]
    public bool shoot;
    public bool shootExit;
    public bool shootEnter;

    [HeaderAttribute("PullInsect")]
    public bool pull;
    public bool pullExit;
    public bool pullEnter;

    private void Update()
    {
        //Je prends les valeurs du stick gauche
        float leftStickX = Input.GetAxis("Horizontal");
        float leftStickY = Input.GetAxis("Vertical");
        moveVector = new Vector2(leftStickX, leftStickY);

        //Je prends les valeurs du stick droit
        float rightStickX = Input.GetAxis("Horizontal");
        float rightStickY = Input.GetAxis("Vertical");
        aimVector = new Vector2(rightStickX, rightStickY);

        //Je prends les buttons
        pull = Input.GetButton("Pull");
        pullExit = Input.GetButtonUp("Pull");
        pullEnter = Input.GetButtonDown("Pull");

        shoot = Input.GetButton("Shoot");
        shootExit = Input.GetButtonUp("Shoot");
        shootEnter = Input.GetButtonDown("Shoot");
    }

}
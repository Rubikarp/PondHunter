using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : Singleton<InputHandler>
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

    [HeaderAttribute("Instinct")]
    public bool instinct;
    public bool instinctExit;
    public bool instinctEnter;

    private void Update()
    {
        //Je prends les valeurs du stick gauche
        float leftStickX = Input.GetAxis("Horizontal");
        float leftStickY = Input.GetAxis("Vertical");
        moveVector = new Vector2(leftStickX, leftStickY);

        //Je prends les valeurs du stick droit
        float rightStickX = Input.GetAxis("AimHorizontal");
        float rightStickY = Input.GetAxis("AimVertical");
        aimVector = new Vector2(rightStickX, rightStickY);

        //Je prends les buttons
        shoot = Input.GetButton("Fire1");
        shootExit = Input.GetButtonUp("Fire1");
        shootEnter = Input.GetButtonDown("Fire1");

        instinct = Input.GetButton("Fire2");
        instinctExit = Input.GetButtonUp("Fire2");
        instinctEnter = Input.GetButtonDown("Fire2");

    }

}
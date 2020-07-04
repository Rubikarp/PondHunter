using UnityEngine;

public class Transition : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private RectTransform leftPart = null, rightPart = null;

    [Header("Paramètre")]
    [SerializeField] bool isOpen = false;

    private void Start()
    {
        if (!isOpen)
        {
            Open();
        }
    }

    public void Open()
    {
        LeanTween.moveX(rightPart, 1200, 1).setEaseOutQuad();
        LeanTween.moveX(leftPart, -1200, 1).setEaseOutQuad();
    }

    public void Close()
    {
        LeanTween.moveX(rightPart, 0, 1).setEaseInQuad();
        LeanTween.moveX(leftPart,  0, 1).setEaseInQuad();
    }
}

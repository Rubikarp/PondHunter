using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class OnChangeUI : MonoBehaviour
{
    private GameObject lastselect;

    [SerializeField] private UnityEvent onChange;

    void Start()
    {
        lastselect = gameObject;
    }

    void Update()
    {
        if (EventSystem.current != null)
        {
            if (EventSystem.current.currentSelectedGameObject == null)
            {
                EventSystem.current.SetSelectedGameObject(lastselect);
            }
            else if (lastselect != EventSystem.current.currentSelectedGameObject)
            {
                lastselect = EventSystem.current.currentSelectedGameObject;
                onChange?.Invoke();
            }
        }
    }
}

using UnityEngine;
using UnityEngine.Events;

namespace Management
{
    [RequireComponent(typeof(Collider2D))]
    public class ButtonAwake : MonoBehaviour
    {
        public UnityEvent onInteraction;

        private void OnEnable()
        {
            if (onInteraction != null)
            {
                onInteraction.Invoke();
            }
        }
    }
}
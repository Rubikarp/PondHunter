using UnityEngine;
using UnityEngine.Events;

namespace Management
{
    [RequireComponent(typeof(Collider2D))]
    public class ButtonCollider : MonoBehaviour
    {
        private InputManager _input;
        private bool haveInput = false;

        public UnityEvent onInteraction;

        private void Start()
        {
            _input = GameObject.FindGameObjectWithTag("GameController").GetComponent<InputManager>();
        }

        private void OnTriggerStay2D(Collider2D collision)
        {

        }

    }
}
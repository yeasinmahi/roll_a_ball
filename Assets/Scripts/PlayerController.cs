using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed;
        private Rigidbody _rb;

        void Start ()
        {
            _rb = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal,0f,moveVertical);

            _rb.AddForce(movement*Speed);
        }
    }
}

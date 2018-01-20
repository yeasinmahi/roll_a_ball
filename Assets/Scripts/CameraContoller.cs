using UnityEngine;

namespace Assets.Scripts
{
    public class CameraContoller : MonoBehaviour
    {

        public GameObject Player;

        private Vector3 _offset;
        void Start ()
        {
            _offset = transform.position - Player.transform.position;
        }
	
        // Update is called once per frame
        void LateUpdate ()
        {
            transform.position = Player.transform.position + _offset;
        }
    }
}

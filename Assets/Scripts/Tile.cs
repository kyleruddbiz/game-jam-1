using UnityEngine;

namespace VoidScribe
{
    public class Tile : MonoBehaviour
    {
        private void OnMouseUp()
        {
            transform.Rotate(Vector3.forward, 60f);
        }
    }
}
using UnityEngine;

namespace VoidScribe
{
    public class Tile : MonoBehaviour
    {
        private void OnMouseUp()
        {
            transform.Rotate(0f, 0f, -60f);
        }
    }
}
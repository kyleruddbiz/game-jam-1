using UnityEngine;

namespace VoidScribe
{
    public class HexTile_Visual : MonoBehaviour
    {
        [SerializeField] private Transform pivot;
        [SerializeField] private SpriteRenderer hexagon;
        [SerializeField] private Transform[] edges;

        private void Awake()
        {
            for (int i = 0; i < edges.Length; i++)
            {
                edges[i].RotateAround(pivot.position, Vector3.forward, i * -60f);
            }
        }

        public void ApplyData(ColorSchemeData colorSchemeData, HexPatternData edgePatternData, HexPatternData veinPatternData)
        {
            hexagon.color = colorSchemeData.BackgroundColor;

            for (int i = 0; i < edges.Length; i++)
            {
                ColorSelection colorSelection = edgePatternData.ColorSelections[i];

                if (colorSelection == ColorSelection.Blank)
                {
                    edges[i].gameObject.SetActive(false);
                }
                else
                {
                    edges[i].gameObject.SetActive(true);
                    edges[i].gameObject.GetComponent<SpriteRenderer>().color = colorSchemeData.GetInnerColor(colorSelection);
                }
            }
        }

        public void ApplyRotation(int rotationIndex)
        {
            transform.rotation = Quaternion.Euler(0, 0, rotationIndex * -60f);
        }
    }
}
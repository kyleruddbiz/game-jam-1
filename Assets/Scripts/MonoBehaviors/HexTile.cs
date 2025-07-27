using System;
using UnityEngine;

namespace VoidScribe
{
    public class HexTile : MonoBehaviour
    {
        [Header("(Internal)")]
        [SerializeField] private SpriteRenderer visual;

        [Header("Fields")]
        [SerializeField] private ColorSchemeData colorSchemeData;
        [SerializeField] private HexPatternData edgePatternData;
        [SerializeField] private HexPatternData veinPatternData;
        [SerializeField][Range(0, 5)] private int rotationIndex;

        private void Awake()
        {
            visual.color = colorSchemeData.BackgroundColor;

            ApplyRotation();
        }

        private void OnMouseUp()
        {
            rotationIndex = (rotationIndex + 1) % 6;

            ApplyRotation();
        }

        private void ApplyRotation()
        {
            transform.rotation = Quaternion.Euler(0, 0, rotationIndex * -60f);
        }
    }
}
using System;
using UnityEngine;

namespace VoidScribe
{
    public class HexTile : MonoBehaviour
    {
        [Header("(Internal)")]
        [SerializeField] private HexTile_Visual visual;

        [Header("Fields")]
        [SerializeField] private ColorSchemeData colorSchemeData;
        [SerializeField] private HexPatternData edgePatternData;
        [SerializeField] private HexPatternData veinPatternData;
        [SerializeField][Range(0, 5)] private int rotationIndex;

        private void Awake()
        {
            visual.ApplyData(colorSchemeData, edgePatternData, veinPatternData);
            visual.ApplyRotation(rotationIndex);
        }

        private void OnMouseUp()
        {
            rotationIndex = (rotationIndex + 1) % 6;

            visual.ApplyRotation(rotationIndex);
        }
    }
}
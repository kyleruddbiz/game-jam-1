using System;
using UnityEngine;

namespace VoidScribe
{
    [CreateAssetMenu(fileName = "HexPatternData", menuName = "VoidScribe/Data/HexPattern")]
    public class HexPatternData : ScriptableObject
    {
        [field: SerializeField] public ColorSelection[] ColorSelections { get; private set; } = new ColorSelection[6];

        private void OnValidate()
        {
            if (ColorSelections.Length != 6)
            {
                throw new Exception("HexPatternData must have exactly 6 color selections.");
            }
        }
    }
}
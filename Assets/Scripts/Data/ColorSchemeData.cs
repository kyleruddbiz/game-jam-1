using System;
using UnityEngine;

namespace VoidScribe
{
    [CreateAssetMenu(fileName = "ColorSchemeData", menuName = "VoidScribe/Data/ColorScheme")]
    public class ColorSchemeData : ScriptableObject
    {
        [field: SerializeField] public Color BackgroundColor { get; private set; } = Color.white;
        [field: SerializeField] public Color InnerColor1 { get; private set; } = Color.red;
        [field: SerializeField] public Color InnerColor2 { get; private set; } = Color.green;

        public Color GetInnerColor(ColorSelection colorSelection)
        {
            return colorSelection switch
            {
                ColorSelection.Color1 => InnerColor1,
                ColorSelection.Color2 => InnerColor2,
                _ => throw new ArgumentOutOfRangeException(nameof(colorSelection), colorSelection, null)
            };
        }
    }
}
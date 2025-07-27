using UnityEngine;

namespace VoidScribe
{
    [CreateAssetMenu(fileName = "ColorSchemeData", menuName = "VoidScribe/Data/ColorScheme")]
    public class ColorSchemeData : ScriptableObject
    {
        [field: SerializeField] public Color BackgroundColor { get; private set; } = Color.white;
        [field: SerializeField] public Color InnerColor1 { get; private set; } = Color.red;
        [field: SerializeField] public Color InnerColor2 { get; private set; } = Color.green;
    }
}
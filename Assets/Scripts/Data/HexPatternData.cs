using UnityEngine;

namespace VoidScribe
{
    [CreateAssetMenu(fileName = "HexPatternData", menuName = "VoidScribe/Data/HexPattern")]
    public class HexPatternData : ScriptableObject
    {
        [field: SerializeField] public ColorSelection ColorSelection0 { get; private set; }
        [field: SerializeField] public ColorSelection ColorSelection1 { get; private set; }
        [field: SerializeField] public ColorSelection ColorSelection2 { get; private set; }
        [field: SerializeField] public ColorSelection ColorSelection3 { get; private set; }
        [field: SerializeField] public ColorSelection ColorSelection4 { get; private set; }
        [field: SerializeField] public ColorSelection ColorSelection5 { get; private set; }
    }
}
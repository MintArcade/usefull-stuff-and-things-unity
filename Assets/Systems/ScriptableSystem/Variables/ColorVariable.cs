using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Color", menuName = "Scriptable/Variables/Color")]
    public class ColorVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Color Value;

        public void SetValue(Color value)
        {
            Value = value;
        }

        public void SetValue(ColorVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Color amount)
        {
            Value = amount;
        }

        public void ApplyChange(ColorVariable amount)
        {
            Value = amount.Value;
        }
    }
}
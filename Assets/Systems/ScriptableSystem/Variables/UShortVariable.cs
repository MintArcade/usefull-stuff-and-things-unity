using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Ushort", menuName = "Scriptable/Variables/Ushort")]
    public class UShortVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public ushort Value;

        public void SetValue(ushort value)
        {
            Value = value;
        }

        public void SetValue(UShortVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(ushort amount)
        {
            Value = amount;
        }

        public void ApplyChange(UShortVariable amount)
        {
            Value = amount.Value;
        }
    }
}
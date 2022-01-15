using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Uint", menuName = "Scriptable/Variables/Uint")]
    public class UIntVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public uint Value;

        public void SetValue(uint value)
        {
            Value = value;
        }

        public void SetValue(UIntVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(uint amount)
        {
            Value += amount;
        }

        public void ApplyChange(UIntVariable amount)
        {
            Value += amount.Value;
        }
    }
}

using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Ulong", menuName = "Scriptable/Variables/Ulong")]
    public class ULongVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public ulong Value;

        public void SetValue(ulong value)
        {
            Value = value;
        }

        public void SetValue(ULongVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(ulong amount)
        {
            Value = amount;
        }

        public void ApplyChange(ULongVariable amount)
        {
            Value = amount.Value;
        }
    }
}
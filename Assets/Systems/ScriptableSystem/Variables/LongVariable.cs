using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Long", menuName = "Scriptable/Variables/Long")]
    public class LongVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public long Value;

        public void SetValue(long value)
        {
            Value = value;
        }

        public void SetValue(LongVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(long amount)
        {
            Value = amount;
        }

        public void ApplyChange(LongVariable amount)
        {
            Value = amount.Value;
        }
    }
}
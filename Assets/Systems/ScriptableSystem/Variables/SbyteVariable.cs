using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Sbyte", menuName = "Scriptable/Variables/Sbyte")]
    public class SbyteVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public sbyte Value;

        public void SetValue(sbyte value)
        {
            Value = value;
        }

        public void SetValue(SbyteVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(sbyte amount)
        {
            Value = amount;
        }

        public void ApplyChange(SbyteVariable amount)
        {
            Value = amount.Value;
        }
    }
}
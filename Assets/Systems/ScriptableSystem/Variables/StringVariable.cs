using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "String", menuName = "Scriptable/Variables/String")]
    public class StringVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public string Value;

        public void SetValue(string value)
        {
            Value = value;
        }

        public void SetValue(StringVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(string amount)
        {
            Value = amount;
        }

        public void ApplyChange(StringVariable amount)
        {
            Value = amount.Value;
        }
    }
}

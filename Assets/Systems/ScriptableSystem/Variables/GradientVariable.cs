using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Gradient", menuName = "Scriptable/Variables/Gradient")]
    public class GradientVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Gradient Value;

        public void SetValue(Gradient value)
        {
            Value = value;
        }

        public void SetValue(GradientVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Gradient amount)
        {
            Value = amount;
        }

        public void ApplyChange(GradientVariable amount)
        {
            Value = amount.Value;
        }
    }
}
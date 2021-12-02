using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Curve", menuName = "Scriptable/Variables/Curve")]
    public class CurveVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public AnimationCurve Value;

        public void SetValue(AnimationCurve value)
        {
            Value = value;
        }

        public void SetValue(CurveVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(AnimationCurve amount)
        {
            Value = amount;
        }

        public void ApplyChange(CurveVariable amount)
        {
            Value = amount.Value;
        }
    }
}
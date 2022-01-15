using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Rect", menuName = "Scriptable/Variables/Rect")]
    public class RectVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Rect Value;

        public void SetValue(Rect value)
        {
            Value = value;
        }

        public void SetValue(RectVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Rect amount)
        {
            Value = amount;
        }

        public void ApplyChange(RectVariable amount)
        {
            Value = amount.Value;
        }
    }
}
using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Bounds", menuName = "Scriptable/Variables/Bounds")]
    public class BoundsVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Bounds Value;

        public void SetValue(Bounds value)
        {
            Value = value;
        }

        public void SetValue(BoundsVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Bounds amount)
        {
            Value = amount;
        }

        public void ApplyChange(BoundsVariable amount)
        {
            Value = amount.Value;
        }
    }
}
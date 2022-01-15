using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "LayerMask", menuName = "Scriptable/Variables/LayerMask")]
    public class LayerMaskVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public LayerMask Value;

        public void SetValue(LayerMask value)
        {
            Value = value;
        }

        public void SetValue(LayerMaskVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(LayerMask amount)
        {
            Value = amount;
        }

        public void ApplyChange(LayerMaskVariable amount)
        {
            Value = amount.Value;
        }
    }
}
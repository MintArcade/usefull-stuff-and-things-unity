using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Material", menuName = "Scriptable/Variables/Material")]
    public class MaterialVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Material Value;

        public void SetValue(Material value)
        {
            Value = value;
        }

        public void SetValue(MaterialVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Material amount)
        {
            Value = amount;
        }

        public void ApplyChange(MaterialVariable amount)
        {
            Value = amount.Value;
        }
    }
}
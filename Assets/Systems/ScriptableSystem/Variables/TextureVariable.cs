using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Texture", menuName = "Scriptable/Variables/Texture")]
    public class TextureVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Texture Value;

        public void SetValue(Texture value)
        {
            Value = value;
        }

        public void SetValue(TextureVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Texture amount)
        {
            Value = amount;
        }

        public void ApplyChange(TextureVariable amount)
        {
            Value = amount.Value;
        }
    }
}
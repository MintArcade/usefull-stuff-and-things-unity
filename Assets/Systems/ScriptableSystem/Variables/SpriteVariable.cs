using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Sprite", menuName = "Scriptable/Variables/Sprite")]
    public class SpriteVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Sprite Value;

        public void SetValue(Sprite value)
        {
            Value = value;
        }

        public void SetValue(SpriteVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Sprite amount)
        {
            Value = amount;
        }

        public void ApplyChange(SpriteVariable amount)
        {
            Value = amount.Value;
        }
    }
}
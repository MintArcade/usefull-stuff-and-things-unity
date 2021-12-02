using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "GameObject", menuName = "Scriptable/Variables/GameObject")]
    public class GameObjectVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public GameObject Value;

        public void SetValue(GameObject value)
        {
            Value = value;
        }

        public void SetValue(GameObjectVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(GameObject amount)
        {
            Value = amount;
        }

        public void ApplyChange(GameObjectVariable amount)
        {
            Value = amount.Value;
        }
    }
}
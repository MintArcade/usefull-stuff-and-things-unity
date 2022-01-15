using System;
using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Char", menuName = "Scriptable/Variables/Char")]
    public class CharVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Char Value;

        public void SetValue(Char value)
        {
            Value = value;
        }

        public void SetValue(CharVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Char amount)
        {
            Value = amount;
        }

        public void ApplyChange(CharVariable amount)
        {
            Value = amount.Value;
        }
    }
}
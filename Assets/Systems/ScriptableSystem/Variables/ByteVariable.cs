using System;
using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Byte", menuName = "Scriptable/Variables/Byte")]
    public class ByteVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Byte Value;

        public void SetValue(Byte value)
        {
            Value = value;
        }

        public void SetValue(ByteVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Byte amount)
        {
            Value = amount;
        }

        public void ApplyChange(ByteVariable amount)
        {
            Value = amount.Value;
        }
    }
}
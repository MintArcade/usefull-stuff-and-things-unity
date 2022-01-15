using System;
using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Double", menuName = "Scriptable/Variables/Double")]
    public class DoubleVariable : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Double Value;

        public void SetValue(Double value)
        {
            Value = value;
        }

        public void SetValue(DoubleVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Double amount)
        {
            Value = amount;
        }

        public void ApplyChange(DoubleVariable amount)
        {
            Value = amount.Value;
        }
    }
}
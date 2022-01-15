using System;
using UnityEngine;

namespace ScriptableSystem
{
    [Serializable]
    public class UShortReference
    {
        public bool UseConstant = true;
        public ushort ConstantValue;
        public UShortVariable Variable;

        public UShortReference()
        { }

        public UShortReference(ushort value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public ushort Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator ushort(UShortReference reference)
        {
            return reference.Value;
        }
    }
}
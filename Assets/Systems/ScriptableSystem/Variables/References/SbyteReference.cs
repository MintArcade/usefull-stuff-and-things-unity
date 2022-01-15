using System;
using UnityEngine;

namespace ScriptableSystem
{
    [Serializable]
    public class SbyteReference
    {
        public bool UseConstant = true;
        public sbyte ConstantValue;
        public SbyteVariable Variable;

        public SbyteReference()
        { }

        public SbyteReference(sbyte value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public sbyte Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator sbyte(SbyteReference reference)
        {
            return reference.Value;
        }
    }
}
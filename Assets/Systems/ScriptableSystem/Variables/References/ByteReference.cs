using System;
using UnityEngine;

namespace ScriptableSystem
{
    [Serializable]
    public class ByteReference
    {
        public bool UseConstant = true;
        public Byte ConstantValue;
        public ByteVariable Variable;

        public ByteReference()
        { }

        public ByteReference(Byte value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public Byte Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator Byte(ByteReference reference)
        {
            return reference.Value;
        }
    }
}
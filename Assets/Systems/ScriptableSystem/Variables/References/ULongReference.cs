using System;

namespace ScriptableSystem
{
    [Serializable]
    public class ULongReference
    {
        public bool UseConstant = true;
        public ulong ConstantValue;
        public ULongVariable Variable;

        public ULongReference()
        { }

        public ULongReference(ulong value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public ulong Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator ulong(ULongReference reference)
        {
            return reference.Value;
        }
    }
}
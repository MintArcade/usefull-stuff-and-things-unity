using System;

namespace ScriptableSystem
{
    [Serializable]
    public class LongReference
    {
        public bool UseConstant = true;
        public long ConstantValue;
        public LongVariable Variable;

        public LongReference()
        { }

        public LongReference(long value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public long Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator long(LongReference reference)
        {
            return reference.Value;
        }
    }
}
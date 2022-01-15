using System;


namespace ScriptableSystem
{
    [Serializable]
    public class UIntReference
    {
        public bool UseConstant = true;
        public uint ConstantValue;
        public UIntVariable Variable;

        public UIntReference()
        { }

        public UIntReference(uint value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public uint Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator uint(UIntReference reference)
        {
            return reference.Value;
        }
    }
}
using System;
using UnityEngine;

namespace ScriptableSystem
{
    [Serializable]
    public class CharReference
    {
        public bool UseConstant = true;
        public Char ConstantValue;
        public CharVariable Variable;

        public CharReference()
        { }

        public CharReference(Char value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public Char Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator Char(CharReference reference)
        {
            return reference.Value;
        }
    }
}
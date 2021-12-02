using System;
using UnityEngine;

namespace ScriptableSystem
{
    [Serializable]
    public class GradientReference
    {
        public bool UseConstant = true;
        public Gradient ConstantValue;
        public GradientVariable Variable;

        public GradientReference()
        { }

        public GradientReference(Gradient value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public Gradient Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator Gradient(GradientReference reference)
        {
            return reference.Value;
        }
    }
}
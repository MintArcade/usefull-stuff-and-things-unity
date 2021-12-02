using System;
using UnityEngine;

namespace ScriptableSystem
{
    [Serializable]
    public class CurveReference
    {
        public bool UseConstant = true;
        public AnimationCurve ConstantValue;
        public CurveVariable Variable;

        public CurveReference()
        { }

        public CurveReference(AnimationCurve value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public AnimationCurve Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator AnimationCurve(CurveReference reference)
        {
            return reference.Value;
        }
    }
}

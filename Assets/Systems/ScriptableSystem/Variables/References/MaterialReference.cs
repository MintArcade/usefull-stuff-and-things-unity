using System;
using UnityEngine;

namespace ScriptableSystem
{
    [Serializable]

    public class MaterialReference
    {
        public bool UseConstant = true;
        public Material ConstantValue;
        public MaterialVariable Variable;

        public MaterialReference()
        { }

        public MaterialReference(Material value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public Material Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator Material(MaterialReference reference)
        {
            return reference.Value;
        }
    }
}

using System;
using UnityEngine;

namespace ScriptableSystem
{
    [Serializable]
    public class GameObjectReference
    {
        public bool UseConstant = true;
        public GameObject ConstantValue;
        public GameObjectVariable Variable;

        public GameObjectReference()
        { }

        public GameObjectReference(GameObject value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public GameObject Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator GameObject(GameObjectReference reference)
        {
            return reference.Value;
        }
    }
}
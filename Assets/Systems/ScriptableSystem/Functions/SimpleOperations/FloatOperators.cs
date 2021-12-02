using UnityEngine;
using UnityEngine.Events;

namespace ScriptableSystem
{
	[DisallowMultipleComponent]
	public class FloatOperators : MonoBehaviour
	{

		public enum Operator
		{
			Add, Substract, Multiply, Devide, Modulo, Set
		}

		public FloatVariable a;
		public Operator _operator;
		public FloatReference b;

		public UnityEvent Finish;

		public void Execute()
		{
			switch (_operator)
			{
				case Operator.Add:
					a.Value = a.Value + b.Value;
					break;
				case Operator.Substract:
					a.Value = a.Value - b.Value;
					break;
				case Operator.Multiply:
					a.Value = a.Value * b.Value;
					break;
				case Operator.Devide:
					a.Value = a.Value / b.Value;
					break;
				case Operator.Modulo:
					a.Value = a.Value % b.Value;
					break;
				case Operator.Set:
					a.Value = b.Value;
					break;
				default:
					break;
			}
			Finish.Invoke();
		}

	}
}

using UnityEngine;
using UnityEngine.Events;

namespace ScriptableSystem
{

	[DisallowMultipleComponent]
	public class IntOperators : MonoBehaviour
	{

		public enum Operator
		{
			Add, Substract, Multiply, Devide, Modulo, Set, LessThan, LessOrEqual, Equal, NotEqual, GreaterOrEqual, GreaterThan
		}

		public IntVariable a;
		public Operator _operator;
		public IntReference b;

		public UnityEvent CompareDone;
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
				case Operator.LessThan:
					if (a.Value < b.Value) CompareDone.Invoke();
					break;
				case Operator.LessOrEqual:
					if (a.Value <= b.Value) CompareDone.Invoke();
					break;
				case Operator.Equal:
					if (a.Value == b.Value) CompareDone.Invoke();
					break;
				case Operator.NotEqual:
					if (a.Value != b.Value) CompareDone.Invoke();
					break;
				case Operator.GreaterOrEqual:
					if (a.Value >= b.Value) CompareDone.Invoke();
					break;
				case Operator.GreaterThan:
					if (a.Value > b.Value) CompareDone.Invoke();
					break;
				default:
					break;
			}

			Finish.Invoke();
		}

	}

}
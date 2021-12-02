using System.Collections.Generic;
using UnityEngine;

namespace ScriptableSystem
{
	public abstract class RuntimeGroup<T> : ScriptableObject
	{
		public List<T> items = new List<T>();

		public void Add(T groupMember)
		{
			if (!items.Contains(groupMember))
			{
				items.Add(groupMember);
			}
		}

		public void Remove(T groupMember)
		{
			if (items.Contains(groupMember))
			{
				items.Remove(groupMember);
			}
		}
	}
}
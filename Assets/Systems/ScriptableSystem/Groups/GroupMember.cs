using System.Collections.Generic;
using UnityEngine;

namespace ScriptableSystem
{
	public class GroupMember : MonoBehaviour
	{
		public List<RuntimeGroupSet> runtimeGroups;

		private void OnEnable()
		{
			foreach (var item in runtimeGroups)
			{
				item.Add(this);
			}
		}

		private void OnDisable()
		{
			foreach (var item in runtimeGroups)
			{
				item.Remove(this);
			}
		}
	} 
}

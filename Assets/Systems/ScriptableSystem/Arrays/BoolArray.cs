using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "BoolArray", menuName = "Scriptable/Arrays/Bool")]
	public class BoolArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public BoolReference[] BoolReferences;
	}

}
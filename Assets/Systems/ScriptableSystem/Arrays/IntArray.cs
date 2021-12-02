using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "IntArray", menuName = "Scriptable/Arrays/Int")]
	public class IntArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public IntReference[] IntReferences;
	}

}
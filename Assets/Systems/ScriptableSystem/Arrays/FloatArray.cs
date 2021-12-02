using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "FloatArray", menuName = "Scriptable/Arrays/Float")]
	public class FloatArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public FloatReference[] floatReferences;
	}

}
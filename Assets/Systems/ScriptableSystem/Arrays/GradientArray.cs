using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "GradientArray", menuName = "Scriptable/Arrays/Gradient")]
	public class GradientArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public GradientReference[] GradientReferences;
	}

}
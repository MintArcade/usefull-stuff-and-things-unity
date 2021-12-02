using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "ColorArray", menuName = "Scriptable/Arrays/Color")]
	public class ColorArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public ColorReference[] ColorReferences;
	}

}
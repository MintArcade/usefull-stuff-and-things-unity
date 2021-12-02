using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "MaterialArray", menuName = "Scriptable/Arrays/Material")]
	public class MaterialArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public MaterialReference[] MaterialReferences;
	}

}
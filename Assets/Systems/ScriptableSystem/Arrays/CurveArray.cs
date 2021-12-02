using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "CurveArray", menuName = "Scriptable/Arrays/Curve")]
	public class CurveArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public CurveReference[] CurveReferences;
	}

}
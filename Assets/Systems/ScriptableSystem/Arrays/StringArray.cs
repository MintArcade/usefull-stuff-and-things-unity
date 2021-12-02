using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "StringArray", menuName = "Scriptable/Arrays/String")]
	public class StringArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public StringReference[] StringReferences;
	}

}
using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "Vector3Array", menuName = "Scriptable/Arrays/Vector3")]
	public class Vector3Array : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public Vector3Reference[] Vector3References;
	}

}
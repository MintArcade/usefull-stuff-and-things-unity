using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "Vector2Array", menuName = "Scriptable/Arrays/Vector2")]
	public class Vector2Array : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public Vector2Reference[] Vector2References;
	}

}
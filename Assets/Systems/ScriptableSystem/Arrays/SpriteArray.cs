using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "SpriteArray", menuName = "Scriptable/Arrays/Sprite")]
	public class SpriteArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public SpriteReference[] SpriteReferences;
	}

}
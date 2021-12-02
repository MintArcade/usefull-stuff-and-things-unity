using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "TextureArray", menuName = "Scriptable/Arrays/Texture")]
	public class TextureArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public TextureReference[] TextureReferences;
	}

}
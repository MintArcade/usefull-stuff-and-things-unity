using UnityEngine;

namespace ScriptableSystem
{
	[CreateAssetMenu(fileName = "GameObjectArray", menuName = "Scriptable/Arrays/GameObject")]
	public class GameObjectArray : ScriptableObject
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
		public GameObjectReference[] GameObjectReferences;
	}

}
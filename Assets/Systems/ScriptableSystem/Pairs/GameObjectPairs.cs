using System.Collections.Generic;
using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Game Objects", menuName = "Scriptable/Pairs/Game Objects")]
    public class GameObjectPairs : ScriptableObject
    {
        public List<GameObjectPair> list;
    }

    [System.Serializable]
    public struct GameObjectPair
	{
        public string key;
        public GameObjectReference value;
	}
}
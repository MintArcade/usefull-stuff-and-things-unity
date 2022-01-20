using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Tag Event Link", menuName = "Scriptable/Link/Tag -> Event")]
    public class TagEventLink : ScriptableObject
    {
        public TagEventStruct link;
    }

    [System.Serializable]
    public struct TagEventStruct
    {
        public Tag tag;
        public GameEvent gameEvent;
    }
}
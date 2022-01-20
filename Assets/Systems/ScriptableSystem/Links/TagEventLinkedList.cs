using System.Collections.Generic;
using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(fileName = "Tag Event list", menuName = "Scriptable/List/Link/Tag -> Event")]
    public class TagEventLinkedList : ScriptableObject
    {
        public List<TagEventStruct> links;

    }
}

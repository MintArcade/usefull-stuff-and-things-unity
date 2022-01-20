using ScriptableSystem;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class TagCollider : MonoBehaviour
{
	public TagEventLinkedList tagEventLinkedList;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.GetComponent<TagComponent>())
		{
			Tag[] tags = collision.gameObject.GetComponent<TagComponent>().tags;
			foreach (var item in tagEventLinkedList.links)
			{
				foreach (var tag in tags)
				{
					if (item.tag == tag)
					{
						item.gameEvent.Raise();
					}
				}
			}
		}
		
	}
}

using UnityEngine;
using UnityEngine.Events;

namespace Nodes
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	public class NodeCollision : MonoBehaviour
	{
		public GameObject otherGameObject;
		public UnityEvent CollisionEnterEvent;
		public UnityEvent CollisionExitEvent;
		public UnityEvent CollisionStayEvent;

		private void OnCollisionEnter(Collision collision)
		{
			if (otherGameObject == null || ReferenceEquals(otherGameObject, collision.gameObject))
			{
				CollisionEnterEvent.Invoke();
			}
		}

		private void OnCollisionExit(Collision collision)
		{
			if (otherGameObject == null || ReferenceEquals(otherGameObject, collision.gameObject))
			{
				CollisionExitEvent.Invoke();
			}
		}

		private void OnCollisionStay(Collision collision)
		{
			if (otherGameObject == null || ReferenceEquals(otherGameObject, collision.gameObject))
			{
				CollisionStayEvent.Invoke();
			}
		}
	}
}

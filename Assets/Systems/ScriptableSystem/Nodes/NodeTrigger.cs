using UnityEngine;
using UnityEngine.Events;

namespace Nodes
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	public class NodeTrigger : MonoBehaviour
	{
		public GameObject otherGameObject;
		public UnityEvent TriggerEnterEvent;
		public UnityEvent TriggerExitEvent;
		public UnityEvent TriggerStayEvent;

		private void OnTriggerEnter(Collider other)
		{
			if (otherGameObject == null || ReferenceEquals(otherGameObject, other.gameObject))
			{
				TriggerEnterEvent.Invoke();
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (otherGameObject == null || ReferenceEquals(otherGameObject, other.gameObject))
			{
				TriggerExitEvent.Invoke();
			}
		}

		private void OnTriggerStay(Collider other)
		{
			if (otherGameObject == null || ReferenceEquals(otherGameObject, other.gameObject))
			{
				TriggerStayEvent.Invoke();
			}
		}
	}
}

using UnityEngine;
using UnityEngine.Events;

namespace Nodes
{
	[RequireComponent(typeof(Collider))]
	public class NodeMouse3D : MonoBehaviour
	{
		public UnityEvent MouseUpAsButtonEvent;
		public UnityEvent MouseDownEvent;

		private void OnMouseUpAsButton()
		{
			MouseUpAsButtonEvent.Invoke();
		}

		private void OnMouseDown()
		{
			MouseDownEvent.Invoke();
		}
		/*
		private void OnMouseDrag()
		{

		}

		private void OnMouseEnter()
		{

		}

		private void OnMouseExit()
		{

		}

		private void OnMouseOver()
		{

		}

		private void OnMouseUp()
		{

		}
		*/
	}
}

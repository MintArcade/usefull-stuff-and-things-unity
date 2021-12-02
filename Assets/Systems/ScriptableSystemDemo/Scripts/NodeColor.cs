using ScriptableSystem;
using UnityEngine;

namespace Nodes
{
	[RequireComponent(typeof(MeshRenderer))]
	public class NodeColor : MonoBehaviour
	{
		[SerializeField] private bool noRepeats;
		public ColorArray array;
		private MeshRenderer meshRenderer;
		private byte lastIndex;
		private byte index;

		private void Awake()
		{
			meshRenderer = GetComponent<MeshRenderer>();
		}

		public void SetRandomColor()
		{
			int max = array.ColorReferences.Length;
			if (noRepeats)
			{
				for (int i = 0; i < 1000; i++)
				{
					index = (byte)Random.Range(0, max);
					if (index != lastIndex)
					{
						break;
					}
				}
			}
			else
			{
				index = (byte)Random.Range(0, max);
			}
			meshRenderer.material.color = array.ColorReferences[index].Value;
		}

	}
}

using UnityEngine;

namespace ScriptableSystem
{
	public class ScriptableSystemDemo : MonoBehaviour
	{
		// Ints

		public uint a;
		public ulong b;
		public ushort c;
		public byte d;
		public sbyte i;
		public short j; // From -32768 to 32767 
		public ushort k; // From 0 to 65535 
		public long l;

		// Floats

		public double g;

		// Symbols

		public char e;
		public decimal f; // HIDEN

		public object h; // HIDEN

		public Bounds bounds;
		public BoundsInt boundsInt;

		//public BoneWeight boneWeight;
		//public BoneWeight1 boneWeight1;

		public Color color;
		public Color32 color32;
		public LayerMask layerMask;

		public Matrix4x4 matrix4X4;

		public Quaternion quaternion;

		public Rect rect;
		public RectInt rectInt;

		public Space space;

		private void Start()
		{

			//boundsInt.Contains

		}
	} 
}

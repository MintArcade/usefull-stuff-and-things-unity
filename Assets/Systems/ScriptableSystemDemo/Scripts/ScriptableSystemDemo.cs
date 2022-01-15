using UnityEngine;

namespace ScriptableSystem
{
	public class ScriptableSystemDemo : MonoBehaviour
	{
		// Ints

		public IntReference intReference;
		public BoundsVariable boundsVariable;
		public ByteReference byteReference;
		public CharReference charReference;
		public DoubleReference doubleReference;
		public LayerMaskReference layerMaskReference;
		public LongReference longReference;
		public RectVariable rectVariable;
		public SbyteReference sbyteReference;
		public UIntReference uIntReference;
		public ULongReference uLongReference;
		public UShortReference uShortReference;



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

using UnityEngine;
using UnityEngine.UI;

namespace ScriptableSystem
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Text))]
	public class UIShowIntVariable : MonoBehaviour
	{
		public IntReference intVariable;

		private Text text;

		private void Awake()
		{
			text = GetComponent<Text>();
		}

		public void Execute()
		{
			text.text = intVariable.Value.ToString();
		}

	}
}
using Leguar.TotalJSON;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get array lenght from JSON")]
	[ActionCategory("TotalJSON")]
	public class JsonGetArrayLenght : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Json String")]
		public FsmString jsonData;

		[RequiredField]
		[Tooltip("Json Field")]
		public FsmString jsonField;

		[ActionSection("Result")]
		public FsmInt lenght;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			JSON jSON = JSON.ParseString(jsonData.Value);
			jSON.SetProtected();
			JArray jsonArray = jSON.GetJArray(jsonField.Value);
			lenght.Value = jsonArray.Length;
			Finish();
		}


	}

}

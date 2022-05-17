using Leguar.TotalJSON;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check, if JSON have the key")]
	[ActionCategory("TotalJSON")]
	public class JsonContainsKey : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Json String")]
		public FsmString jsonData;

		[RequiredField]
		[Tooltip("Json Field")]
		public FsmString jsonField;

		[ActionSection("Return")]
		public FsmEvent ContainsKey;
		public FsmEvent DoNotContainsKey;
		[Tooltip("ContainsKey")]
		public FsmBool boolValue;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			JSON jSON = JSON.ParseString(jsonData.Value);
			jSON.SetProtected();

			boolValue.Value = jSON.ContainsKey(jsonField.Value);
			Fsm.Event(boolValue.Value ? ContainsKey : DoNotContainsKey);

			Finish();
		}


	}

}

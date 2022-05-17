using Leguar.TotalJSON;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Remove keys from JSON")]
	[ActionCategory("TotalJSON")]
	public class JsonRemoveKeys : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Json String")]
		public FsmString jsonData;

		[RequiredField]
		public FsmString[] stringKeys;

		[ActionSection("Settings")]
		public FsmBool debug;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			JSON jsonObject = JSON.ParseString(jsonData.Value);
			if (debug.Value) jsonObject.DebugInEditor("Remove values from JSON");
			for (int i = 0; i < stringKeys.Length; i++)
			{
				jsonObject.Remove(stringKeys[i].ToString());
			}
			jsonData.Value = jsonObject.CreatePrettyString();
			Finish();
		}


	}

}

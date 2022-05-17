using HutongGames.PlayMakerEditor;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class TotalJSONEditorUtils
{
	static TotalJSONEditorUtils()
	{
		Actions.AddCategoryIcon("TotalJSON", TotalJSONCategoryIcon);
	}

    private static Texture sTotalJSONCategoryIcon = null;
    internal static Texture TotalJSONCategoryIcon
    {
        get
        {
            if (sTotalJSONCategoryIcon == null)
                sTotalJSONCategoryIcon = Resources.Load<Texture>("window-icon_json");
            ;
            if (sTotalJSONCategoryIcon != null)
                sTotalJSONCategoryIcon.hideFlags = HideFlags.DontSaveInEditor;
            return sTotalJSONCategoryIcon;
        }
    }
}


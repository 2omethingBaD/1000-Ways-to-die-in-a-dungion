using UnityEngine;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{

	[System.Serializable]
	public class LcokActionsOFF : Action
	{

		// Declare properties here
		public override ActionCategory Category { get { return ActionCategory.Custom; } }
		public override string Title { get { return "turn off actions"; } }
		public override string Description { get { return "disable buttons"; } }


		// Declare variables here
		public GameObject BUTTONS;
		public GameObject TRIGGERS;
		public GameObject HOTSPOTS;
		public Texture2D _cursorDefault;
		private Vector2 _cursorHotspot;


		public override float Run()
		{
			BUTTONS = MyUtils.FindIncludingInactive("BUTTONS");
			TRIGGERS = MyUtils.FindIncludingInactive("TRIGGERS");
			HOTSPOTS = MyUtils.FindIncludingInactive("HOTSPOTS");

			_cursorHotspot = new Vector2(_cursorDefault.width / 2, _cursorDefault.height / 2);
			Cursor.SetCursor(_cursorDefault, _cursorHotspot, CursorMode.Auto);
			BUTTONS.gameObject.SetActive(false);
			TRIGGERS.gameObject.SetActive(false);
			HOTSPOTS.gameObject.SetActive(false);
			Debug.Log("mouse privlages gone!");
			return 0f;
		}


		public override void Skip()
		{
			Run();
		}


#if UNITY_EDITOR

		public override void ShowGUI()
		{
			//BUTTONS = (GameObject)EditorGUILayout.ObjectField("GameObject to affect:", BUTTONS, typeof(GameObject), true);
			_cursorDefault = (Texture2D)EditorGUILayout.ObjectField("InteractTexture:", _cursorDefault, typeof(Texture2D), true);
		}
#endif
	}
}
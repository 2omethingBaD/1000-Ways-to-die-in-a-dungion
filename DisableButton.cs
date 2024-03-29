using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{

	[System.Serializable]
	public class DisableButton : Action
	{

		// Declare properties here
		public override ActionCategory Category { get { return ActionCategory.Custom; } }
		public override string Title { get { return "turn off/on button"; } }
		public override string Description { get { return "no more buuto"; } }


		// Declare variables here
		GameObject BUTTONS;
		public Texture2D _cursorDefault;
		private Vector2 _cursorHotspot;


		public override float Run()
		{
			if (BUTTONS.activeSelf)
			{
				_cursorHotspot = new Vector2(_cursorDefault.width / 2, _cursorDefault.height / 2);
				Cursor.SetCursor(_cursorDefault, _cursorHotspot, CursorMode.Auto);
				BUTTONS.gameObject.SetActive(false);
				
				Debug.Log("no more button :(");
			}
			else
			{
				BUTTONS.gameObject.SetActive(true);
				Debug.Log("button time :)");
			}
			return 0f;
		}


		public override void Skip()
		{
			Run();
		}


#if UNITY_EDITOR

		public override void ShowGUI()
		{
			BUTTONS = (GameObject)EditorGUILayout.ObjectField("GameObject to affect:", BUTTONS, typeof(GameObject), true);
			_cursorDefault = (Texture2D)EditorGUILayout.ObjectField("InteractTexture:", _cursorDefault, typeof(Texture2D), true);
		}
#endif
	}
}

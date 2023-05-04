using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{

	[System.Serializable]
	public class LcokActionsON : Action
	{

		// Declare properties here
		public override ActionCategory Category { get { return ActionCategory.Custom; } }
		public override string Title { get { return "turn on actions"; } }
		public override string Description { get { return "enable buttons"; } }


		// Declare variables here
		public GameObject BUTTONS;
		public GameObject TRIGGERS;
		public GameObject HOTSPOTS;
		public Texture2D _cursorDefault;


		public override float Run()
		{
			BUTTONS = MyUtils.FindIncludingInactive("BUTTONS");
			TRIGGERS = MyUtils.FindIncludingInactive("TRIGGERS");
			HOTSPOTS = MyUtils.FindIncludingInactive("HOTSPOTS");

			BUTTONS.gameObject.SetActive(true);
			TRIGGERS.gameObject.SetActive(true);
			HOTSPOTS.gameObject.SetActive(true);
			Debug.Log("mouse time!");
			
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
		}
#endif
	}
}
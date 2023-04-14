using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    [SerializeField] public Texture2D _cursorDefault;
    [SerializeField] public Texture2D _cursorSpeak;
    [SerializeField] public Texture2D _cursorQuestion;
    [SerializeField] public Texture2D _cursorUse;
    [SerializeField] public Texture2D _cursorNorth;
    [SerializeField] public Texture2D _cursorEast;
    [SerializeField] public Texture2D _cursorSouth;
    [SerializeField] public Texture2D _cursorWest;
    private Vector2 _cursorHotspot;


    void Start()
    {
        Cursor.visible = true;
        _cursorHotspot = new Vector2(_cursorDefault.width / 2, _cursorDefault.height / 2);
        Cursor.SetCursor(_cursorDefault, _cursorHotspot, CursorMode.Auto);
    }


    public void OnCursorEnterSpeak()
    {
        _cursorHotspot = new Vector2(_cursorSpeak.width / 2, _cursorSpeak.height / 2);
        Cursor.SetCursor(_cursorSpeak, _cursorHotspot, CursorMode.Auto);
    }


    public void OnCursorEnterQuestion()
    {
        _cursorHotspot = new Vector2(_cursorQuestion.width / 2, _cursorQuestion.height / 2);
        Cursor.SetCursor(_cursorQuestion, _cursorHotspot, CursorMode.Auto);
    }


    public void OnCursorEnterUse()
    {
        _cursorHotspot = new Vector2(_cursorUse.width / 2, _cursorUse.height / 2);
        Cursor.SetCursor(_cursorUse, _cursorHotspot, CursorMode.Auto);
    }


    public void OnCursorEnterN()
    {
        _cursorHotspot = new Vector2(_cursorNorth.width / 2, _cursorUse.height / 2);
        Cursor.SetCursor(_cursorNorth, _cursorHotspot, CursorMode.Auto);
    }


    public void OnCursorEnterE()
    {
        _cursorHotspot = new Vector2(_cursorEast.width / 2, _cursorUse.height / 2);
        Cursor.SetCursor(_cursorEast, _cursorHotspot, CursorMode.Auto);
    }


    public void OnCursorEnterS()
    {
        _cursorHotspot = new Vector2(_cursorSouth.width / 2, _cursorUse.height / 2);
        Cursor.SetCursor(_cursorSouth, _cursorHotspot, CursorMode.Auto);
    }


    public void OnCursorEnterW()
    {
        _cursorHotspot = new Vector2(_cursorWest.width / 2, _cursorUse.height / 2);
        Cursor.SetCursor(_cursorWest, _cursorHotspot, CursorMode.Auto);
    }


    public void OnButtonCursorExit()
    {
        _cursorHotspot = new Vector2(_cursorDefault.width / 2, _cursorDefault.height / 2);
        Cursor.SetCursor(_cursorDefault, _cursorHotspot, CursorMode.Auto);
    }
}

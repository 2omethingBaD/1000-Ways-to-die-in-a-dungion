using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class FlashlightController : MonoBehaviour
{
    public float depth = 10.0f;
    public GameObject _flashlight;
    GVar _flashLightOn;


    private void Start()
    {
        _flashlight.gameObject.SetActive(false);
        _flashLightOn = AC.GlobalVariables.GetVariable(11);
    }


    void LateUpdate()
    {
        FollowMousePosition();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_flashlight.activeSelf)
            {
                _flashlight.gameObject.SetActive(false);
                _flashLightOn.BooleanValue = false;
            }
            else
            {
                _flashlight.gameObject.SetActive(true);
                _flashLightOn.BooleanValue = true;
            }
        }
    }


    void FollowMousePosition()
    {
        var mousePos = Input.mousePosition;
        var wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, depth)); //you need a new vector3 because of the variables it takes XYZ Z= depth
        transform.position = wantedPos;
    }
}

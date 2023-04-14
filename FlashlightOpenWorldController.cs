using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class FlashlightOpenWorldController : MonoBehaviour
{
    public GameObject _flashlight;
    GVar _flashLightOn;


    private void Start()
    {
        _flashlight.gameObject.SetActive(false);
        _flashLightOn = AC.GlobalVariables.GetVariable(11);
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
}

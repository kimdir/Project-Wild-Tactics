using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    public Text phaseDisplayTest;
    private Touch inputTouch;
    private float timeTouchEnded;
    private float displayTime = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            inputTouch = Input.GetTouch(0);

            if (inputTouch.phase == TouchPhase.Ended)
            {
                phaseDisplayText.text = inputTouch.phase.ToString();
                timeTouchEnded = Time.time;
            }    

            else if (Time.time - timeTouchEnded > displayTime)
            {
                phaseDisplayText.text = inputTouch.phase.ToString();
                timeTouchEnded = Time.time;
            }    
        }

        else if (Time.time - timeTouchEnded > displayTime)
        {
            phaseDisplayText.text = "";
        }    
    }
}

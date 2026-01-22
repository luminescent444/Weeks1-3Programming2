using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;
//SCRIPT TO VIBRATE THE CURSOR WHEN ITS SHOOTING
public class CursorVibrate : MonoBehaviour
{

    //INITIALIZING VARIABLES

    //float to control time
    public float t;

    //float to hold distance value
    public float distance;

    //curve to create the vibration
    public AnimationCurve curve;

    //float to hold the curve value to change the scale with
    public float currentCurve;

    //float to hold the default scale values
    public Vector3 startScale;
 
    //transform to allow access to the target's location
    public Transform targetTransform;

    //vector to hold the location of the target transform
    public Vector3 targetPos;

    //transform to allow access to the watermeter controller's values
    public Transform waterMeter;

    //to hold the controller's position
    public Vector3 waterMeterPos;

    void Start()
    {
     
        //set the scale vector with the default scale values
        startScale.x = 0.03f;
        startScale.y = 0.03f;

    }

    void Update()
    {
        //set the target position vector equal to the current target position
        targetPos = targetTransform.position;

        //update the current time
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        //get mouse position in meters
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //get distance between the target and mouse
        distance = Vector3.Distance(targetTransform.position, mousePos);

        //read the curve value and set it to the curve variable
        currentCurve = curve.Evaluate(t);

        //IF THE CURSOR IS OVER THE TARGET

        if (distance < 1)
        {
            //set the scale to the value of the curve 
            transform.localScale = startScale*currentCurve;

            //get the contrller's current position
            waterMeterPos = waterMeter.position;

            //add 0.01 to the controller's height
            waterMeterPos.y += 0.01f;

            //set the watermeter's position = to its position variable
            waterMeter.position = waterMeterPos;
        }

        //IF NOT

        else
        {

            //set the scale to its default
            transform.localScale = startScale;
        }


    }
}

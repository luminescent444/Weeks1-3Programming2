using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class CursorVibrate : MonoBehaviour
{

    //declare variables
    public float t;
    public float distance;
    public Vector2 target;
    public AnimationCurve curve;
    public float currentCurve;
    public Vector3 startScale;
    //public AnimationCurve lerpCurve;
    //public Transform startPoint;
    //public Transform endPoint;
    public Transform targetTransform;
    public Vector3 targetPos;
    public Transform waterMeter;
    public Vector3 waterMeterPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set target vector with the targets values
        //target.x = 0;
        //target.y = -3;

        //set the scale vector with correct scale values
        startScale.x = 0.03f;
        startScale.y = 0.03f;

    }

    // Update is called once per frame
    void Update()
    {

        targetPos = targetTransform.position;

        //update the current time
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        //move the target location
        //target = Vector2.Lerp(startPoint.position, endPoint.position, lerpCurve.Evaluate(t));

        //get mouse position in meters
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //get distance between circle and mouse
        distance = Vector3.Distance(targetTransform.position, mousePos);

        //"add the current time to a "t" variable"
        t += Time.deltaTime;

        //read the curve value and set it to a variable
        currentCurve = curve.Evaluate(t);

        //if the cursor is over the target

        if (distance < 1)
        {
            //set the scale to the value of the curve 
            transform.localScale = startScale*currentCurve;
            waterMeterPos = waterMeter.position;
            waterMeterPos.y += 0.01f;
            waterMeter.position = waterMeterPos;
        }
        else
        {
            transform.localScale = startScale;
        }


    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class codingGym2Vibrate : MonoBehaviour
{
    public AnimationCurve curve;
    public bool onSquare;
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position in meters
        //"new mouse position = convert pixels to meters (read the current mouse position)"
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        
        //get the distance between the square transform and the mouse position
        //"new float to hold distance value = use the distance vector 3 and find distance between (square current position, mouse position)
        float dist = Vector3.Distance(transform.position, mousePos);
        
        //count up in time
        //"add the current time to a "t" variable"
        t += Time.deltaTime;

        //get the current curve value
        //"check the current value of the curve and store it in a y float"
        float y = curve.Evaluate(t);



        //if the distance is less than 1, the mouse is on the square
        if (dist < 1)
        {
            onSquare = true;
        }

        //if the distance is greater than 1, the mouse is off the square
        if (dist>1)
        {
            onSquare = false;
        }

        //if the mouse is on the square, change all 3 scale values to y
        if (onSquare == true)
        {
            transform.localScale = Vector3.one * y;
        }

        //if the mouse is off the square, change all 3 scale values to 1
        if (onSquare == false)
        {
            transform.localScale = Vector3.one;
        }

        //reset the count of the t variable once it hits 1
        if (t > 1)
        {
            t = 0;
        }

    }
}

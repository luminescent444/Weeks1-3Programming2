using UnityEngine;
//SCRIPT TO MOVE THE TARGET BACK AND FORTH
public class TargetMovement : MonoBehaviour
{

    //iNITIALIZING VARIABLES

    //transforms to allow access to start and end locations
    public Transform start;
    public Transform end;

    //curve to control its movement
    public AnimationCurve curve;

    //variable to control time
    public float t;

    void Start()
    {
        
    }

    void Update()
    {

        //move time forward
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        //do linear interpolation between the start and end position
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

    }
}

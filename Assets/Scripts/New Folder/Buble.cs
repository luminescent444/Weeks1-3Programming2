using UnityEngine;
//SCIPT TO MANAGE MOVEMENT OF THE BUBBLE
public class Buble : MonoBehaviour
{

    //INITIALIZING VARIABLES 

    //curve to control its movement
    public AnimationCurve curve;

    //float to control time
    public float t;

    //transforms to allow access to start and end locations
    public Transform start;
    public Transform end;

    //vectors to allow editing of start and end positions
    public Vector2 startPos;
    public Vector2 endPos;

    //float to determine the x value that the bubble generates at each time
    public float randomX;

    void Start()
    {
        
    }

    void Update()
    {
        //controlling and looping the time variable
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;

            //EACH TIME TIME RESETS

            //generate a random x value within the water pipe
            randomX = Random.Range(-0.3f,0.3f);

            //get and store the start/end position's position
            startPos = start.position;
            endPos = end.position;

            //set that value as the x of start and end position vectors
            startPos.x = randomX;
            endPos.x = randomX;

            //set the start/end positions equal to the start/end vectors
            start.position = startPos;
            end.position = endPos;

        }

        //do linear interpolation between the start and end position
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}

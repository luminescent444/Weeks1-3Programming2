using UnityEngine;
//SCRIPT TO UPDATE THE PROGRESS BAR
public class WinMeter : MonoBehaviour
{

    //INITIALIZING VARIABLES

    //transform to allow access to the controller's position
    public Transform waterController;

    //vector to hold the controller's position
    public Vector3 currentControllerPos;

    //vector to hold the blinker's current position
    public Vector3 meter;

    void Start()
    {
        
    }

    void Update()
    {

        //IF THE BLINKER IS BELOW THE MAX WIN VALUE

        if(transform.position.x < -3)
        {

            //get and store the current position of the controller
            currentControllerPos = waterController.position;

            //get and store the current position of the blinker
            meter = transform.position;

            //set the blinke's x = to the controller's y (offset by a few meters to move it on top of the meter)
            meter.x = (currentControllerPos.y - 12);

            //set the blinker's transform = to the current stored value for it
            transform.position = meter;

        }

    }
}

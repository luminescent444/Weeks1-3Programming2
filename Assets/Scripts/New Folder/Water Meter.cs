using UnityEngine;
//SCRIPT TO MAKE THE WATER METER RISE
public class WaterMeter : MonoBehaviour
{

    //INITIALIZING VARIABLES VARIABLES

    //transform to allow access to the water controller's position  
    public Transform waterController;

    //vector to hold and edit the water meter's position
    public Vector3 currentPosition;

    //transform to allow access to the win text's position
    public Transform winText;

    //vector to hold and edit the text's position
    public Vector3 winTextPos;


    void Start()
    {
        
    }

    void Update()
    {
        
        //IF THE WATER LEVEL IS BELOW THE TOP

        if(waterController.position.y < 8.21)
        {

        //get and store the current position of the water meter 
        currentPosition = transform.position;

        //set the meter's y value = to the controller's
        currentPosition.y = waterController.position.y;

        //set the meter's transform to the current stored value
        transform.position = currentPosition;

        }
        
        //IF THE WATER LEVEL HITS THE TOP

        else
        {
            //move the win text's stored x and y to the middle
            winTextPos.x = 0;
            winTextPos.y = 0;

            //set the text's transform = to the stored value
            winText.position = winTextPos;

        }
    }
}

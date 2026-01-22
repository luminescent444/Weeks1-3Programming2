using UnityEngine;

public class WinMeter : MonoBehaviour
{
    public Transform waterController;
    public Vector3 currentControllerPos;
    public Vector3 meter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //the water meter's x = the controller's y -8

        if(transform.position.x < -3)
        {

            currentControllerPos = waterController.position;
            meter = transform.position;

            meter.x = (currentControllerPos.y - 12);
            transform.position = meter;

        }


        /*currentControllerPos = transform.position;
        currentControllerPos.y = waterController.position.y;
        transform.position = currentControllerPos;*/
    }
}

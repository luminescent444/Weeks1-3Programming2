using UnityEngine;

public class WaterMeter : MonoBehaviour
{
    public Transform waterController;
    public Vector3 currentPosition;
    public Transform winText;
    public Vector3 winTextPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(waterController.position.y < 8.21)
        {

        currentPosition = transform.position;
        currentPosition.y = waterController.position.y;
        transform.position = currentPosition;

        }
        else
        {
            //winTextPos = winText.position;
            winTextPos.x = 0;
            winTextPos.y = 0;
            winText.position = winTextPos;

        }
    }
}

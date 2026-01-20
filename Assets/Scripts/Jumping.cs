using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jumping : MonoBehaviour
{
    public bool jump = false;
    public AnimationCurve jumpPath;
    //public Transform start;
    public Vector2 startPos;
    public float t;
    public float speed=0.01f;
    public Vector2 blo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //jump = 


        //speed.x = 0;

    }

    // Update is called once per frame
    void Update()
    {

        //movement

        Vector2 newPos = transform.position;
        newPos.x += speed;
        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }





        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {   
            startPos=transform.position;
            speed = 0;
            Jump();
            speed = 0.01f;
             
        }
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

    }

    void Jump()
    { 

        transform.position = Vector2.Lerp(transform.position, blo, jumpPath.Evaluate(t));
    }

}

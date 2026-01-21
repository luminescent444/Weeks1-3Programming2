using UnityEngine;

public class linInt : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float t;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;
        if ( t > 1)
        {
            t = 0;
        }
        //move from x to y
        transform.position = Vector2.Lerp(startPoint.position, endPoint.position, curve.Evaluate(t));

    }
}

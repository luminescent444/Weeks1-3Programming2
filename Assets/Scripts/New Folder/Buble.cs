//using System.Net;
using UnityEngine;

public class Buble : MonoBehaviour
{
    public AnimationCurve curve;
    public float t;
    public Transform start;
    public Transform end;
    public Vector2 startpos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startpos.y = -2;
    }

    // Update is called once per frame
    void Update()
    {
        //make time pass
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(startpos, end.position, curve.Evaluate(t));
    }
}

//using System.Net;
using UnityEngine;

public class Buble : MonoBehaviour
{
    public AnimationCurve curve;
    public float t;
    public Transform start;
    public Transform end;
    public Vector2 startPos;
    public Vector2 endPos;
    public float randomX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make time pass
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;

            startPos = start.position;
            endPos = end.position;

            randomX = Random.Range(-0.3f,0.3f);

            startPos.x = randomX;
            endPos.x = randomX;

            start.position = startPos;
            end.position = endPos;

        }

        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}

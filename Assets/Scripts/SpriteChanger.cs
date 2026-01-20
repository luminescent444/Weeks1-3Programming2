using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

      

    }

    // Update is called once per frame
    void Update()
    {

        /*if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            PickARandomColor();
        }*/

        //get mousepos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //is it over the shape? (simpler way of doing distance that is possible with spriterenderer)
        if(spriteRenderer.bounds.Contains(mousePos) == true)
        //yes:use color variable
        {
            spriteRenderer.color = col;
        }
        else
        //no: set color to white
        {
            spriteRenderer.color = Color.white;
        }

    }

    //making function
    void PickARandomColor()
    {
        //spriteRenderer.color = Color.red;
        spriteRenderer.color = Random.ColorHSV();
        
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite mySprite;
    public Sprite[] barrels;
    public int randomNumber;

    //      LISTS AND INTERSCRIPT COMMUNICATION

    //public List <Sprite> barrels;     (you can add and subtract from lists while the game is running)
    //public RotateMe rotateMe;         (allows you to interface with another script's variables. set them by doing "rotateMe.speed = value" (script variable.variable in script to change = value) in update

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

      

    }

    // Update is called once per frame
    void Update()
    {
        //      LISTS
        //name of list.add/remove/etc(thing to add or remove)


        //      RANDOM COLOR FUNCTION CALL

        /*if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            PickARandomColor();
        }*/

        //      ROLLOVER

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

        //      KEYBOARD CLICK SPRITE CHANGE SPRITE CALL

        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            PickARandomSprite();
        }

    }

    void PickARandomColor()
    {
        //spriteRenderer.color = Color.red;
        spriteRenderer.color = Random.ColorHSV();
        
    }

    void PickARandomSprite()
    {
        //pick a random number
        randomNumber = Random.Range(0, barrels.Length);

        //use that number to choose and assign a sprite
        spriteRenderer.sprite = barrels[randomNumber];
    }
}

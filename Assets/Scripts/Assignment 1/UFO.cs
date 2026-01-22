using UnityEngine;
using UnityEngine.InputSystem;

public class UFO : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This function allows the UFO to be placed on top of the cursor and move around with it
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = mousePos;

        //The following part contains the code for the boundaries so that the UFO cannot leave the screen nor step on the floor
        //These are the boundaries for the vertical axis (I hand-picked the values)
        mousePos.y = Mathf.Clamp(mousePos.y, -1.54f, 4.57f);

        //These are the boundaries for the horizontal axis (simply respecting the screen width)
        Vector3 screenPos = Camera.main.WorldToScreenPoint(mousePos);
        screenPos.x = Mathf.Clamp(screenPos.x, 0, Screen.width);

        //Here I am simply returning the mouse position back to the world space
        mousePos = Camera.main.ScreenToWorldPoint(screenPos);
        transform.position = mousePos;
    }
}

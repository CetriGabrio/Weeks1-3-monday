using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector3 newPosition = transform.position;
            newPosition.y -= speed * Time.deltaTime;
            transform.position = transform.right * speed * Time.deltaTime;
        }
    }
}

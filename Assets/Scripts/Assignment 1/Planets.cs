using UnityEngine;

public class Planets : MonoBehaviour
{
    //This script is for the 2 planets that move and bounce at the edge of the screen

    //I serialized the speed variable to be able to edit it in the inspector directly for easier tuning
    [SerializeField]
    float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This part handles the movement of the planets
        //They move linearly to the right since the speed has a positive value
        //In the inspector I set the speed of the second planet to a negative value for the movement in opposite direction
        Vector2 newPosition = transform.position;
        newPosition.x += 1 * speed * Time.deltaTime;
        transform.position = newPosition;

        //The following part instead deals with the bouncing off the edges of the screen into the opposite direction
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            //As mentioned before, negative speed equal opposite direction
            speed = speed * -1;
        }
    }
}

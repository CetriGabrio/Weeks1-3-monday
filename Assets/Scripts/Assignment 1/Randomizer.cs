using UnityEngine;

public class Randomizer : MonoBehaviour
{
    //This script is for the alien that randomly changes position every few seconds

    //These are the variables for time and position on the y-axis (which I hand-picked to stay on the grass)
    private float interval = 3f;
    private float timer = 0f;

    private float minY = -4.04f;
    private float maxY = -2.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This part handles the timer, so when the timer is done, the alien changes position
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            //On the x-axis I decided to instead use the screen width so the alien is always on screen
            float minX = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
            float maxX = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;

            //This handles the random position between the 4 different values I have set previously
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);

            transform.position = new Vector2(x, y);

            timer = 0f;
        }
    }
}

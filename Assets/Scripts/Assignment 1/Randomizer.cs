using UnityEngine;

public class Randomizer : MonoBehaviour
{
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
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            float minX = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
            float maxX = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;

            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);

            transform.position = new Vector2(x, y);

            timer = 0f;
        }
    }
}

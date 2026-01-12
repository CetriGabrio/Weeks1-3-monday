using UnityEngine;

public class Timer : MonoBehaviour
{
    private float interval = 3f;
    private float timer = 0f;

    private Vector2 min = new Vector2(-5f, -3f);
    private Vector2 max = new Vector2(5f, 3f);

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
            float x = Random.Range(min.x, max.x);
            float y = Random.Range(min.y, max.y);

            transform.position = new Vector2(x, y);

            timer = 0f;
        }
    }
}

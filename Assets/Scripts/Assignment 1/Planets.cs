using UnityEngine;

public class Planets : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += 1 * speed * Time.deltaTime;
        transform.position = newPosition;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
    }
}

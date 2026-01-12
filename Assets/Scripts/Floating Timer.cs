using UnityEngine;

public class FloatingTimer : MonoBehaviour
{
    public float speed = 1f;
    public float timer = 0f;

    public AnimationCurve Curve;
    public float height = 1f;
    private float startY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * speed;
        
        if (timer >= 1f)
        {
            timer = 0f;
        }

        float curveValue = Curve.Evaluate(timer);

        transform.position = new Vector3(
            transform.position.x,
            startY + curveValue * height
        );
    }
}

using UnityEngine;

public class Stars : MonoBehaviour
{

    public AnimationCurve sizeCurve;
    public float minSize;
    public float maxSize;
    public float speed = 1f;
    public float t = 0f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime / speed;

        if (t >= 1f)
        {
            t = 0f;
        }

        float y = sizeCurve.Evaluate(t);

        float size = Mathf.Lerp(minSize, maxSize, y);
        transform.localScale = Vector3.one * size;
    }
}

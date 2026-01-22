using UnityEngine;

public class Stars : MonoBehaviour
{
    //This script handles the stars behavior
    //I used animation curve and mathf.lerp to shrink and grow the size of stars between a min nd max value
    //For more details check the math sheet in the planning doc

    //The variables for the curve, like size and speed
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
        //This is the looping part of the animation so that it stars again once reaching the max value
        t += Time.deltaTime / speed;

        if (t >= 1f)
        {
            t = 0f;
        }

        float y = sizeCurve.Evaluate(t);

        //As mentioned before, I am using Lerp to simply shift the size between two values, a min size and a max size
        float size = Mathf.Lerp(minSize, maxSize, y);
        //And I am updating the localScale of each star
        transform.localScale = Vector3.one * size;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleYAxis : MonoBehaviour
{
    [SerializeField]public float scaleSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentScale = transform.localScale;

        // Increase the scale in the y-direction linearly over time
        float scaleFactor = (1.0f + scaleSpeed * Time.deltaTime);
        transform.localScale = new Vector3(currentScale.x, currentScale.y * scaleFactor, currentScale.z);
   
    }
}

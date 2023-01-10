using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float scaleSpeed = 5f;
    bool isScale;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isScale) {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }
    }

    public void ScaleObject(float speed) {
        isScale = true;
        scaleSpeed = speed;
    }
    public void StopRotateObject() {
        isScale = false;
    }
}
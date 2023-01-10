using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 5f;
    bool isRotate;
    string arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotate) {
            if (arrow == "Kanan")
            {
                transform.Rotate(Vector3.up * speed);
            } else if (arrow == "Kiri")
            {
                transform.Rotate(Vector3.down * speed);
            }
        }
    }

    public void RotateObject(string arrow) {
        this.arrow = arrow;
        isRotate = true;
    }
    public void StopRotateObject() {
        isRotate = false;
    }
}

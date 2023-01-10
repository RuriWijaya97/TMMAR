using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingTarget : MonoBehaviour
{
    public GameObject ViewFinder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TargetFound() {
        ViewFinder.SetActive(false);
    }

    public void TargetNotFound() {
        ViewFinder.SetActive(true);
    }
}

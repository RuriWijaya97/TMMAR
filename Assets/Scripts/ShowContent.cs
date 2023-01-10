using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowContent : MonoBehaviour
{
    public GameObject PanelInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowTheContent() {
        if (PanelInfo.activeSelf == false)
        {
            PanelInfo.SetActive(true);
        } else {
            PanelInfo.SetActive(false);
        }
        
    }
    // public void HideTheContent() {
    //     PanelInfo.SetActive(false);
    // }
}

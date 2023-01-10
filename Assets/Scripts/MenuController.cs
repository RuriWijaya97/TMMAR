using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public string url;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoScene(string NameScene) {
        SceneManager.LoadScene(NameScene);
    }

    public void OnClickExit() {
        Application.Quit();
    }

    public void GotoURL() {
        Application.OpenURL(url);
    }  
}

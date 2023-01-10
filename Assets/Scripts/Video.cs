using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour
{
    public GameObject[] PlayVideo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayProdi() {
        PlayVideo[0].SetActive(true);
        PlayVideo[1].SetActive(false);
        PlayVideo[2].SetActive(false);
        PlayVideo[3].SetActive(false);
    }
    public void PlayMatkul() {
        PlayVideo[0].SetActive(false);
        PlayVideo[1].SetActive(true);
        PlayVideo[2].SetActive(false);
        PlayVideo[3].SetActive(false);
    }
    public void PlayCaraPembayaran() {
        PlayVideo[0].SetActive(false);
        PlayVideo[1].SetActive(false);
        PlayVideo[2].SetActive(true);
        PlayVideo[3].SetActive(false);
    }
    public void PlayAlurPendaftaran() {
        PlayVideo[0].SetActive(false);
        PlayVideo[1].SetActive(false);
        PlayVideo[2].SetActive(false);
        PlayVideo[3].SetActive(true);
    }
}

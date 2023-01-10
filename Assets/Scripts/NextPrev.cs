using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NextPrev : MonoBehaviour
{
    public RectTransform T1, T2, T3;
    public GameObject btnNext1, btnNext2, btnNext3, btnPrev1, btnPrev2, btnPrev3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void NextButton1() {
       T1.DOAnchorPos(new Vector2(-1483, 0),1f);
       T2.DOAnchorPos(new Vector2(0, 0),1f);
       T3.DOAnchorPos(new Vector2(1358, 0),1f);
       btnNext1.SetActive(false);
       btnNext2.SetActive(true);
       btnNext3.SetActive(false);
       btnPrev1.SetActive(false);
       btnPrev2.SetActive(true);
       btnPrev3.SetActive(false);
    }

    public void NextButton2() {
       T1.DOAnchorPos(new Vector2(-2897, 0),1f);
       T2.DOAnchorPos(new Vector2(-1483, 0),1f);
       T3.DOAnchorPos(new Vector2(0, 0),1f);
       btnNext1.SetActive(false);
       btnNext2.SetActive(false);
       btnNext3.SetActive(true);
       btnPrev1.SetActive(false);
       btnPrev2.SetActive(false);
       btnPrev3.SetActive(true);
    }
    public void PrevButton1() {
       T1.DOAnchorPos(new Vector2(0, 0),1f);
       T2.DOAnchorPos(new Vector2(1358, 0),1f);
       T3.DOAnchorPos(new Vector2(2600, 0),1f);
       btnNext1.SetActive(true);
       btnNext2.SetActive(false);
       btnPrev1.SetActive(true);
       btnPrev2.SetActive(false);
       btnPrev3.SetActive(false);
    }

    public void PrevButton2() {
       T1.DOAnchorPos(new Vector2(-1483, 0),1f);
       T2.DOAnchorPos(new Vector2(0, 0),1f);
       T3.DOAnchorPos(new Vector2(1358, 0),1f);
       btnNext1.SetActive(false);
       btnNext2.SetActive(true);
       btnNext3.SetActive(false);
       btnPrev2.SetActive(true);
       btnPrev3.SetActive(false);
    }
}

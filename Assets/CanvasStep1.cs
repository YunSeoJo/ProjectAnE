using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasStep1 : MonoBehaviour
{
    private bool isActivated = false;

    //public GameObject previous;
    public GameObject Canvas_Step2_Tab;
    public GameObject Canvas_Step2_UI;

    public GameObject UI_now;

    public GameObject Next_BTN;
    Image Next_BTN_img;

    void Start()
    {
        Next_BTN_img = Next_BTN.GetComponent<Image>();
    }

    public void backBtn()
    {

    }

    public void nextBtn()
    {
        if (Next_BTN_img.sprite.name == "Next_img")
        {
            Canvas_Step2_Tab.SetActive(true);
            Canvas_Step2_UI.SetActive(true);
            UI_now.SetActive(false);
        }
    }
}

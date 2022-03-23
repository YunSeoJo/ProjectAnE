using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChangeBtn : MonoBehaviour
{
    private bool state;
    public GameObject wallColor;
    public GameObject Furniture;

    public GameObject Canvas_Step1;
    public GameObject Canvas_Step2;
    public GameObject Step2_UI;

    public enum User
    {
        VISITOR, // 일반 회원
        ARTIST // 작가 회원
    }

    public User user = User.VISITOR;
    // Start is called before the first frame update
    void Start()
    {
        state = true; //wallColor
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WallColorBtn()
    {
        if(state == false)
        {
            wallColor.SetActive(true);
            Furniture.SetActive(false);
            state = true;
        }
    }

    public void FurnitureBtn()
    {
        if (state == true)
        {
            wallColor.SetActive(false);
            Furniture.SetActive(true);
            state = false;
        }
    }

    public void backBtn()
    {
        Canvas_Step1.SetActive(true);
        Canvas_Step2.SetActive(false);
        Step2_UI.SetActive(false);
    }

    public void nextBtn()
    {

    }
}

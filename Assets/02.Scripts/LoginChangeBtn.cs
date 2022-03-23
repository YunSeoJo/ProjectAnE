using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 일반 회원인지 작가 회원인지에 따라 로그인 창 모습이 바뀐다.
public class LoginChangeBtn : MonoBehaviour
{
    public Image loginTab;
    public Sprite visitor_LoginTab_img;
    public Sprite artist_LoginTab_img;

    public Button visitorBtn; // 일반 회원 텍스트버튼
    public Sprite visitorBtn_inactive_img;
    public Sprite visitorBtn_active_img;
    public Button artistBtn; // 작가 회원 텍스트버튼
    public Sprite artistBtn_inactive_img;
    public Sprite artistBtn_active_img;


    public enum User
    {
        VISITOR, // 일반 회원
        ARTIST // 작가 회원
    }

    public User user = User.VISITOR;


    public void Start()
    {
        visitorBtn.Select();
    }

    // 일반 회원 로그인
    public void VisitorLogin()
    {
        user = User.VISITOR;

        loginTab.sprite = visitor_LoginTab_img;
        visitorBtn.GetComponent<Image>().sprite = visitorBtn_active_img;
        artistBtn.GetComponent<Image>().sprite = artistBtn_inactive_img;
    }

    // 작가 회원 로그인
    public void ArtistLogin()
    {
        user = User.ARTIST;

        loginTab.sprite = artist_LoginTab_img;
        visitorBtn.GetComponent<Image>().sprite = visitorBtn_inactive_img;
        artistBtn.GetComponent<Image>().sprite = artistBtn_active_img;
    }

    public void backBtn()
    {

    }

    public void nextBtn()
    {

    }
}

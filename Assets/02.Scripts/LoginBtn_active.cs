using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 아이디와 패스워드가 모두 입력되어야 로그인 버튼이 활성화된다.
public class LoginBtn_active : MonoBehaviour
{
    Image loginBtn;
    public Sprite loginBtn_img;
    public Sprite loginBtn_active_img;

    public TextMeshProUGUI id_input_txt;
    public TextMeshProUGUI pw_input_txt;

    // Start is called before the first frame update
    void Start()
    {
        loginBtn = gameObject.GetComponent<Image>();
        gameObject.GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((id_input_txt.GetComponent<TextMeshProUGUI>().text.Length-1)
            * (pw_input_txt.GetComponent<TextMeshProUGUI>().text.Length-1) == 0)
        {
            loginBtn.sprite = loginBtn_img;
        }
        else
        {
            loginBtn.sprite = loginBtn_active_img;
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}

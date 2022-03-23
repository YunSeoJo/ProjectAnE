using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 아이디나 패스워드를 입력받으면 input area의 이미지를 바꾼다.
public class LoginInput : MonoBehaviour
{
    public Image id_inputArea;
    public Image pw_inputArea;


    public Sprite login_input_img;
    public Sprite login_input_active_img;

    public TextMeshProUGUI id_input_txt;
    public TextMeshProUGUI pw_input_txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 아이디
        if (id_input_txt.GetComponent<TextMeshProUGUI>().text.Length != 1)
        {
            id_inputArea.GetComponent<Image>().sprite = login_input_active_img;
        }
        else
            id_inputArea.GetComponent<Image>().sprite = login_input_img;

        // 패스워드
        if (pw_input_txt.GetComponent<TextMeshProUGUI>().text.Length != 1)
        {
            pw_inputArea.GetComponent<Image>().sprite = login_input_active_img;
        }
        else
            pw_inputArea.GetComponent<Image>().sprite = login_input_img;
    }
}

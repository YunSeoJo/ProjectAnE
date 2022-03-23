using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


// 방이름 입력(Name_Input_TXT)과
// 대표작 업로드(Upload_Placeholder Text != 디폴트)가 확인되면
// 활성화 버튼으로 바꾸기
public class Activate_NextBtn : MonoBehaviour
{
    Image Next_img;
    public Sprite Next_Active_img;

    public GameObject Name_Input_TXT;
    public GameObject Upload_TXT;

    TMP_Text Name_Input_TMP_Text;
    TMP_Text Upload_TMP_Text;

    // Start is called before the first frame update
    void Start()
    {
        Next_img = GetComponent<Image>();
        Name_Input_TMP_Text = Name_Input_TXT.GetComponent<TMP_Text>();
        Upload_TMP_Text = Upload_TXT.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Name_Input_TMP_Text.text.Length > 1 // 방 이름 입력
            && Upload_TMP_Text.text != "업로드할 파일을 선택해주세요.") // 대표작 업로드
        {
            Next_img.sprite = Next_Active_img;
        }
    }
}

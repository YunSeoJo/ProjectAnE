using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// 파일선택하기 버튼(Upload_Select_BTN)을 누르면(Onclick()) Placeholder의 문구를 파일명으로 바꿈
public class UploadBtn : MonoBehaviour
{
    public TMP_Text Upload_text; // Placeholder -> 파일명
    void Start()
    {
        Upload_text = GetComponent<TMP_Text>();
    }


    public void UploadedFile()
    {
        // **** 업로드 파일명 받아서 바꾸기
        Upload_text.SetText("환대의 조각들.jpg");
    }
}

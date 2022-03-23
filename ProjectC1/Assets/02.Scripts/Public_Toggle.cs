using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

// 공개권한 설정 On Off 토글 버튼 움직이기
public class Public_Toggle : MonoBehaviour
{
    public GameObject Public_Toggle_BTN;
    public Vector3 RT_pos;
    public Vector3 new_pos;

    void Start()
    {
        RT_pos = GetComponent<RectTransform>().anchoredPosition;
    }

    public void OnClickOnOff()
    {
        if (RT_pos.x == 0) // On
            new_pos = new Vector3(240, 0, 0);
        else // Off
            new_pos = new Vector3(0, 0, 0);

        GetComponent<RectTransform>().anchoredPosition = Vector3.Lerp(RT_pos, new_pos, 1);
        RT_pos = GetComponent<RectTransform>().anchoredPosition;
    }

}

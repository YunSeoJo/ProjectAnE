using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeButton : MonoBehaviour
{
    public GameObject cube_Floor;
    public GameObject cube_Left;
    public GameObject cube_Right;

    public Camera getCamera;

    private RaycastHit hit;

    private bool click_Floor = false;
    private bool click_Left = false;
    private bool click_Right = false;

    Color color;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                string objectName = hit.collider.gameObject.name;
                Debug.Log(objectName);

                if (objectName == "Floor")
                {
                    //cube_Right.gameObject.GetComponent<Renderer>().material.color = new Color(0.098f, 0.003f, 0.35f, 0.5f);
                    //cube_Left.gameObject.GetComponent<Renderer>().material.color = new Color(0.098f, 0.003f, 0.35f, 0.5f);

                    click_Floor = true;
                }
                else if(objectName == "rightWall")
                {
                    click_Right = true;
                }
                else if (objectName == "leftWall")
                {
                    click_Left = true;
                }
            }
        }
    }

    public void colorChange_Main1()
    {
        if(click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#190159", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if(click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#190159", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if(click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#190159", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }

    public void colorChange_Main2()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#7F29FE", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#7F29FE", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#7F29FE", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }

    public void colorChange_Main3()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#B47FFF", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#B47FFF", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#B47FFF", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }

    public void colorChange_Main4()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#F63CFF", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#F63CFF", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#F63CFF", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }

    public void colorChange_Main5()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#60DFFF", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#60DFFF", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#60DFFF", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }

    public void colorChange_Main6()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#01FFEA", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#01FFEA", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#01FFEA", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }

    public void colorChange_Grayish1()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#D9BFD4", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#D9BFD4", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#D9BFD4", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Grayish2()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#D9B3B0", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#D9B3B0", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#D9B3B0", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Grayish3()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#A8BBBF", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#A8BBBF", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#A8BBBF", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Grayish4()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#586B73", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#586B73", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#586B73", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Grayish5()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#384173", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#384173", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#384173", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Grayish6()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#1E2640", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#1E2640", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#1E2640", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Deep1()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#BF419E", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#BF419E", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#BF419E", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Deep2()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#8C1F1F", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#8C1F1F", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#8C1F1F", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Deep3()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#D96D55", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#D96D55", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#D96D55", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Deep4()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#FCFF80", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#FCFF80", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#FCFF80", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Deep5()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#3457BF", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#3457BF", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#3457BF", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Deep6()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#4C1E59", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#4C1E59", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#4C1E59", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Deep7()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#593A2F", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#593A2F", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#593A2F", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Mono1()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#F2F2F2", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#F2F2F2", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#F2F2F2", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Mono2()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#BFBFBF", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#BFBFBF", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#BFBFBF", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Mono3()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#3F3F3F", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#3F3F3F", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#3F3F3F", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
    public void colorChange_Mono4()
    {
        if (click_Floor == true)
        {
            ColorUtility.TryParseHtmlString("#0D0D0D", out color);
            cube_Floor.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Right == true)
        {
            ColorUtility.TryParseHtmlString("#0D0D0D", out color);
            cube_Right.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
        else if (click_Left == true)
        {
            ColorUtility.TryParseHtmlString("#0D0D0D", out color);
            cube_Left.gameObject.GetComponent<Renderer>().material.color = color;

            click_Floor = false;
            click_Right = false;
            click_Left = false;
        }
    }
}

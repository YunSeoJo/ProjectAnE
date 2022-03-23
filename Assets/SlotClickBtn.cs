using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotClickBtn : MonoBehaviour
{
    public GameObject[] SlotItem;

    private Vector3 _mousePosition;
    private float _previousX;
    private float _previousZ;

    float positionX;
    float positionZ;

    private Camera camera;

    private bool isPutDown;
    private Vector3 destination;

    public int seletedItem = -1;

    private int state;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Start()
    {
        state = GameObject.Find("changeBtns").GetComponent<FurnitureChangeBtn>().state;
    }

    private void Update()
    {
        if(seletedItem != -1)
        {
            PutDownItem(SlotItem[seletedItem]);
        }

        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {

            if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                destination = hit.point;
            }
        }
        
        //아래는 좀 더 살펴봐야 할 코드(제대로 작동 안 함)
        _mousePosition = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            positionX = hit.point.x;
            positionZ = hit.point.z;
        }
    }

    //Slot 버튼을 누르면 그 Slot에 해당하는 오브젝트가 마우스를 따라다니다가 클릭하면 그 위치에 놓이게
    //마우스를 누를 때까지 그럼 함수가 끝나지 않아야 하는데, while 문을 쓰면 Unity가 멈춰버린다
    private void PutDownItem(GameObject obj)
    {
        if (_previousX != positionX || _previousZ != positionZ)
        {
            _previousX = positionX;
            _previousZ = positionZ;

            obj.transform.position = new Vector3(positionX, 0.05f, positionZ);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (seletedItem != -1)
            {
                Instantiate(obj, obj.transform.position, Quaternion.identity);
            }
            seletedItem = -1;
        }
    }

    public void Slot0()
    {
            seletedItem = 0;
    }
    public void Slot1()
    {
            seletedItem = 1;
    }
    public void Slot2()
    {
            seletedItem = 2;
    }
    public void Slot3()
    {
            seletedItem = 3;
    }
    public void Slot4()
    {
            seletedItem = 4;
    }
    public void Slot5()
    {
            seletedItem = 5;
    }
    public void Slot6()
    {
            seletedItem = 6;
    }
    public void Slot7()
    {
            seletedItem = 7;
    }
    public void Slot8()
    {
            seletedItem = 8;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureChangeBtn : MonoBehaviour
{
    public int state; // 1:Light 2:Table 3:Chair 4:Storage 5:Props
    public GameObject Light;
    public GameObject Table;
    public GameObject Chair;
    public GameObject Storage;
    public GameObject Props;

    public Slot[] slots;
    public Transform slotHolder;

    // Start is called before the first frame update
    void Start()
    {
        state = 1; //Light

        slots = slotHolder.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightBtn()
    {
        if (state != 1)
        {
            Light.SetActive(true);
            Table.SetActive(false);
            Chair.SetActive(false);
            Storage.SetActive(false);
            Props.SetActive(false);
            state = 1;
        }
    }
    public void TableBtn()
    {
        if (state != 2)
        {
            Light.SetActive(false);
            Table.SetActive(true);
            Chair.SetActive(false);
            Storage.SetActive(false);
            Props.SetActive(false);
            state = 2;
        }
    }
    public void ChairBtn()
    {
        if (state != 3)
        {
            Light.SetActive(false);
            Table.SetActive(false);
            Chair.SetActive(true);
            Storage.SetActive(false);
            Props.SetActive(false);
            state = 3;
        }
    }
    public void StorageBtn()
    {
        if (state != 4)
        {
            Light.SetActive(false);
            Table.SetActive(false);
            Chair.SetActive(false);
            Storage.SetActive(true);
            Props.SetActive(false);
            state = 4;
        }
    }
    public void PropsBtn()
    {
        if (state != 5)
        {
            Light.SetActive(false);
            Table.SetActive(false);
            Chair.SetActive(false);
            Storage.SetActive(false);
            Props.SetActive(true);
            state = 5;
        }
    }
}

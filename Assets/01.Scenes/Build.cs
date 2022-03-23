using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    public GameObject spawner;
    public float num = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (num == 1)
        {
            spawner.SetActive(true);
        }
        else
        {
            spawner.SetActive(false);
        }
    }

    private void OnMouseEnter()
    {
        num = 1;
    }

    private void OnMouseExit()
    {
        num = 0;
    }
}

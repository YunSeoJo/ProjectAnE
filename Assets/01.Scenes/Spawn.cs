using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform Block;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clear();
        }
    }

    void clear()
    {
        Instantiate(Block, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

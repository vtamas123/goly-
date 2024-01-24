using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas : MonoBehaviour
{
    private CanvasGroup cav;
    private bool vesztett = false;

    // Start is called before the first frame update
    void Start()
    {
        cav = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {

            cav.alpha = 1;
            vesztett = true;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cav.alpha = 1;
            vesztett = true;
        }
        

    }
}

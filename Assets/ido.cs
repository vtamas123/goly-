using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ido : MonoBehaviour
{
    public float kezd = 0;
    public TextMeshProUGUI text;
    public TextMeshProUGUI uzenet;
    string utkoz ="nem";
    void OnCollisionEnter(Collision collision)
    {
        utkoz = "igen";
    }  
    // Start is called before the first frame update
    void Start()
    {
        kezd = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //if (utkoz=="nem")
        {
            kezd += Time.deltaTime;
            text.text = kezd + "";
        }
        
        
      
       
    }
}

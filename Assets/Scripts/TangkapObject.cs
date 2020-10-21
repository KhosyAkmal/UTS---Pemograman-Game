using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TangkapObject : MonoBehaviour
{
    public GameObject bola;
    public GameObject tangan;
    public Text tulisan;

    bool tertangkap = false;
    Vector3 posisiBola;
    public Renderer rend; 
    // Start is called before the first frame update
    void Start()
    {
        posisiBola = bola.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {
            if(!tertangkap)
            {
                bola.transform.SetParent(tangan.transform);
                bola.transform.localPosition = tangan.transform.localPosition;
                bola.transform.localPosition = new Vector3(0f, -.672f, 0f);
                bola.GetComponent<Renderer>().material.color = Color.blue;
                tulisan.text = "bola ditangkap";
                tertangkap = true;
                
                
                
                
            } else if (tertangkap)
                {
                bola.transform.SetParent(null);
                bola.transform.localPosition = posisiBola;
                bola.GetComponent<Renderer>().material.color = Color.red;
                tulisan.text = "bola dilepas";
                tertangkap = false;

                }
            
        }
    }
}

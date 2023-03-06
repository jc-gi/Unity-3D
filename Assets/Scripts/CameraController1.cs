using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour
{    
    public GameObject[] listaCamara;
    public int cantidadCamaras = 3;

    private void Start() 
    {
        listaCamara[0].gameObject.SetActive(true);
        for (int i=1; i < listaCamara.Length; i++)
        {
            listaCamara[i].gameObject.SetActive(false);
        }
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            Debug.Log("Camera First Person");
            listaCamara[0].gameObject.SetActive(true);
            listaCamara[1].gameObject.SetActive(false);
            listaCamara[2].gameObject.SetActive(false);
        }
        if(Input.GetKey(KeyCode.Alpha2))
        {
            listaCamara[0].gameObject.SetActive(false);
            listaCamara[1].gameObject.SetActive(true);
            listaCamara[2].gameObject.SetActive(false);
            Debug.Log("Camera Third Person");
        }
        if(Input.GetKey(KeyCode.Alpha3))
        {
            Debug.Log("Camera Top View");
            listaCamara[0].gameObject.SetActive(false);
            listaCamara[1].gameObject.SetActive(false);
            listaCamara[2].gameObject.SetActive(true);
        }
    }
}

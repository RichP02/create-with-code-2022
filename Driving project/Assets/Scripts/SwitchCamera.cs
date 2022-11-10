using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    //private Vector3 offset = new Vector3(0, 4, -1); //camera 1st person view
    public GameObject cam1;
    public GameObject cam2;


    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("1Key"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else if (Input.GetButtonDown("2Key"))
      {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }

    }
}

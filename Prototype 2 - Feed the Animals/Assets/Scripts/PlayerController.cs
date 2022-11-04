using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.space)
        //{
        //    Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.position);
        //}

        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);  
        }

        if (transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}

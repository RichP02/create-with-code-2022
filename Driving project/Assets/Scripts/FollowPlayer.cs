using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 4, -10); //camera 3rd person view
    private Vector3 offset2 = new Vector3(0, 4, -1); //camera 1st person view

    // LateUpdate is called once per frame, after Update
    void LateUpdate()
    {
        if (Input.GetButtonDown("1Key"))
            transform.position = player.transform.position + offset1;
        else if (Input.GetButtonDown("2Key"))
            transform.position = player.transform.position + offset2;
    }
}
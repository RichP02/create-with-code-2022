using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemies : MonoBehaviour
{
    //public transform;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
        // transform.Translate += transform.forward * Time.deltaTime;
    }
}

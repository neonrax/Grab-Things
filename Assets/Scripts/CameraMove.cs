using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{   // Update is called once per frame
    public Transform Player;

    void Update()
    {

        transform.position=Player.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public float followspeed = 2f;
    public float yoffset = 1;
    public Transform target;

    void Update()
    {
        Vector3 newpos = new Vector3(target.position.x + 3, target.position.y + yoffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, followspeed * Time.deltaTime);

    }
}


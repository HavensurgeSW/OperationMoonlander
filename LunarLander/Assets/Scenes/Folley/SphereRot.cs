using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRot : MonoBehaviour
{
    public GameObject sun;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Earth standalone day rotation
        transform.Rotate(0, -0.1f, 0);

        if(Input.GetKey(KeyCode.RightArrow))
        transform.RotateAround(sun.transform.position, Vector3.right, speed * Time.deltaTime * 2);
    }
}

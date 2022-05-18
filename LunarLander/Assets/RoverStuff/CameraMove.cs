using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target;
    public bool right;
    private bool left;
    private bool up;
    private bool down;
    [SerializeField] Vector3 offset;
    [SerializeField] private float speed;

    private void Awake()
    {
        transform.LookAt(target.transform);
        offset = transform.position - target.transform.position;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            right = true;
            //transform.RotateAround(target.transform.position, Vector3.right, speed * Time.deltaTime);
        }
        else
        {
            right = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
            left = true;
        else
            left = false;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            up = true;

        }
        else
            up = false;

        if (Input.GetKey(KeyCode.DownArrow))
            down = true;
        else
            down = false;
    }

    void FixedUpdate()
    {
       
        if (right)
        {
            //transform.Translate(Vector3.right * Time.deltaTime * 3);
            transform.RotateAround(target.transform.position, transform.up, speed * Time.deltaTime);
        }

        if (left)
            transform.RotateAround(target.transform.position, -transform.up, speed * Time.deltaTime);

        if (up)
           transform.RotateAround(target.transform.position, transform.right, speed * Time.deltaTime);

        if (down)
            transform.RotateAround(target.transform.position, -transform.right, speed * Time.deltaTime);

        //gameObject.transform.position = target.transform.position - offset;
    }

}


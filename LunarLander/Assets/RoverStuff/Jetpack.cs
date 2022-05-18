using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jetpack : MonoBehaviour
{
    public float maxFuel = 10f;
    private float thrustForce = 60.0f;
    public Rigidbody rigid;
    public ParticleSystem effect;
    private float maxAngle = 15f;

    [SerializeField]private Camera cam;
    [SerializeField]private float curFuel;

    public bool winstatus;
    public GameObject missionPanel;


    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rigid.AddTorque(cam.transform.right/2, ForceMode.Force);
                //(0.0f, 0f, 20.0f*Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            rigid.AddTorque(-cam.transform.right / 2, ForceMode.Force);

        if (Input.GetKey(KeyCode.A))
            rigid.AddTorque(cam.transform.forward / 2, ForceMode.Force);

        if (Input.GetKey(KeyCode.D))
            rigid.AddTorque(-cam.transform.forward / 2, ForceMode.Force);

        if (Input.GetAxis("Jump") > 0f && curFuel > 0f)
        {
            curFuel -= Time.deltaTime;
            rigid.AddForce(transform.up * thrustForce, ForceMode.Force);

            if (!effect.isPlaying)
                effect.Play();

        }
        else if (effect.isPlaying)
            effect.Stop();

        
        else if (effect.isPlaying)
            effect.Stop();


    }

    public float getFuel(){
        return curFuel;
    }

    public float getVel(){
        return rigid.velocity.magnitude;
    }

    void OnCollisionEnter(Collision c){
        //land.Play();
        if (rigid.velocity.magnitude < 1.5f&& c.gameObject.CompareTag("Platform"))
        {
            if ((transform.rotation.x < maxAngle || transform.rotation.x > -maxAngle) &&
               (transform.rotation.z < maxAngle || transform.rotation.z > -maxAngle))
                winstatus = true;
        }
        else
        {
            winstatus = false;
           //explode.Play();
            Debug.Log("Rompiste todo man");
            Debug.Log(rigid.velocity.magnitude);
        }

        if(missionPanel.activeInHierarchy == false)
                missionPanel.SetActive(true);

    }

    public void StartGame(){
        if(missionPanel.activeInHierarchy == true)
                missionPanel.SetActive(false);
        winstatus = false;
        curFuel = maxFuel;
        transform.position = new Vector3(Random.Range(170, 360), 70, Random.Range(300, 500));
    }
}
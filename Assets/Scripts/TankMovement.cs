using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float timer1 = 0;
    public float timer2 = 0;
    public float speed = 8;
    public float angularspeed = 4;
    public float number =1;
    public AudioClip IdelAudio;
    public AudioClip drivingAudio;
    private AudioSource audio;
    private Rigidbody rd;
    public Component Jump;
    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();
        rd = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(speed > 8)
        {
            timer1 += Time.deltaTime;
            if (timer1 > 20)
            {
                speed = 8;
            }
        }
        if (GetComponent<Jump>().enabled == true)
        {
            timer2 += Time.deltaTime;
            if(timer2 >30)
            {
                GetComponent<Jump>().enabled = false;
            }
        }
    }
    void FixedUpdate()
    {
        float v = Input.GetAxis("VerticalPlayer"+ number);
        rd.velocity = transform.forward * v * speed;
        float h = Input.GetAxis("HorizontalPlayer"+ number);
        rd.angularVelocity = transform.up * h * angularspeed;
        if (Mathf.Abs(h) > 0.05 || Mathf.Abs(v) > 0.05)
        {
            audio.clip = drivingAudio;
            if(audio.isPlaying ==false )
            audio.Play();
        }
        else
        {
            audio.clip = IdelAudio;
            if (audio.isPlaying == false)
                audio.Play();
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Speed")
        {
            speed = speed + 4;
        }
        if(collider.tag=="Jump")
        {
            GetComponent<Jump>().enabled=true;
        }
    }
}

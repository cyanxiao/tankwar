using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    public GameObject shellPrefab1;
    public GameObject shellPrefab2;
    public GameObject a;
    public KeyCode fireKey = KeyCode.Space;
    private Transform firePosition;
    public float shellSpeed = 10;
    public AudioClip fireAudio;
    private Rigidbody rd;
    private float timer=0;
    // Start is called before the first frame update
    void Start() 
    {
        firePosition = transform.Find("FirePosition");
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shellPrefab1 = shellPrefab2)
        {
            timer += Time.deltaTime;
            if (timer > 20)
            {
                shellPrefab1 = a;
                timer = 0;
            }
        }
        if(Input.GetKeyDown(fireKey ))
        {
            AudioSource.PlayClipAtPoint(fireAudio, transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab1, firePosition.position, firePosition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Attack")
        {
            a = shellPrefab1;
            shellPrefab1 = shellPrefab2;
        }
    }
}

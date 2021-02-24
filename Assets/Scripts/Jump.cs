using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed = 500;
    public KeyCode jump = KeyCode.X;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input .GetKeyDown(jump))
        {
            rigidbody.AddForce(Vector3.up * speed);
        }
    }
}
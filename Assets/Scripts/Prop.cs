using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    public float time=20;
    private  Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        Destroy(this.gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1));
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Tank")
        {
            Destroy(this.gameObject);
        }
    }
}

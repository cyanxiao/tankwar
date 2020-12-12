using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropMaker : MonoBehaviour
{
    public GameObject[] Prop;
    public float timer = 0;
    public float time=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>time)
        {
            Instantiate(Prop[Random.Range(0, Prop.Length)], new Vector3(Random.Range(-40, 40), 1, Random.Range(-40, 40)),Prop[Random.Range(0, Prop.Length)].transform.rotation);
            timer = 0;
        }
    }
}

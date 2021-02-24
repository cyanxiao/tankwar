using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell2 : MonoBehaviour
{
    public GameObject ShellExplosionPrefab;
    public float   time;
    public AudioClip shellExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(this.gameObject, time); 
    }
    private void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(shellExplosion,transform .position);
        GameObject.Instantiate(ShellExplosionPrefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);

        if (collider.tag == "Tank")
        {
            collider.SendMessage("TankDamage2");
        }
    }    

}

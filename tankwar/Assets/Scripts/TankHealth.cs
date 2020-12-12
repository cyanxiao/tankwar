using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public int hp = 100;
    public GameObject TankExplosion;
    public AudioClip TankExplosionAudio;
    public Slider hpslider;
    private int hpTotal;
    public GameObject  text;
    private Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        hpTotal = hp;
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TankDamage1()
    {
        if (hp <= 0) return;
        hp = hp - Random.Range(10, 20);
        hpslider.value = (float)hp / hpTotal;
        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(TankExplosionAudio, transform.position);
            GameObject.Instantiate(TankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
            text.SetActive(true);
        }
    }
    void TankDamage2()
    {
        if (hp <= 0) return;
        hp =hp-Random.Range(20, 40);
        hpslider.value = (float)hp  / hpTotal;
        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(TankExplosionAudio, transform.position);
            GameObject.Instantiate(TankExplosion, transform.position+Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
            text.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "HP")
        {
            hp = hp + 20;
        }
    }
}

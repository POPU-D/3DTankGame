using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public int hp = 100;
    public GameObject tankExplosion;//̹������Ч��
    public AudioClip tankExplosionAudio;//̹��������Ч
    public Slider hpslider;
    private int hpTotal;
    // Start is called before the first frame update
    void Start()
    {
        hpTotal = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TakeDamage()
    {
        if (hp <= 0)
            return;
        hp -= Random.Range(10, 15);
        hpslider.value = 1-(float)hp / hpTotal;
        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}

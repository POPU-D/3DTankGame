using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : MonoBehaviour
{
    public GameObject shellExplosionPrefab;//±¬Õ¨
    public AudioClip shellExplosionAudio;
    // Start is called before the first frame update

    //´¥·¢¼ì²â
    public void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(shellExplosionAudio, transform.position);
        GameObject.Instantiate(shellExplosionPrefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);

        if(other.tag=="tank")
        {
            other.SendMessage("TakeDamage");
        }
    }
}

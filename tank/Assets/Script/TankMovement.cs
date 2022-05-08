using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 5;//执行速度
    public float angularSpeed = 10;//旋转速度
    public Rigidbody rigidbody;
    public float number = 1;
    public AudioClip idleAudio;//静止音效
    public AudioClip drivingAudio;//移动音效
    public AudioSource audio;//坦克的音频源
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Verticalplayer"+number);
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("Horizontalplayer"+number);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;

        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
           
            audio.clip = drivingAudio; 
            if(audio.isPlaying == false)
            audio.Play();
        }
        else
        {
            audio.clip = idleAudio;
            if (audio.isPlaying == false)
                audio.Play();
        }
    }
}

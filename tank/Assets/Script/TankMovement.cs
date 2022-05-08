using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 5;//ִ���ٶ�
    public float angularSpeed = 10;//��ת�ٶ�
    public Rigidbody rigidbody;
    public float number = 1;
    public AudioClip idleAudio;//��ֹ��Ч
    public AudioClip drivingAudio;//�ƶ���Ч
    public AudioSource audio;//̹�˵���ƵԴ
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

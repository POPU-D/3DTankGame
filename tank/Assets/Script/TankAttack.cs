using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    private Transform firePosition;
    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 10;

    public AudioClip shotAudio;//攻击音效
    // Start is called before the first frame update
    void Start()
    {
        firePosition = transform.Find("FirePosition");//获取子弹发射位置
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(shotAudio,transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation)as GameObject; //生成子弹
            go.GetComponent<Rigidbody>().velocity = go.transform.forward*shellSpeed; //获取子弹物体的刚体组件，向前飞行
        }
    }
}

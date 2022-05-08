using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    private Transform firePosition;
    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 10;

    public AudioClip shotAudio;//������Ч
    // Start is called before the first frame update
    void Start()
    {
        firePosition = transform.Find("FirePosition");//��ȡ�ӵ�����λ��
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(shotAudio,transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation)as GameObject; //�����ӵ�
            go.GetComponent<Rigidbody>().velocity = go.transform.forward*shellSpeed; //��ȡ�ӵ�����ĸ����������ǰ����
        }
    }
}

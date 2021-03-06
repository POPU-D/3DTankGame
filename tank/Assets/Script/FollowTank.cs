using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTank : MonoBehaviour
{
    public Transform player1;
    public Transform player2;

    private Vector3 offset;
    private Camera camera;//
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - (player1.position + player2.position) / 2;//偏移位置
        camera = this.GetComponent<Camera>();//获取摄像机
    }

    // Update is called once per frame
    void Update()
    {
        if (player1 == null || player2 == null)
            return;
        transform.position = (player1.position + player2.position) / 2 + offset;
        float distance = Vector3.Distance(player1.position, player2.position);

        float size = distance * 0.59f;
        camera.orthographicSize = size;//正交大小
    }
}

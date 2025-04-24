using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 1005.0f;

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        // Time.deltaTime이란?
        // 마지막 프레임이 완료하는데 경과한 시간을 초 단위로 변환하는 시가입니다.
        transform.position = transform.position + direction * speed *Time.deltaTime;
    }
}

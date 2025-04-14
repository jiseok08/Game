using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()
    {
        // Awake 함수란?
        // 게임 오브젝트가 생성되었을 때 단 한 번만 호출되며,
        // 스크립트가 비활성화되어 있는 상태에서도 호출되는 이벤트 함수입니다.
        
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable 함수란?
        // 게임 오브젝트가 활성화되는 순간마다 호출되는 이벤트 함수입니다.

        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start 함수란?
        // 게임 오브젝트가 생성되었을 때 단 한 번만 호출되며,
        // 스크립트가 비활성화된 상태일때는 호출되지 않는 이벤트 함수입니다.

        Debug.Log("Start");
    }
}

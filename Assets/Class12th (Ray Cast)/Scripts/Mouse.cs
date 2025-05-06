using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;

void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.Log(ray.origin);
        }

        if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity)) //���콺�� ������ �ִ� ������Ʈ�� ��Ҵٸ� out���� ���� ���
        {
            Debug.Log(raycastHit.collider.GameObject());
        }
    }
}

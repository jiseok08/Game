using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] LayerMask layerMask;
    [SerializeField] RaycastHit raycastHit;

void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity, layerMask)) //���콺�� ������ �ִ� ������Ʈ�� ��Ҵٸ� out���� ���� ���
            {
                GameObject prefab = raycastHit.collider.gameObject;

                if (prefab.transform.GetChild(0).gameObject.activeSelf)
                {
                    prefab.transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    prefab.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
        }


    }
}

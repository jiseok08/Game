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

            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity, layerMask)) //마우스에 정보를 주는 오브젝트에 닿았다면 out으로 정보 출력
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

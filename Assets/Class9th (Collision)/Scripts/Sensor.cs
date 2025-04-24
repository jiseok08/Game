using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter ���������� ���� �浹�� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        if (other.CompareTag ("Authorized"))
        {
            Debug.Log("OntreegerEnter");
        };
    }

    private void OnTriggerStay(Collider other)
    {
        // OntriggerStau : ���������� ���� �浹�� �ϰ� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OntreegerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        // OnTriggerExit : ���������� ���� �浹�� ������ ��
        // ȣ��Ǵ� �Լ��Դϴ�.

        Debug.Log("OntreegerExit");
    }
}

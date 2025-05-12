using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automation : MonoBehaviour
{
    [SerializeField] bool state;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    private void FixedUpdate()
    {
        // ForceMode.Force : �� �����Ӹ��� �������� ���� ���ϴ� �Լ��Դϴ�. (Mass) - O

        // ForceMode.Impulse : �������� ���� ���ϴ� �Լ��Դϴ�. (Mass) - O

        // ForceMode.Acceleration : �������� ���ӵ��� �����ϴ� �Լ��Դϴ�. (Mass) - X

        // ForceMode.VelocityChange : �������� �ӵ� ������ �����ϴ� �Լ��Դϴ�. (Mass) - X

        if (state)
        {
            rigidbody.AddForce(direction, ForceMode.Impulse);

            state = false;
        }
    }

    IEnumerator Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);

            state = true;
        }
    }

}

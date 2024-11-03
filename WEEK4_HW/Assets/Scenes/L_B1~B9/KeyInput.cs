using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vec = new Vector3(0, 0, 0);
        transform.Translate(vec);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        }    
        if (Input.anyKey)
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("�������� �����Ͽ����ϴ�.");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵� ��");
        }
        
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("������ �̵��� ����");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("�̻��� �߻�!");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("�̻��� ������ �� ....");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("���� �̻��� �߻�!!!");
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("����!");
        }

        if (Input.GetButton("Jump"))
        {
            Debug.Log("���� �غ�");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("���� ����!");
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("����!");
        }

        if (Input.GetButton("Fire1"))
        {
            Debug.Log("���� �غ�");
        }

        if (Input.GetButtonUp("Fire1"))
        {
            Debug.Log("���� ����!");
        }

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));
        }

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� �� ..." + Input.GetAxisRaw("Horizontal"));
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� �� ..." + Input.GetAxisRaw("Vertical"));
        }

        Vector3 vec2 = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec2);
    }
}

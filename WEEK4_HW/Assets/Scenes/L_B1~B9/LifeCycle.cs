using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }
    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����Ͽ����ϴ�.");
    }
    
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Move");
    }

    void Updata()
    {
        Debug.Log("���� ���!!");
    }

    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }
    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��Ǿ����ϴ�.");
    }

    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
}

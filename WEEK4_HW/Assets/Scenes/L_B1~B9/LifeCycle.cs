using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인하였습니다.");
    }
    
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Move");
    }

    void Updata()
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃되었습니다.");
    }

    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}

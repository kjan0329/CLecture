using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake() //초기화 - 최초 Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }


    private void OnEnable() //활성화 - Onenable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }


    private void Start() //초기화 - 프레임 시작 Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }




    private void FixedUpdate() //프레임 - 물리 FixedUpdate()
    {
        Debug.Log("이동~");
    }


    private void Update() //프레임 - 로직 Update()
    {
        Debug.Log("몬스터 사냥!!");
    }


    private void LateUpdate() //프레임 - 후처리 LateUpdate()
    {
        Debug.Log("경험치 획득");
    }



    private void OnDisable() //비활성화 Ondisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }
    private void OnDestroy() //해제 Ondestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }

}
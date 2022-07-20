using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake() //�ʱ�ȭ - ���� Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }


    private void OnEnable() //Ȱ��ȭ - Onenable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }


    private void Start() //�ʱ�ȭ - ������ ���� Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }




    private void FixedUpdate() //������ - ���� FixedUpdate()
    {
        Debug.Log("�̵�~");
    }


    private void Update() //������ - ���� Update()
    {
        Debug.Log("���� ���!!");
    }


    private void LateUpdate() //������ - ��ó�� LateUpdate()
    {
        Debug.Log("����ġ ȹ��");
    }



    private void OnDisable() //��Ȱ��ȭ Ondisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }
    private void OnDestroy() //���� Ondestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }

}
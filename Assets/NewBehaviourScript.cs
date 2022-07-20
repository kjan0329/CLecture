using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int level = 5;
    float strength = 15.5f;
    string playerName = "���˻�";
    bool isFullLevel = false;
    int exp = 1500;
    string title = "������";
    int health = 30; //���� ����
    int mana = 25;




    void Start()
    {
        Debug.Log("Hello World!");




        //1.����
        //int level = 5; //����
        //float strength = 15.5f; //�Ǽ�
        //string playerName = "���˻�"; //����
        //bool isFullLevel = false; //��,����

        Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);




        //2.�׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;
        //int[] monsterLevel = { 1, 2, 3 };
        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");
        //items.RemoveAt(0);

        Debug.Log("�ʿ� �����ϴ� ����");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        Debug.Log(items[0]);
        Debug.Log(items[1]);




        //3.������
        //int exp = 1500;
        exp = exp + 320; //exp ù��° ���
        exp = exp - 10; ; //exp �ι�° ���
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);


        int nextExp = exp % 300; //������, exp �ι�° ��꿡�� ���

        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);


        //string title = "������";

        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playerName);


        int fullLevel = 99;
        isFullLevel = level == fullLevel; //level�� fullLevel�� ������ ��,����

        Debug.Log("���� �����Դϱ�? " + isFullLevel);


        bool isEndTutorial = level > 10;

        Debug.Log("Ʃ�丮���� ���� ����Դϱ�? " + isEndTutorial);


        //int health = 30; //��������
        //int mana = 25;
        bool isGoodCondition1 = health <= 50 && mana <= 20; //&&(and) ���� ��ΰ� true �� ���� ���

        Debug.Log("����� ���°� �����ϱ�? " + isGoodCondition1);


        bool isGoodCondition2 = health <= 50 || mana <= 20; //||(or) ���� �� ��� �ϳ��� true �� ���� ���

        Debug.Log("����� ���°� �����ϱ�? " + isGoodCondition2);


        string condition = isGoodCondition1 ? "����" : "����"; //? A : B ?���� true �϶� A ���, false �϶� B ���

        Debug.Log("����� ���°� �����ϱ�? " + condition);




        //4.Ű����
        //int float string bool new List




        //5.���ǹ�
        if (condition == "����") //��ȣ ���� ture�϶� ���
        {
            Debug.Log("�÷��̾��� ���°� ���ڴ� �������� ����ϼ���");
        }

        if (condition == "����")
        {
            Debug.Log("�÷��̾��� ���°� �����ϴ�.");
        }
        else //���� if�� ������� ������ ���
        {
            Debug.Log("�÷��̾��� ���°� ���ڴ� �������� ����ϼ���");
        }


        if (isGoodCondition2 && items[0] == "������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("������30�� ����Ͽ����ϴ�.");
        }
        else if (isGoodCondition2 && items[0] == "��������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }


        switch (monsters[1]) //������ ���� ���� ���� ����
        {
            case "������":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            default: //case�� ���� ������ ��
                Debug.Log("??? ���Ͱ� ����!");
                break;
        }


        switch (monsters[1]) //������ ���� ���� ���� ����
        {
            case "������":
            case "�縷��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
        }




        //6.�ݺ���
        while (health > 0) //������ true�� ��, ���� �ݺ�
        {
            health--;
            if (health > 0)
                Debug.Log("�� �������� �Ծ����ϴ�." + health);
            else
                Debug.Log("����Ͽ����ϴ�");

            if (health == 10)
            {
                Debug.Log("�ص����� ����մϴ�.");
                break;
            }
        }


        for (int count=0; count<10; count++) //������ �����ϸ鼭 ���� ���� �ݺ�, (����� ����; ����; ����)
        {
            health++;
            Debug.Log("�ش�� ġ�� ��..." + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("�� ������ �ִ� ���� : " + monsters[index]);
        }


        foreach (string monster in monsters)
        {
            Debug.Log("�� ������ �ִ� ���� : " + monster);
        }




        //7.���� (�޼ҵ�)
        Heal();


        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("���� " + monsters[index] + "���� " + Battle(monsterLevel[index]));
        }




        //8.Ŭ���� (�ϳ��� ������Ʈ�� ����)
        Player player = new Player(); //�ν��Ͻ� : Ŭ������ ������ ������� player�� ���� �̸�
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.weapon = "���� ������";
        player.strength = 2.4f;
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������" + player.level + "�Դϴ�.");


        Debug.Log(player.move());
    }




    //7.�Լ� (�޼ҵ�)
    void Heal() //���� Heal
    {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�. " + health);
    }


    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "�̰���ϴ�.";
        else
            result = "�����ϴ�.";
        return result;
    }

}

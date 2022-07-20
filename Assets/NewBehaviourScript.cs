using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int level = 5;
    float strength = 15.5f;
    string playerName = "나검사";
    bool isFullLevel = false;
    int exp = 1500;
    string title = "전설의";
    int health = 30; //전역 변수
    int mana = 25;




    void Start()
    {
        Debug.Log("Hello World!");




        //1.변수
        //int level = 5; //정수
        //float strength = 15.5f; //실수
        //string playerName = "나검사"; //문자
        //bool isFullLevel = false; //참,거짓

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);




        //2.그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;
        //int[] monsterLevel = { 1, 2, 3 };
        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        //items.RemoveAt(0);

        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        Debug.Log(items[0]);
        Debug.Log(items[1]);




        //3.연산자
        //int exp = 1500;
        exp = exp + 320; //exp 첫번째 계산
        exp = exp - 10; ; //exp 두번째 계산
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);


        int nextExp = exp % 300; //나머지, exp 두번째 계산에서 계산

        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);


        //string title = "전설의";

        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);


        int fullLevel = 99;
        isFullLevel = level == fullLevel; //level이 fullLevel과 같음의 참,거짓

        Debug.Log("용사는 만렙입니까? " + isFullLevel);


        bool isEndTutorial = level > 10;

        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);


        //int health = 30; //지역변수
        //int mana = 25;
        bool isGoodCondition1 = health <= 50 && mana <= 20; //&&(and) 양쪽 모두가 true 일 때만 출력

        Debug.Log("용사의 상태가 좋습니까? " + isGoodCondition1);


        bool isGoodCondition2 = health <= 50 || mana <= 20; //||(or) 양쪽 중 적어도 하나가 true 일 때만 출력

        Debug.Log("용사의 상태가 좋습니까? " + isGoodCondition2);


        string condition = isGoodCondition1 ? "좋음" : "나쁨"; //? A : B ?앞이 true 일때 A 출력, false 일때 B 출력

        Debug.Log("용사의 상태가 좋습니까? " + condition);




        //4.키워드
        //int float string bool new List




        //5.조건문
        if (condition == "나쁨") //괄호 안이 ture일때 출력
        {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요");
        }

        if (condition == "좋음")
        {
            Debug.Log("플레이어의 상태가 좋습니다.");
        }
        else //앞의 if가 실행되지 않으면 출력
        {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요");
        }


        if (isGoodCondition2 && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명물약30을 사용하였습니다.");
        }
        else if (isGoodCondition2 && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("마나물약30을 사용하였습니다.");
        }


        switch (monsters[1]) //변수의 값에 따라 로직 실행
        {
            case "슬라임":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default: //case에 들어가지 못했을 때
                Debug.Log("??? 몬스터가 출현!");
                break;
        }


        switch (monsters[1]) //변수의 값에 따라 로직 실행
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
        }




        //6.반복문
        while (health > 0) //조건이 true일 때, 로직 반복
        {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다." + health);
            else
                Debug.Log("사망하였습니다");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }


        for (int count=0; count<10; count++) //변수를 연산하면서 로직 실행 반복, (연산될 변수; 조건; 연산)
        {
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }


        foreach (string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }




        //7.변수 (메소드)
        Heal();


        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monsterLevel[index]));
        }




        //8.클래스 (하나의 오브젝트와 대응)
        Player player = new Player(); //인스턴스 : 클래스를 변수로 만들어줌 player은 변수 이름
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.weapon = "나무 지팡이";
        player.strength = 2.4f;
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다.");


        Debug.Log(player.move());
    }




    //7.함수 (메소드)
    void Heal() //변수 Heal
    {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
    }


    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";
        return result;
    }

}

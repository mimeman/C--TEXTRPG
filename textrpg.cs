using System;

namespace textrpg00
{
    class Program
    {
        #region 숲 몬스터
        enum FOREST1MONSTER
        {
            NONE = 0,
            RABBIT = 1,
            SNAKE = 2,
            BEAR = 3
        }
        #endregion

        #region 울창숲 몬스터
        enum FOREST2MONSTER //울창숲 몬스터
        {
            NONE = 0,
            GOBLIN = 1,
            SKELETION = 2,
            GOLEM = 3
        }
        #endregion

        struct Monster //몬스터들의 체력과 공격력 생성
        {
            public String name;
            public int hp;
            public int maxhp;
            public int at;

        }

        #region 몬스터 생성기
        static Monster CreateMonsterForest1()
        {
            Random random = new Random();
            int spawn = random.Next(7);
            int st = random.Next(1, 10);
            Monster _monster = new Monster();

            switch (spawn)
            {
                case (int)FOREST1MONSTER.NONE : //0
                    Console.WriteLine("놀랍게도 아무것도 나오지 않았다..");                    
                    break;

                case (int)FOREST1MONSTER.RABBIT :  //1
                    _monster.name = "토끼";
                    _monster.at = 10 + st;
                    _monster.hp = 35 + st;
                    Console.WriteLine("숲에서 토끼가 튀어나왔다...!");
                    break;

                case (int)FOREST1MONSTER.SNAKE: //2
                    _monster.name = "뱀";
                    _monster.at = 15 + st;
                    _monster.hp = 45 + st;
                    Console.WriteLine("숲에서 뱀이 튀어나왔다...!");
                    break;

                case 7 :
                    _monster.name = "곰";
                    _monster.at = 25 + st;
                    _monster.hp = 55 + st;
                    Console.WriteLine("숲에서 조금 강해보이는 곰이 튀어나왔다...!");
                    break;

                default:  //3,4,5,6
                    _monster.name = "개미";
                    _monster.at = 5 + st;
                    _monster.hp = 5 + st;
                    Console.WriteLine("숲에서 개미가 튀어나왔다....");
                    break;
            }

            return _monster;
        }

         static Monster CreateMonsterForest2()
        {
            Random random = new Random();
            int spawn = random.Next(7);
            int st = random.Next(1, 10);

            Monster _monster = new Monster(); //Struct Monster의 필드를 사용하기 위해 인스턴스화

            switch (spawn)
            {
                case (int)FOREST2MONSTER.NONE: //0
                    Console.WriteLine("놀랍게도 아무것도 나오지 않았다..");
                    break;

                case (int)FOREST2MONSTER.GOBLIN:  //1
                    _monster.name = "고블린";
                    _monster.at = 30 + st;
                    _monster.hp = 50 + st;
                    Console.WriteLine("울창한 숲에서 조금 강해보이는 고블린이 튀어나왔다...!");
                    break;

                case (int)FOREST2MONSTER.SKELETION: //2
                    _monster.name = "스켈레톤";
                    _monster.at = 35 + st;
                    _monster.hp = 55 + st;
                    Console.WriteLine("울창한 숲에서 조금 강해보이는 스켈레톤이 튀어나왔다...!");
                    break;

                case 7:
                    _monster.name = "골렘";
                    _monster.at = 45 + st;
                    _monster.hp = 100 + st;
                    Console.WriteLine("울창한 숲에서 강해보이는 골렘이 튀어나왔다...!");
                    break;

                default:  //3,4,5,6
                    _monster.name = "개미";
                    _monster.at = 15 + st;
                    _monster.hp = 15 + st;
                    Console.WriteLine("숲에서 개미가 튀어나왔다....");
                    break;
            }
            return _monster;
        }

        #endregion

        private static void Forest1()
        {
            CreateMonsterForest1();
                      
        }

        private static void Forest2()
        {
            CreateMonsterForest2();
        }

        private static void Town()
        {
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("(1) 숲으로 이동");
            Console.WriteLine("(2) 울창한 숲으로 이동");
            Console.WriteLine("(3) 휴식을 취한다 (HP,MP 회복)");
        }

        #region 전투
        private static int fight(Nomal nomal, Monster monster) //노말
        {
            Random random = new Random();
            int R_att = random.Next(2) + 1;
            int Player_att = 1;  
            int Monster_att = 2;

            if (R_att == Player_att) //플레이어 
            {
                Console.WriteLine("==========================================|");
                Console.WriteLine("(1) 공격한다                              |");
                Console.WriteLine("(2) 도망간다                              |");
                Console.WriteLine("==========================================|");

                int chi = int.Parse(Console.ReadLine());
            }

            return;
        }

        private static int fight(Wizard wizard, Monster monster) //마법사
        {

            return;
        }

        private static int fight(Warrior Warrior, Monster monster) //전사
        {

            return;
        }

        #endregion

        static int place = 0;
        // 1 = 마을, 2 =  숲, 3 = 울창한 숲

        static int Job = 0;
        // 1 = 전사, 2 = 마법사, 3 = 노비

        static void Main(string[] args)
        {
            #region text rpg 텍스트 출력
            String t1 = "                               _____   _____  __   __  _____  ______  ______   _____ ";
            String t2 = "                              |_   _| |  ___| ∖ ∖ / / |_   _| | ___ | | ___ | |  __ |";
            String t3 = "                                | |   | |__    ∖ V /    | |   | |_/ / | |_/ / | |   /";
            String t4 = "                                | |   | __ |   /  ∖     | |   |    /  | __ /  | | __ ";
            String t5 = "                                | |   | |___  / /^∖ ∖   | |   | | /   | |     | |_| |";
            String t6 = "                                |_|   |____/ /_/    ∖ ∖ |_|   |_| _]  |_|     |____/";
            

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            #endregion

            #region 직업선택
            Console.WriteLine("직업을 선택해주세요.");
            Console.WriteLine("(1) 전사");
            Console.WriteLine("(2) 마법사");
            Console.WriteLine("(3) ???");

            while (true)
            {
                int ChiJob = int.Parse(Console.ReadLine());
                Console.Clear(); //화면 지우개
                //딜레이

                switch (ChiJob) //스위치문으로 JOB을 읽어 실행
                {
                    case 1:
                        Console.WriteLine("(1) 전사를 선택하셨습니다.");
                        Warrior _Warrior = new Warrior(); //전사
                        break;

                    case 2:
                        Console.WriteLine("(2) 마법사를 선택하셨습니다.");
                        Wizard _Wizard = new Wizard();    //마법사
                        break;

                    case 3:
                        Console.WriteLine("(3) ??? 를 선택하셨습니다.");
                        Nomal _Nomal = new Nomal();
                        break;

                    default:
                        Console.WriteLine("다시 입력해주세요.");
                        break;
                }

                //예외처리
                if (ChiJob == 1 || ChiJob == 2 || ChiJob == 3)
                {
                    return;
                }
            }
            

            Console.Clear(); //화면 지우개
            #endregion
          
            #region 장소선택
            Console.WriteLine("다음중 어느 곳을 가시겠습니까?");
            Console.WriteLine("(1) 마을");
            Console.WriteLine("(2)  숲");
            Console.WriteLine("(3) 울창한 숲");


            while (true)
            {
                int ChiPlace = int.Parse(Console.ReadLine()); // 장소 선택
                Console.Clear(); //화면 지우개

                switch (ChiPlace)
                {
                    case 1:
                        Console.WriteLine("마을에 도착하셨습니다...\n");
                        Town();
                        break;

                    case 2:
                        Console.WriteLine("숲에 도착하셨습니다...\n");
                        Forest1();

                        break;

                    case 3:
                        Console.WriteLine("울창한 숲에 도착하셨습니다...\n" );
                        Forest2();
                        break;

                    case 4:
                        break;
                }



                //예외처리
                if (ChiPlace == 1 || ChiPlace == 2 || ChiPlace == 3)
                {
                    Console.WriteLine("다시 입력해주세요.");
                    return;
                }
            }
            #endregion


        }

    }
}

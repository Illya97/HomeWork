using System;
using System.Threading;
namespace Dota2
{

    class Dota2
    {
        class Hero
        {
            protected string name;
            protected int strength = 10;
            protected int agility = 10;
            protected int intelligence = 10;
            protected int damage;
            protected int health = 600;
            protected Iteam iteam;
            Iteam[] iteams = new Iteam[2];
            public void addIteame(Iteam iteam)
            {
                this.iteam = iteam;
                for (int i = 0; i < iteams.Length; i++)
                {
                    if (iteams[i] == null)
                    {
                        iteams[i] = iteam;
                        setStrength(iteam.getStrengthIteam()+getStrength());
                        setAgility(iteam.getAgilityIteam()+getAgility());
                        setIntelligence(iteam.getStrengthIteam()+getAgility());
                        setHealth(iteam.getHealthIteam() + getHealth());
                        setDamage(iteam.getDamageIteam() + getDamage());
                        break;
                    }
                }
            }
            public void getIteamInfo()
            {
                int counter = 0;
                Boolean iteamEmpty = true;
                Console.WriteLine("iteam: ");
                for (int i = 0; i < iteams.Length; i++)
                {
                    if (iteams[i] != null)
                    {
                    Console.WriteLine("\t"+iteams[i].getNameIteam()+" ; ");
                        iteamEmpty = false;
                        counter++;
                    }
                }
                if (iteamEmpty)
                {
                    Console.WriteLine("\t iteam is empty");
                }
                else
                {
                    Console.WriteLine("You have "+counter +
                        " items in your bags.");
                }
            }
            public String getName()
            {
                return name;
            }
            public int getStrength()
            {
                return strength;
            }
            public int getAgility()
            {
                return agility;
            }
            public int getIntelligence()
            {
                return intelligence;
            }
            public int getDamage()
            {
                return damage;
            }
            
            public int getHealth()
            {
                return health;
            }
            public void setName(string name)
            {
               this.name=name;
            }
            public void setStrength(int strength)
            {
                this.strength = strength;
            }
            public void setAgility(int agility)
            {
                this.agility = agility;
            }
            public void setIntelligence(int intelligence)
            {
                this.intelligence = intelligence;
            }
            virtual public void setDamage(){}

            public void setDamage(int damage)
            {
                this.damage = damage;
            }
            public void setHealth(int health)
            {
                this.health = health;
            }
            public void Hit(Hero opponent)
            {
                opponent.setHealth(opponent.getHealth()-getDamage());
            }
            virtual public String getInfo()
            {
                return "Name: " + getName() + "; Strength: " + getStrength() + "; Agility: " + getAgility() + "; Intelligence: " + getIntelligence() + "; Damege:" + getDamage() + "; Health:"+getHealth()+".";
            }
        }

        class Pudge : Hero
        {
            public Pudge()
            {
                setStrength(15);
                setAgility(4);
                setIntelligence(4);
                setName("Pudge");
                setDamage();
            }
            override public void setDamage()
            {
                damage = (getStrength() / 2) + (getAgility() / 4) + (getIntelligence() / 4);
                
            }
        }

        class Axe : Hero
        {
            public Axe()
            {
                setStrength(15);
                setAgility(10);
                setIntelligence(8);
                setName("Axe");
                setDamage();
            }
            override public void setDamage()
            {
                damage = (getStrength() / 2) + (getAgility() / 4) + (getIntelligence() / 4);
            }
        }

        class Oracle : Hero
        {
            public Oracle()
            {
                setStrength(10);
                setAgility(5);
                setIntelligence(11);
                setName("Oracle");
                setDamage();
            }
            override public void setDamage()
            {
                damage = (getStrength() / 4) + (getAgility() / 4) + (getIntelligence() / 2);
            }
        }
        class Dazzle : Hero
        {
            public Dazzle()
            {
                setStrength(8);
                setAgility(11);
                setIntelligence(15);
                setName("Dazzle");
                setDamage();
            }
            override public void setDamage()
            {
                damage = (getStrength() / 4) + (getAgility() / 4) + (getIntelligence() / 2);
            }
        }

        class Lion : Hero
        {
            public Lion()
            {
                setStrength(8);
                setAgility(5);
                setIntelligence(8);
                setName("Lion");
                setDamage();
            }
            override public void setDamage()
            {
                damage = (getStrength() / 4) + (getAgility() / 4) + (getIntelligence() / 2);
            } 
        }

        class Iteam
        {
            protected string name;
            protected int strength ;
            protected int agility ;
            protected int intelligence;
            protected int damage;
            protected int health ;
            virtual public String getNameIteam()
            {
                return name;
            }
            virtual public int getStrengthIteam()
            {
                return strength;
            }
            virtual public int getAgilityIteam()
            {
                return agility;
            }
            virtual public int getIntelligenceIteam()
            {
                return intelligence;
            }
            virtual public int getDamageIteam()
            {
               
                return damage;
            }
            virtual public int getHealthIteam()
            {

                return health;
            }
        }
        class DiveneRapier : Iteam
        {
            public DiveneRapier()
            {
                name = "DiveneRapier";
                damage = 150;
            }
            
        }
        class Satanic : Iteam
        {
            public Satanic()
            {
                name = "Satanic";
                damage = 150;
                strength = 25;
                health = 100;
            }
        }
        class Butterfly : Iteam
        {
            public Butterfly()
            {
                name = "Butterfly";
                agility = 35;
                health = 50;
            }
        }
        class EyeOfSkadi : Iteam
        {
            public EyeOfSkadi()
            {
                name = "EyeOfSkadi";
                strength = 25;
                agility = 25;
                intelligence = 25;
                health = 250;
            }
        }
        static void Main(string[] args)
        {
          
            Hero[] heroes = new Hero[5];
            Random rnd = new Random();

            //Заповнення масиву героїв
            heroes[0] = new Dazzle();
            heroes[1] = new Lion();
            heroes[2] = new Pudge();
            heroes[3] = new Oracle();
            heroes[4] = new Axe();

            // Вибір рандомних героїв
            Hero firstfiters;
            Hero secondFiter;
            int numberOne = rnd.Next(0, heroes.Length - 1);
            int numberTwo;
            Boolean check;
            firstfiters = heroes[numberOne];
            do
            {
                check = true;
                numberTwo = rnd.Next(0, heroes.Length - 1);
                if (numberOne != numberTwo)
                {
                    check = false;
                }
            } while (check);
            secondFiter = heroes[numberTwo];
            // 
            Iteam[] items = new Iteam[4];

            //Заповнення масиву айтемів
            items[0] = new DiveneRapier();
            items[1] = new EyeOfSkadi();
            items[2] = new Satanic();
            items[3] = new Butterfly();
            Console.WriteLine("Two heroes take part in the fight:");
            Console.WriteLine(firstfiters.getInfo());
            Console.WriteLine(secondFiter.getInfo());
            Console.WriteLine();
            Console.WriteLine("Choose two items for each hero.");
            //Рандомно генеруєм у героїв перед файтом по два айтема 
            firstfiters.addIteame(items[rnd.Next(0, items.Length - 1)]);
            firstfiters.addIteame(items[rnd.Next(0, items.Length - 1)]);
            secondFiter.addIteame(items[rnd.Next(0, items.Length - 1)]);
            secondFiter.addIteame(items[rnd.Next(0, items.Length - 1)]);
            Console.WriteLine("Bag "+firstfiters.getName()+":");
            firstfiters.getIteamInfo();
            Console.WriteLine("Bag " + secondFiter.getName() + ":");
            secondFiter.getIteamInfo();
            Console.WriteLine("Characteristics of the hero with the items.");
            Console.WriteLine(firstfiters.getInfo());
            Console.WriteLine(secondFiter.getInfo());
            Console.WriteLine("");

            do
            {
                Thread.Sleep(2000);
                Console.WriteLine(firstfiters.getName()+ " to strike.");
                firstfiters.Hit(secondFiter);
                Thread.Sleep(2000);
                if (secondFiter.getHealth() < 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(secondFiter.getName() + " to strike.");
                    secondFiter.Hit(firstfiters);
                }

            } while (secondFiter.getHealth()>0&&firstfiters.getHealth()>0);

            if (firstfiters.getHealth() < 0)
            {
                firstfiters.setHealth(0);
                Console.WriteLine("Won the battle " + secondFiter.getName() + ".");
                Console.WriteLine("He has " + secondFiter.getHealth()+"hp.");
                Console.WriteLine(firstfiters.getName() +" has "+ firstfiters.getHealth() + "hp.");
            }
            else
            {
                secondFiter.setHealth(0);
                Console.WriteLine("Won the battle " + firstfiters.getName() + ".");
                Console.WriteLine("He has " + firstfiters.getHealth() + "hp.");
                Console.WriteLine(secondFiter.getName() + " has " + secondFiter.getHealth() + "hp.");

            }

        }
       
    }
}


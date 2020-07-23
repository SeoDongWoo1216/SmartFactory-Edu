using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _20200601_002
{
    class Car
    {
        /*
        int iSpeed;
        // get스피드 set스피드 반환타입없는 Speed
        public int GetSpeed()   // iSpeed를 캡슐화시켜났다.
        {
            return iSpeed;
        }
        public void SetSpeed(int _iSpeed)
        {
            if (150<_iSpeed)         
            {                       
                _iSpeed = 150;        
            }
            iSpeed = _iSpeed;     
        }
        */
        int iSpeed;
        public int Speed
        {
            get 
            { 
                return iSpeed;
            }
            set
            {
                if (150 < value)
                {
                    value = 150;
                }
                iSpeed = value;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                /*
             Car MyCar = new Car();
             MyCar.SetSpeed(100); 
             Console.WriteLine("현재 속도 : {0}km/h 입니다", MyCar.GetSpeed());
             MyCar.SetSpeed(300);
             Console.WriteLine("현재 속도 : {0}km/h 입니다", MyCar.GetSpeed()); 
                */
              Car MyCar = new Car();
              MyCar.Speed = 100;
              Console.WriteLine("현재 속도 : 시속 {0}Km", MyCar.Speed);
              MyCar.Speed = 3000;
              Console.WriteLine("현재 속도 : 시속 {0}Km", MyCar.Speed);

            }
        }
     }
        /*  
         출력화면
         현재 속도 : 100km
         현재 속도 : 150km
        */
 }


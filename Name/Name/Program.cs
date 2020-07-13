using Newtonsoft.Json;
using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {

            //People wangzhuo = new People();
            //wangzhuo.Age = 18;
            //People xiaohong = new People();
            //xiaohong.Age = 16;
            //People xiaoming = new People();
            //xiaoming.Age = 13;


            PeopleCurdRepository Database = new PeopleCurdRepository();
          
            //Database.Add(wangzhuo);
            //Database.Add(xiaohong);
            //Database.Add(xiaoming);


            //序列化
            Console.WriteLine(JsonConvert.SerializeObject(Database.GetAll()));

            ////反序列化
            ///wangzhuo3=wangzhuo; 
            ////clone  深拷贝
            //People wangzhuo2 = JsonConvert.DeserializeObject<People>("sadasdsafsadsda");



        }
        
    }
    class PeopleCurdRepository : RepositoryBase<People> { }
    class People :DomainModel
    {
        public People()
        {


        }

        //成员方法 行为
        public void Eat(int foodSize)
        {
            HungerIndex = HungerIndex + foodSize / 2;
        }
        //成员变量
        int HungerIndex;
        public string Name;
        public bool Gender;
        public int Age;
        public DateTime Birthday;
        public string Professional;
    }
}

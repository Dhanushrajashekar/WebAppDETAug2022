using System.Data;
using MVCDemo.Models;
using MVCDemo.Services;



namespace xUnitTestDemo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(PizzaServices.GetAll().Count, 2);



        }
        [Fact]
        public void TestAddPizza()
        {
            Pizza p = new Pizza { Name = "Peri Peri Pizza", Size = PizzaSize.Medium, IsGlutenFree = true };
            PizzaServices.Add(p);
            Pizza verify = PizzaServices.Get(3);



            Assert.Equal(3, PizzaServices.GetAll().Count);
            Assert.Equal(p.Id, verify.Id);
        }
        [Fact]
        public void TestDelete()
        {
            PizzaServices.Delete(3);
            Assert.Equal(2, PizzaServices.GetAll().Count);
        }
        [Fact]
        public void TestUpdate()
        {
            Pizza p = new Pizza { Id = 2, Name = "Mozeralla", Size = PizzaSize.Medium, IsGlutenFree = true };
            PizzaServices.Update(p);
            Pizza verify = PizzaServices.Get(2);
            Assert.Equal(verify.Name, "Monzeralla");
        }
    }



}
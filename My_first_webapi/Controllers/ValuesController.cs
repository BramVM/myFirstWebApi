using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace My_first_webapi.Controllers
{
    public class OrderItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Order
    {
        public int ID { get; set; }
        public List<OrderItem> Items { get; set; }
    }
    public class Person
    {
        public int ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public List<Order> Orders { get; set; }
    }
    public class PersonController : ApiController
    {
        // GET api/person
        public IEnumerable<Person> Get()
        {
            OrderItem itemA = new OrderItem { ID = 0, Name = "Steven's Sextape"};
            OrderItem itemB = new OrderItem { ID = 1, Name = "Teemo's blowpipe" };
            OrderItem itemC = new OrderItem { ID = 2, Name = "Olaf's handaxe"};

            Order OrderA = new Order { ID = 0, Items = new List<OrderItem> { itemA, itemB, itemC } };
            Order OrderB = new Order { ID = 1, Items = new List<OrderItem> { itemA, itemB } };
            Order OrderC = new Order { ID = 2, Items = new List<OrderItem> { itemB, itemC } };
            Order OrderD = new Order { ID = 3, Items = new List<OrderItem> { itemA, itemC } };

            return new List<Person> { 
                new Person{ ID = 0, First = "Bram", Last ="Van Mensel" , Orders= new List<Order> {OrderA, OrderB}},
                new Person{ ID = 1, First = "Jhon", Last ="Doe", Orders= new List<Order> {OrderC}},
                new Person{ ID = 2, First = "Wiliam", Last ="Smith", Orders= new List<Order> {OrderD}}
            };
        }

        // GET api/person/5
        public Person Get(int id)
        {
            return null;
        }

        // POST api/person
        public void Post([FromBody]Person value)
        {
        }

        // PUT api/person/5
        public void Put(int id, [FromBody]Person value)
        {
        }

        // DELETE api/person/5
        public void Delete(int id)
        {
        }
    }
}
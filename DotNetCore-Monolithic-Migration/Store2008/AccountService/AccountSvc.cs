using System;
using System.Collections.Generic;
            
namespace AccountService
{
    public class AccountSvc
    {
        public AccountSvc()
        {
        }

        public IEnumerable<Consumer> Get(){
            //stub
            //method would actually make SQL READ all from database

            var consumers = new List<Consumer>(){
                new Consumer()
                {
                    Id = 111,
                    Firstname = "Jeremy",
                    Surname = "Cook",
                    Age = 20
                },
                new Consumer(){
                    Id = 112,
                    Firstname = "Bob",
                    Surname = "Smith",
                    Age = 43
                },
                new Consumer(){
                    Id = 113,
                    Firstname = "John",
                    Surname = "Doe",
                    Age = 21
                },
                new Consumer(){
                    Id = 114,
                    Firstname = "Mary",
                    Surname = "Doe",
                    Age = 45
                }
            };

            return consumers;
        }

        public Consumer GetConsumerById(int id){
            //stub
            //method would actually make SQL READ from database
            //with WHERE clause on id

            var consumer = new Consumer()
            {
                Id = id,
                Firstname = "Jeremy",
                Surname = "Cook",
                Age = 20
            };

            return consumer;
        }

        public Consumer SaveConsumer(Consumer consumer){
            //stub
            //method would actually make SQL WRITE into database

            var saved_consumer = new Consumer()
            {
                Id = 100,
                Firstname = consumer.Firstname,
                Surname = consumer.Surname,
                Age = consumer.Age
            };

            return saved_consumer;
        }

        public Consumer UpdateConsumer(int id, Consumer consumer){
            //stub
            //method would actually make SQL UPDATE into database

            var updated_consumer = new Consumer()
            {
                Id = id,
                Firstname = consumer.Firstname,
                Surname = consumer.Surname,
                Age = consumer.Age
            };

            return updated_consumer;
        }

        public void DeleteConsumer(int id){
            //stub
            //method would actually make SQL DELETE into database
        }
    }
}

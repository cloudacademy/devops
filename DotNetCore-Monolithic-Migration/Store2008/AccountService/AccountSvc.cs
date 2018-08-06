using System;
namespace AccountService
{
    public class AccountSvc
    {
        public AccountSvc()
        {
        }

        public Consumer GetConsumerById(int ConsumerId){
            var consumer = new Consumer()
            {
                Firstname = "Jeremy",
                Surname = "Cook",
                Age = 20
            };

            return consumer;
        }
    }
}

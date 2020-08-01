using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces.Handlers
{
    interface IHandler
    {
        void SetNextHandler(IHandler handler);
        void Process(Request request);
    }
   
    class Request
    {
        public object Data { get; set; }
        public List<string> ValidationMessages;

        public Request()
        {
            ValidationMessages = new List<string>();
        }
    }

    class BaseHandler : IHandler
    {
        protected IHandler _nextHandler;
        public BaseHandler()
        {
            _nextHandler = null;
        }
        public virtual void Process(Request request)
        {
            throw new NotImplementedException();
        }

        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }
    }

    class Person
    {
        public string name;
        public int age;
        public float income;
    }

    class MaxAgeHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is Person person)
            {
                if (person.age > 65) request.ValidationMessages.Add("Invalid");
                if (_nextHandler != null) _nextHandler.Process(request);
            }
            else
            {
                throw new Exception("Invalid Message");
            }
        }
    }

    class MaxNameLengthHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.name.Length > 10) request.ValidationMessages.Add("Too Long");
                if (_nextHandler != null) _nextHandler.Process(request);
            }
            else
            {
                throw new Exception("Invalid Message");
            }
        }
    }
    class MaxIncomeHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.income > 10000) request.ValidationMessages.Add("Too Rich");
                if (_nextHandler != null) _nextHandler.Process(request);
            }
            else
            {
                throw new Exception("Invalid Message");
            }
        }
    }
     
}

/*
 en otra clase

MaxNameLengthHandler maxNameLengthHandler = new MaxNameLengthHandler();
MaxAgeHandler maxAgeHandler = new MaxAgeHandler();
MaxIncomeHandler maxIncomeHandler = new MaxIncomeHandler();

maxNameLengthHandler.setNextHandler(maxAgeHandler);
maxAgeHandler.setNextHandler(maxIncomeHandler);
maxNameLengthHandler.Process(request);

 */


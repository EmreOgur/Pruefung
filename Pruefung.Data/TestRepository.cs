using Pruefung.Contract.Repositories;
using System;
using System.Linq;
using Pruefung.Contract.Models;
using System.Collections.Generic;

namespace Pruefung.Data
{
    public class TestRepository : ITestRepository
    {
        private List<Message> Messages = new List<Message> { new Message { Date = DateTime.Now, Text = "First" } };

        public IQueryable<Message> GetMessages()
        {
            return Messages.AsQueryable();
        }

        public void SaveMessage(Message message)
        {
            Messages.Add(message);
        }
    }
}

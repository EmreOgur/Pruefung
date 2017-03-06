using Pruefung.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Pruefung.Contract.Models;
using Pruefung.Contract.Repositories;

namespace Pruefung.Core
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public IReadOnlyCollection<Message> GetMessages(DateTime fromDate)
        {
            return _testRepository.GetMessages().Where(m => m.Date >= fromDate).ToList();
        }

        public void SaveMessage(string message)
        {
            _testRepository.SaveMessage(new Message { Date = DateTime.Now, Text = message });
        }
    }
}

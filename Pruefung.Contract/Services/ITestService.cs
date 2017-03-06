using Pruefung.Contract.Models;
using System;
using System.Collections.Generic;

namespace Pruefung.Contract.Services
{
    public interface ITestService
    {
        IReadOnlyCollection<Message> GetMessages(DateTime fromDate);
        void SaveMessage(string message);
    }
}

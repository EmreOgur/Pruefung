using Pruefung.Contract.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pruefung.Contract.Repositories
{
    public interface ITestRepository
    {
        IQueryable<Message> GetMessages();
        void SaveMessage(Message message);
    }
}

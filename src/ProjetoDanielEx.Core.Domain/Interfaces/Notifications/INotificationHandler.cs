using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.Domain.Interfaces.Notifications
{
    public interface INotificationHandler<T> where T : class
    {
        Task Handle(T notification);
    }
}

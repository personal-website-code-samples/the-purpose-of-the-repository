using System;
using System.Threading.Tasks;

namespace RepositoryPurpose
{
    public interface IWidgetRepository
    {
        Task AddWidget(Widget widget);

        Task<Widget> GetWidgetById(Guid id);

        Task DeleteWidgetById(Guid id);
    }
}

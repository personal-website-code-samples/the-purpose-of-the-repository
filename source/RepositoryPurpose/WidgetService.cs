using System;
using System.Threading.Tasks;

namespace RepositoryPurpose
{
    public class WidgetService : IWidgetService
    {
        private readonly IWidgetRepository _widgetRepository;

        public WidgetService(IWidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
        }

        public async Task<Widget> FindWidget(Guid id)
        {
            Widget widget = null;

            // Retrieve widget from some data source.

            if (widget != null)
            {
                return widget;
            }

            return Widget.EmptyWidget();
        }
    }
}

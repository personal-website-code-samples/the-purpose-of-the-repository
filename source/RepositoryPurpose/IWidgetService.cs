using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPurpose
{
    public interface IWidgetService
    {
        Task<Widget> FindWidget(Guid id);
    }
}

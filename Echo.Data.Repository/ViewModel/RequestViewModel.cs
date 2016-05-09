using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echo.Data.Repository;

namespace Echo.Data.Repository.ViewModel
{
    public class RequestViewModel : ViewModelBase<Request>
    {
        public bool Save(Request _request)
        {
            try
            {
                Add(_request);

                return true;
            }
            catch(Exception error)
            {
                return false;
            }
        }
    }
}

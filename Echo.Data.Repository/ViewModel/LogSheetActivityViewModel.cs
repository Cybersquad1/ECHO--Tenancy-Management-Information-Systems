using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class LogSheetActivityViewModel : ViewModelBase<LogSheetActivity>
    {
        public List<LogSheetActivity> GetAll()
        {
            return Find().OrderByDescending(r => r.Date).ToList();
        }

        public bool Save(LogSheetActivity _logSheetActivity)
        {
            try
            {
                Add(_logSheetActivity);

                var logSheetVM = new LogSheetViewModel();

                if (!logSheetVM.UpdateQuantity(_logSheetActivity.ItemID, _logSheetActivity.Balance))
                {
                    return false;
                }
                    
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

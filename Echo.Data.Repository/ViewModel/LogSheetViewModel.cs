using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class LogSheetViewModel : ViewModelBase<LogSheet>
    {
        public List<LogSheet> GetItems()
        {
            //Get all items
            return Find() ;
        }

        public LogSheet GetSelectedItem(string _item)
        {
            return GetEntity(r => r.Item.ToUpper() == _item.ToUpper());
        }

        public bool Save(LogSheet _item)
        {
            try
            {
                _item.Item = _item.Item.ToUpper(); //Convert all character to capital letters

                Save(_item);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

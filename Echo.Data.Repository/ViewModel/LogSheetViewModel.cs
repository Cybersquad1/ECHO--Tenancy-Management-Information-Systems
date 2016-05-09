using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class LogSheetViewModel : ViewModelBase<LogSheet>
    {
        public bool UpdateQuantity(Guid? _itemID, int? _quantity)
        {
            try
            {
                var entity = GetEntity(r => r.ID == _itemID);

                entity.Quantity = entity.Quantity - _quantity;

                Update(entity);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Modify(LogSheet _logSheet)
        {
            try
            {
                var edit = GetEntity(r => r.ID == _logSheet.ID);

                edit.Item = _logSheet.Item;

                edit.Quantity = _logSheet.Quantity;

                edit.DateModified = DateTime.Now;

                edit.ModifiedBy = _logSheet.ModifiedBy;

                Update(edit);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public LogSheet GetSelectedID(Guid? _itemID)
        {
            return GetEntity(r => r.ID == _itemID);
        }

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
                Add(_item);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

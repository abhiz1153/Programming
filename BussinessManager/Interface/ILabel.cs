using Common.Models.LabelModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Interface
{
   public interface ILabel
    {
        string Add(LabelModel labelModel);
        string Update(LabelModel labelModel);
        string Delete(int id);
        List<LabelModel> GetAllList();
        List<LabelModel> GetLabel(int id);
    }
}

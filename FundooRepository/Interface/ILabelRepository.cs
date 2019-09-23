using Common.Models.LabelModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interface
{
    public interface ILabelRepository
    {
        string AddLabel(LabelModel labelModel);
        string UpdateLabel(LabelModel labelModel);
        string DeleteLabel(int id);
        List<LabelModel> GetList();
        List<LabelModel> GetLabel(int id);
    }
}

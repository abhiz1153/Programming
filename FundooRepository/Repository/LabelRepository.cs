using Common.Models.LabelModels;
using FundooRepository.DBContext;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class LabelRepository : ILabelRepository
    {
        private readonly UserContext userContext;
        public LabelRepository(UserContext user)
        {
            this.userContext = user;
        }
        public string AddLabel(LabelModel labelModel)
        {
            LabelModel add = new LabelModel()
            {
                Email = labelModel.Email,
                Label = labelModel.Label
            };
             this.userContext.Labels.Add(add);
            this.userContext.SaveChanges();
            return "DONE";
        }
        public string UpdateLabel(LabelModel labelModel)
        {
            var result = userContext.Labels.Where(r => r.Id == labelModel.Id).SingleOrDefault();
            if (result != null)
            {
                result.Email = labelModel.Email;
                result.Label = labelModel.Label;

                userContext.Labels.Update(result);
            }
            userContext.SaveChanges();
            return "DONE";
        }
        public string DeleteLabel(int id)
        {
            var label = userContext.Labels.Where(r => r.Id == id).SingleOrDefault();
            if (label != null)
            {
                userContext.Labels.Remove(label);
            }
            userContext.SaveChanges();
            return "DONE";
        }
        public List<LabelModel> GetList()
        {
            return this.userContext.Labels.ToList<LabelModel>();
        }
        public List<LabelModel> GetLabel(int id)
        {
            var note = userContext.Labels.Where(r => r.Id == id).SingleOrDefault();
            if (note != null)
            {
                return userContext.Labels.Where(r => r.Id == id).ToList();
            }
            return null;
        }
    }
}

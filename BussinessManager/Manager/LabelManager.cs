using BussinessManager.Interface;
using Common.Models.LabelModels;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    public class LabelManager : ILabel
    {
        public readonly ILabelRepository labelRepository;
        public LabelManager(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }
        public string Add(LabelModel labelModel)
        {
            try
            {
                this.labelRepository.AddLabel(labelModel);
                return "LABEL ADDED SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public string Update(LabelModel labelModel)
        {
            try
            {
                this.labelRepository.UpdateLabel(labelModel);
                return "LABEL UPDATED SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public string Delete(int id)
        {
            try
            {
                this.labelRepository.DeleteLabel(id);
                return "LABEL DELETED SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<LabelModel> GetAllList()
        {
            try
            {
                var list = new List<LabelModel>();
                var result = this.labelRepository.GetList();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<LabelModel> GetLabel(string email)
        {
            try
            {
                var list = new List<LabelModel>();
                var result = this.labelRepository.GetLabel(email);
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
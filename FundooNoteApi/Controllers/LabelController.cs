using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessManager.Interface;
using Common.Models.LabelModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooNoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        public readonly ILabel label;
        public LabelController(ILabel label)
        {
            this.label = label;
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(LabelModel labelModel)
        {
            try
            {
                var result = this.label.Add(labelModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = this.label.Delete(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        public IActionResult Update(LabelModel labelModel)
        {
            try
            {
                var result = this.label.Update(labelModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [HttpGet, Authorize]
        [Route("view")]
        public List<LabelModel> List()
        {
            return this.label.GetAllList();
        }
        [HttpGet]
        [Route("label")]
        public List<LabelModel> List(int id)
        {
            return this.label.GetLabel(id);
        }
    }
}

using Common.Models.NotesModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interface
{
    public interface INotesRepository
    {
        Task AddNotes(NotesModel notesModel);
        Task DeleteNotes(int id);
        Task UpdateNotes(NotesModel notesModel);
        List<NotesModel> GetList();
        List<NotesModel> GetNotes(int id);
    }
}

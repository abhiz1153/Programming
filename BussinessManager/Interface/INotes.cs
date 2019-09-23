using Common.Models.NotesModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BussinessManager.Interface
{
    public interface INotes
    {
        Task<string> AddAsync(NotesModel notesModel);
        Task<string> DeleteAsync(int id);
        Task<string> UpdateAsync(NotesModel notesModel);
        List<NotesModel> GetAllListAsync();
        List<NotesModel> GetNotesAsync(int id);
        Task<string> IsArchiveAsync(int id);
        Task<string> IsTrashAsync(int id);
        Task<string> IsPinAsync(int id);

    }
}
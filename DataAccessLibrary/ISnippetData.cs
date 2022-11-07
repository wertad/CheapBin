using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface ISnippetData
    {
        Task DeleteSnippet(SnippetModel snippet);
        Task<List<SnippetModel>> GetSnippet();
        Task InsertSnippet(SnippetModel snippet);
    }
}
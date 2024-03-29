﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary;

public class SnippetData : ISnippetData
{
	private readonly ISqlDataAccess _db;

	public SnippetData(ISqlDataAccess db)
	{
		_db = db;
	}

	public Task<List<SnippetModel>> GetSnippet()
	{
		string sql = "SELECT * FROM Snippets";

		return _db.LoadData<SnippetModel, dynamic>(sql, new { });
	}

	public Task InsertSnippet(SnippetModel snippet)
	{
		string sql = @"INSERT INTO Snippets (Title, Snippet, CreatedTime, ModifyTime)
					   VALUES (@Title, @Snippet, @CreatedTime, @ModifyTime);";

		return _db.SaveData(sql, snippet);
	}

    public Task UpdateSnippet(SnippetModel snippet)
    {
        string sql = @"UPDATE Snippets
					   SET Title = @Title, Snippet = @Snippet, ModifyTime = @ModifyTime
					   WHERE Id = @Id;";

        return _db.SaveData(sql, snippet);
    }


    public Task DeleteSnippet(SnippetModel snippet)
	{
		string sql = @"DELETE FROM Snippets WHERE Id=@Id";

		return _db.SaveData(sql, snippet);
	}
}

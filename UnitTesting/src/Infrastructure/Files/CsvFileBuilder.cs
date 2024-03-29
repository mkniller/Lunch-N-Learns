﻿using System.Globalization;
using UnitTesting.Application.Common.Interfaces;
using UnitTesting.Application.TodoLists.Queries.ExportTodos;
using UnitTesting.Infrastructure.Files.Maps;
using CsvHelper;

namespace UnitTesting.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}

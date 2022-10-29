using System;
using System.Collections.Generic;
using InteractiveTable;
using Io;
using Microsoft.AspNetCore.Mvc;

namespace TableApi.Controllers
{
    [ApiController]
    [Route("table/get")]
    public class TableController : ControllerBase
    {
        private IImportHandler<Person> ImportHandler { get; }
        private ITableBuilder<Person> TableBuilder { get; }

        public TableController(IImportHandler<Person> importHandler, ITableBuilder<Person> tableBuilder)
        {
            ImportHandler = importHandler;
            TableBuilder = tableBuilder;
        }

        [HttpGet("filepath")]
        public string GetTablePath()
        {
            return ImportHandler.FilePath;
        }

        [HttpGet]
        public Table GetTable()
        {
            var data = ImportHandler.ImportTable();
            var table = TableBuilder.CreateTable(data);


            return table;
        }

        [HttpGet("data/")]
        public List<object> GetFullTableWithData()
        {
            var data = ImportHandler.ImportTable();
            var table = TableBuilder.CreateTable(data);
            List<object> tableData = TableBuilder.ConvertTableToData(table);


            return tableData;
        }

        [HttpGet("data/page/{id}")]
        public ActionResult<List<List<object>>> GetTablePageWithData(int id)
        {
            var data = ImportHandler.ImportTable();
            var table = TableBuilder.CreateTable(data);
            List<List<object>> page;

            page = table.ReadPage(id);


            return page;
        }
    }
}
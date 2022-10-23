using System;
using System.Collections.Generic;
using InteractiveTable;
using Io;
using Logger;
using Microsoft.AspNetCore.Mvc;

namespace TableApi.Controllers
{
    [ApiController]
    [Route("table/get")]
    public class TableController : ControllerBase
    {
        public ILogger Logger { get; set; }

        public TableController(ILogger logger)
        {
            Logger = logger;
        }

        public ImportManager<Person> ImportManager { get; set; } = new ImportManager<Person>(new FileLogger());

        [HttpGet]
        public Table Get()
        {
            var data = ImportManager.ImportTable();
            var tableBuilder = new TableBuilder<Person>(Logger);
            var table = tableBuilder.CreateTable(data);


            return table;
        }
        
        [Route("data/")]
        public List<object> GetFullTable()
        {
            var data = ImportManager.ImportTable();
            var tableBuilder = new TableBuilder<Person>(Logger);
            var table = tableBuilder.CreateTable(data);
            List<object> tableData = tableBuilder.ConvertTableToData(table);


            return tableData;
        }

        [Route("data/page/{id}")]
        public ActionResult<List<List<object>>> Get(int id)
        {
            var data = ImportManager.ImportTable();
            var tableBuilder = new TableBuilder<Person>(Logger);
            var table = tableBuilder.CreateTable(data);
            List<List<object>> page; 
            try
            {
                page = table.ReadPage(id);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e);
            }


            return page;
        }
    }
}
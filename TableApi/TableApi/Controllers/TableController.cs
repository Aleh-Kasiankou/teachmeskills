﻿using System;
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
        private IImportHandler<Person> ImportHandler { get;}
        private ITableBuilder<Person> TableBuilder { get;}

        public TableController(IImportHandler<Person> importHandler, ITableBuilder<Person> tableBuilder)
        {
            ImportHandler = importHandler;
            TableBuilder = tableBuilder;
        }

        [HttpGet]
        [Route("filepath")]
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
        
        [Route("data/")]
        public List<object> GetFullTableWithData()
        {
            var data = ImportHandler.ImportTable();
            var table = TableBuilder.CreateTable(data);
            List<object> tableData = TableBuilder.ConvertTableToData(table);


            return tableData;
        }

        [Route("data/page/{id}")]
        public ActionResult<List<List<object>>> GetTablePageWithData(int id)
        {
            var data = ImportHandler.ImportTable();
            var table = TableBuilder.CreateTable(data);
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
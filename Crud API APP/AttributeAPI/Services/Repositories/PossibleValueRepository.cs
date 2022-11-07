﻿// using System.Collections.Generic;
// using System.Linq;
// using API.Entities;
// using API.Helpers;
// using Microsoft.Extensions.Options;
//
// namespace API.Services.Repositories
// {
//     public class PossibleValueRepository : IRepository<PossibleValueEntity>
//     {
//         public PossibleValueRepository(IOptions<ConnectionStrings> credentials)
//         {
//             Db = new DataBase(credentials);
//         }
//
//         private DataBase Db { get; }
//         
//         public List<PossibleValueEntity> GetAll()
//         {
//             var possibleValueList = Db.PossibleValue.ToList();
//
//             return possibleValueList;
//         }
//
//         public PossibleValueEntity GetById(int id)
//         {
//             var possibleValueEntity = Db.PossibleValue.First(valueEntity => valueEntity.Id == id);
//             return possibleValueEntity;
//         }
//
//         public int Create(PossibleValueEntity valueEntity)
//         {
//             Db.PossibleValue.Add(valueEntity);
//             Db.SaveChanges();
//             return valueEntity.Id;
//         }
//
//         public void UpdateById(int id)
//         {
//             throw new System.NotImplementedException();
//         }
//
//         public void RemoveById(int id)
//         {
//             var entityToRemove = Db.PossibleValue.First(valueEntity => valueEntity.Id == id);
//             Db.PossibleValue.Remove(entityToRemove);
//             Db.SaveChanges();
//         }
//     }
// }
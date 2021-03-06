﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Capawcino.DatabaseManager;
using DTD.Capawcino.Entities;
using MongoDB.Driver;
using Tag = DTD.Capawcino.Entities.Tag;

namespace DTD.Capawcino.BusinessLogic
{
    public class CredentialManager
    {

        public void CreateUser(User user)
        {
            CRUDManager crudManager = new CRUDManager();
            crudManager.InsertRecord(DatabaseStrings.UserTable,user);
        }

        public bool ValidateUser(string userName,string password)
        {
            CRUDManager crudManager = new CRUDManager();
            FilterDefinition<User> filter= Builders<User>.Filter.Eq("Name", userName);
            var user= crudManager.LoadRecordByFilter(DatabaseStrings.UserTable, filter);
            if (user == null) return false;
            return user.Password == password;

        }


        public void InitialDatabaseSetup()
        {
            if(!new DatabaseQueries().CollectionExists(DatabaseStrings.UserTable))
            {
                User baseUser = new User() { Name = "admin", Password = "admin" };
                new CRUDManager().InsertRecord(DatabaseStrings.UserTable, baseUser);
            }
          

            if (!new DatabaseQueries().CollectionExists(DatabaseStrings.ProductTable))
            {
                new CRUDManager().InsertRecord(DatabaseStrings.ProductTable, new Product(){Name = "Default"});
            }


            if (!new DatabaseQueries().CollectionExists(DatabaseStrings.TypeTable))
            {
                new CRUDManager().InsertRecord(DatabaseStrings.TypeTable, new ProductType(){Name = "Default"});
            }


            if (!new DatabaseQueries().CollectionExists(DatabaseStrings.TagsTable))
            {
                new CRUDManager().InsertRecord(DatabaseStrings.TagsTable, new Tag() { Name = "Default" });
            }

            if (!new DatabaseQueries().CollectionExists(DatabaseStrings.ClientsTable))
            {
                new CRUDManager().InsertRecord(DatabaseStrings.ClientsTable, new Client() { Name = "Default" });
            }

            if (!new DatabaseQueries().CollectionExists(DatabaseStrings.BusinessConfigTable))
            {
                new CRUDManager().InsertRecord(DatabaseStrings.BusinessConfigTable, new BusinessConfigurations(){VatAmount = 0.15f});
            }

        }





    }
}

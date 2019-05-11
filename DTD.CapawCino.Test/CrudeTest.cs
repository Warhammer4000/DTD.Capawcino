using System;
using System.Linq;
using DTD.Capawcino.BusinessLogic;
using DTD.Capawcino.DatabaseManager;
using DTD.Capawcino.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DTD.CapawCino.Test
{
    [TestClass]
    public class CrudeTest
    {
        [TestMethod]
        public void InsertData()
        {
            CRUDManager manager = new CRUDManager();
            /*Product product=new Product();
            product.Name = "Tazim";
            product.Cost = 10;
            manager.InsertRecord("Product",product);*/

            Product RecievedProduct = manager.LoadRecords<Product>("Product").First();

            Assert.AreEqual(RecievedProduct.Name,"Tazim");

        }

        [TestMethod]
        public void CheckUserTableExist()
        {
            DatabaseQueries manager = new DatabaseQueries();
            Assert.IsTrue(manager.CollectionExists(DatabaseStrings.UserTable));

        }

    }
}

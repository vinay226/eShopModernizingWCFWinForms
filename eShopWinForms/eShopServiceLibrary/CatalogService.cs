﻿using eShopServiceLibrary.Models;
using eShopServiceLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace eShopServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CatalogService" in both code and config file together.
    public class CatalogService : ICatalogService
    {
        private eShopDatabaseEntities ents;

        public CatalogService()
        {
            ents = new eShopDatabaseEntities();
        }

        public CatalogService(eShopDatabaseEntities ents)
        {
            this.ents = ents;
        }

        public PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize, int pageIndex)
        {
            var totalItems = ents.CatalogItems.LongCount();

            var itemsOnPage = ents.CatalogItems
                .Include(c => c.CatalogBrand)
                .Include(c => c.CatalogType)
                .OrderBy(c => c.Id)
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToList();

            return new PaginatedItemsViewModel<CatalogItem>(
                pageIndex, pageSize, totalItems, itemsOnPage);
        }

        public CatalogItem FindCatalogItem(int id)
        {
            return ents.CatalogItems.FirstOrDefault(x => x.Id == id);
        }
        public List<CatalogType> GetCatalogTypes()
        {
            return ents.CatalogTypes.ToList();
        }

        public List<CatalogBrand> GetCatalogBrands()
        {
            return ents.CatalogBrands.ToList();
        }

        public void CreateCatalogItem(CatalogItem catalogItem)
        {
            var maxId = ents.CatalogItems.Max(i => i.Id);
            catalogItem.Id = ++maxId;
            ents.CatalogItems.Add(catalogItem);
            ents.SaveChanges();
        }

        public void UpdateCatalogItem(CatalogItem catalogItem)
        {
            ents.Entry(catalogItem).State = EntityState.Modified;
            ents.SaveChanges();
        }

        public void RemoveCatalogItem(CatalogItem catalogItem)
        {
            ents.CatalogItems.Remove(catalogItem);
            ents.SaveChanges();
        }

        public void Dispose()
        {
            ents.Dispose();
        }

        public List<CatalogItem> GetCatalogItems()
        {
            throw new NotImplementedException();
        }
    }
}

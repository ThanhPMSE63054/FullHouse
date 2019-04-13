﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FullHouseWebsite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FullHouseEntities : DbContext
    {
        public FullHouseEntities()
            : base("name=FullHouseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_Area> tbl_Area { get; set; }
        public virtual DbSet<tbl_Customer> tbl_Customer { get; set; }
        public virtual DbSet<tbl_District> tbl_District { get; set; }
        public virtual DbSet<tbl_House> tbl_House { get; set; }
        public virtual DbSet<tbl_Image> tbl_Image { get; set; }
    
        public virtual ObjectResult<search_District_Area_Result> search_District_Area(Nullable<int> districtID, Nullable<int> areaID)
        {
            var districtIDParameter = districtID.HasValue ?
                new ObjectParameter("districtID", districtID) :
                new ObjectParameter("districtID", typeof(int));
    
            var areaIDParameter = areaID.HasValue ?
                new ObjectParameter("areaID", areaID) :
                new ObjectParameter("areaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<search_District_Area_Result>("search_District_Area", districtIDParameter, areaIDParameter);
        }
    
        public virtual ObjectResult<search_District_Area_Price_Result> search_District_Area_Price(Nullable<int> districtID, Nullable<int> areaID, Nullable<double> priceFrom, Nullable<double> priceTo)
        {
            var districtIDParameter = districtID.HasValue ?
                new ObjectParameter("districtID", districtID) :
                new ObjectParameter("districtID", typeof(int));
    
            var areaIDParameter = areaID.HasValue ?
                new ObjectParameter("areaID", areaID) :
                new ObjectParameter("areaID", typeof(int));
    
            var priceFromParameter = priceFrom.HasValue ?
                new ObjectParameter("PriceFrom", priceFrom) :
                new ObjectParameter("PriceFrom", typeof(double));
    
            var priceToParameter = priceTo.HasValue ?
                new ObjectParameter("PriceTo", priceTo) :
                new ObjectParameter("PriceTo", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<search_District_Area_Price_Result>("search_District_Area_Price", districtIDParameter, areaIDParameter, priceFromParameter, priceToParameter);
        }
    
        public virtual ObjectResult<search_District_Area_PriceFrom_Result> search_District_Area_PriceFrom(Nullable<int> districtID, Nullable<int> areaID, Nullable<double> priceFrom)
        {
            var districtIDParameter = districtID.HasValue ?
                new ObjectParameter("districtID", districtID) :
                new ObjectParameter("districtID", typeof(int));
    
            var areaIDParameter = areaID.HasValue ?
                new ObjectParameter("areaID", areaID) :
                new ObjectParameter("areaID", typeof(int));
    
            var priceFromParameter = priceFrom.HasValue ?
                new ObjectParameter("PriceFrom", priceFrom) :
                new ObjectParameter("PriceFrom", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<search_District_Area_PriceFrom_Result>("search_District_Area_PriceFrom", districtIDParameter, areaIDParameter, priceFromParameter);
        }
    
        public virtual ObjectResult<search_District_Area_PriceTo_Result> search_District_Area_PriceTo(Nullable<int> districtID, Nullable<int> areaID, Nullable<double> priceTo)
        {
            var districtIDParameter = districtID.HasValue ?
                new ObjectParameter("districtID", districtID) :
                new ObjectParameter("districtID", typeof(int));
    
            var areaIDParameter = areaID.HasValue ?
                new ObjectParameter("areaID", areaID) :
                new ObjectParameter("areaID", typeof(int));
    
            var priceToParameter = priceTo.HasValue ?
                new ObjectParameter("PriceTo", priceTo) :
                new ObjectParameter("PriceTo", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<search_District_Area_PriceTo_Result>("search_District_Area_PriceTo", districtIDParameter, areaIDParameter, priceToParameter);
        }
    
        public virtual ObjectResult<search_Price_Result> search_Price(Nullable<double> priceFrom, Nullable<double> priceTo)
        {
            var priceFromParameter = priceFrom.HasValue ?
                new ObjectParameter("PriceFrom", priceFrom) :
                new ObjectParameter("PriceFrom", typeof(double));
    
            var priceToParameter = priceTo.HasValue ?
                new ObjectParameter("PriceTo", priceTo) :
                new ObjectParameter("PriceTo", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<search_Price_Result>("search_Price", priceFromParameter, priceToParameter);
        }
    
        public virtual ObjectResult<search_PriceFrom_Result> search_PriceFrom(Nullable<double> priceFrom)
        {
            var priceFromParameter = priceFrom.HasValue ?
                new ObjectParameter("PriceFrom", priceFrom) :
                new ObjectParameter("PriceFrom", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<search_PriceFrom_Result>("search_PriceFrom", priceFromParameter);
        }
    
        public virtual ObjectResult<search_PriceTo_Result> search_PriceTo(Nullable<double> priceTo)
        {
            var priceToParameter = priceTo.HasValue ?
                new ObjectParameter("PriceTo", priceTo) :
                new ObjectParameter("PriceTo", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<search_PriceTo_Result>("search_PriceTo", priceToParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}

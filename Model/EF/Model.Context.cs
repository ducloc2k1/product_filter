﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class product_has_attributeEntities : DbContext
    {
        public product_has_attributeEntities()
            : base("name=product_has_attributeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<attribute> attributes { get; set; }
        public virtual DbSet<variant> variants { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<order_detail> order_detail { get; set; }
        public virtual DbSet<product_attribute> product_attribute { get; set; }
        public virtual DbSet<variant_attribute> variant_attribute { get; set; }
        public virtual DbSet<product> products { get; set; }
    
        public virtual ObjectResult<getAttributeProduct_Result> getAttributeProduct(Nullable<int> idProduct)
        {
            var idProductParameter = idProduct.HasValue ?
                new ObjectParameter("idProduct", idProduct) :
                new ObjectParameter("idProduct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAttributeProduct_Result>("getAttributeProduct", idProductParameter);
        }
    
        public virtual ObjectResult<getProductWithAttribute_Result> getProductWithAttribute()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getProductWithAttribute_Result>("getProductWithAttribute");
        }
    
        public virtual ObjectResult<variant> getVariantBySku(Nullable<int> idProduct, string sku)
        {
            var idProductParameter = idProduct.HasValue ?
                new ObjectParameter("idProduct", idProduct) :
                new ObjectParameter("idProduct", typeof(int));
    
            var skuParameter = sku != null ?
                new ObjectParameter("sku", sku) :
                new ObjectParameter("sku", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<variant>("getVariantBySku", idProductParameter, skuParameter);
        }
    
        public virtual ObjectResult<variant> getVariantBySku(Nullable<int> idProduct, string sku, MergeOption mergeOption)
        {
            var idProductParameter = idProduct.HasValue ?
                new ObjectParameter("idProduct", idProduct) :
                new ObjectParameter("idProduct", typeof(int));
    
            var skuParameter = sku != null ?
                new ObjectParameter("sku", sku) :
                new ObjectParameter("sku", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<variant>("getVariantBySku", mergeOption, idProductParameter, skuParameter);
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
    
        public virtual ObjectResult<product> getProductById(Nullable<int> idProduct)
        {
            var idProductParameter = idProduct.HasValue ?
                new ObjectParameter("idProduct", idProduct) :
                new ObjectParameter("idProduct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<product>("getProductById", idProductParameter);
        }
    
        public virtual ObjectResult<product> getProductById(Nullable<int> idProduct, MergeOption mergeOption)
        {
            var idProductParameter = idProduct.HasValue ?
                new ObjectParameter("idProduct", idProduct) :
                new ObjectParameter("idProduct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<product>("getProductById", mergeOption, idProductParameter);
        }
    }
}
// using System;
// using Models.Attribute.AttributeSet;
//
// namespace Models.Entity.Product
// {
//     public class Product : IEntity
//     {
//         public Product(IAttributeSet attributeSet, ProductType productType = ProductType.Simple)
//         {
//             EntityType = EntityType.Product;
//             ProductType = productType;
//             AttributeSet = attributeSet;
//             Id = Guid.NewGuid();
//         }
//
//         public Guid Id { get; }
//         public EntityType EntityType { get; }
//         public ProductType ProductType { get; set; }
//         public IAttributeSet AttributeSet { get; }
//
//         
//     }
// }
// using Models.Attribute.AttributeSet;
// using Models.Factory;
//
// namespace Models.Entity.Product
// {
//     public class ProductFactory : IFactory<Product>
//     {
//         public Product Create()
//         {
//             var defaultAttributes = GetDefaultAttributes();
//             var product = new Product(defaultAttributes);
//             return product;
//         }
//
//         private IAttributeSet GetDefaultAttributes()
//         {
//             return SampleTest.GetDefaultAttributeSet();
//         }
//     }
// }
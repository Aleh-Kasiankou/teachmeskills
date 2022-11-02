// using System.Collections.Generic;
// using Models.Attribute.AttributeSet;
// using Models.Attribute.AttributeType.YesNo;
//
// namespace Models.Entity.Product
// {
//     public static class SampleTest
//     {
//         public static Attribute.Attribute GetAnyAttribute()
//         {
//             return new YesNoAttribute("IsNew");
//         }
//
//         public static IAttributeSet GetDefaultAttributeSet()
//         {
//             return new AttributeSet("default", EntityType.Product, GetDefaultAttributeGroups());
//         }
//
//         public static List<IAttributeGroup> GetDefaultAttributeGroups()
//         {
//             var list = new List<IAttributeGroup>();
//             list.Add(new AttributeGroup("Info", new List<Attribute.Attribute>() { GetAnyAttribute() }));
//             return list;
//         }
//     }
// }
// using Microsoft.AspNetCore.Mvc;
// using Models.Entity.Product;
// using Models.Factory;
//
// namespace API.Controllers
// {
//     [ApiController]
//     [Route("product")]
//     public class ProductController : ControllerBase
//     {
//         [HttpGet("get")]
//         public ActionResult<Product> GetNewProduct([FromServices]IFactory<Product> productFactory)
//         {
//             return productFactory.Create();
//         }
//     }
// }
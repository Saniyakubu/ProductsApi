using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Data;
using ProductsApi.models;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        //GET

        [HttpGet("all")]
        public ActionResult<ProductList> getAllProduct()
        {
            return Ok(ProductList.Products);
        }

        [HttpGet("{productId}")]
        public ActionResult<ProductList> getOneProduct(int productId)
        {

            var product = ProductList.Products.Find(item => item.id == productId);

            if (product == null) return NotFound();

            return Ok(product);

        }

        //POST

        [HttpPost]
        public ActionResult<ProductData> createNewProduct(ProductData newProduct)
        {
            if (newProduct == null) return BadRequest();

            ProductList.Products.Add(newProduct);


            return CreatedAtAction(nameof(getOneProduct), new { productId = newProduct.id }, newProduct); 
        }

        [HttpPut("{productId}")]
        
        public IActionResult updateProduct(int productId, ProductData updatedProduct)
        {
            if (productId == 0) return BadRequest();

            var itemToUpdate = ProductList.Products.Find(item => item.id == productId);

            if (itemToUpdate == null) return NotFound();

            itemToUpdate.name = updatedProduct.name != string.Empty ? updatedProduct.name : itemToUpdate.name ;
            itemToUpdate.brand = updatedProduct.brand != string.Empty ? updatedProduct.brand : itemToUpdate.brand;
            itemToUpdate.price = updatedProduct.price != 0 ? updatedProduct.price : itemToUpdate.price;
            itemToUpdate.category = updatedProduct.category != string.Empty ? updatedProduct.category : itemToUpdate.category;

            return NoContent();
        }

        //DELETE

        [HttpDelete("{productId}")]
        public IActionResult deleteProduct(int productId)
        {
            var itemToDelete = ProductList.Products.Find(item => item.id == productId);

            if (itemToDelete == null) return NotFound();

            ProductList.Products.Remove(itemToDelete);

            return NoContent();

        }
    }
}

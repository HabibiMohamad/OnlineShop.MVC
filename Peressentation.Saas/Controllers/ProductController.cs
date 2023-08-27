using ApplicationLayer.Dtos.ProductDtos;
using ApplicationLayer.UseCases.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Peressentation.Saas.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductUseCase _service;

        public ProductController(IProductUseCase service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var listDto=_service.GetAllForGrid();
            return View(listDto);
        }
        public IActionResult Details(int id)
        {
            var dto = _service.Detail(id);
            return View(dto);
        }
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            var dto = new Create_ProductDto();
            return View(dto);
        }
        [HttpPost]
        public IActionResult Create(Create_ProductDto dto)
        {
            _service.Create(dto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dto = _service.GetEdit(id);
            return View(dto);
        }
        [HttpPost]
        public IActionResult Edit (Update_ProductDto dto)
        {
            _service.Update(dto);
            return RedirectToAction("Index");
        }
    }
}

using ApplicationLayer.Dtos.ProductCategoryDtos;
using ApplicationLayer.UseCases.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Peressentation.Saas.Controllers
{
    public class ProductCategoryController : Controller
    {
        // یک نمونه از applicationservice یا همون UseCase
        private readonly IProductCategoryUseCase _service;

        // injection ya tazrigh == new
        public ProductCategoryController(IProductCategoryUseCase service)
        {
            _service = service;
        }

        // Grid(table)
        public IActionResult Index()
        {
            var listDto = _service.GetAllForGrid();
            return View(listDto);
        }

        // Namayesh Joziyat
        public IActionResult Detail(int id)
        {
            var dto = _service.GetDetail(id);
            return View(dto);
        }
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index"); // shabi be refresh
        }

        [HttpGet]
        public IActionResult Create()
        {
            var dto = new Create_ProductCategoryDto();
            return View(dto);
        }

        [HttpPost]
        public IActionResult Create(Create_ProductCategoryDto dto)
        {
            if (ModelState.IsValid)
            {
                _service.Create(dto);
                return RedirectToAction("Index"); // shabi be refresh

            }
            else
            {
                return View(dto);

            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dto = _service.GetEdit(id);
            return View(dto);
        }

        [HttpPost]
        public IActionResult Edit(Update_ProductCategoyDto dto)
        {
            if (ModelState.IsValid)
            {
                _service.Update(dto);
                return RedirectToAction("Index"); // shabi be refresh
            }
            else
            {
                return View("Edit",dto);
            }
        }
    }
}

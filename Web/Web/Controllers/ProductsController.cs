// ProductsController
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
public class ProductsController : Controller
{
    private readonly IProductRepository _repo;
    public ProductsController(IProductRepository repo) => _repo = repo;

    [HttpGet("")]
    [HttpGet("page/{page:int:min(1)}")]     // /Products or /Products/page/2
    public async Task<IActionResult> Index(int page = 1)
        => View(await _repo.ListAsync(page));

    [HttpGet("{id:int}")]                   // /Products/5
    public async Task<IActionResult> Details(int id)
        => (await _repo.GetAsync(id)) is { } p ? View(p) : NotFound();
}

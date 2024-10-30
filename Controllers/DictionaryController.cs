using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DictionaryApi.Data;
using DictionaryApi.Models;

namespace DictionaryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionaryController : ControllerBase
    {
        private readonly DictionaryContext _context;

        public DictionaryController(DictionaryContext context)
        {
            _context = context;
        }

        [HttpGet("{englishWord}")]
        public ActionResult<string> GetTranslation(string englishWord)
        {
            var item = _context.DictionaryItems
                .FirstOrDefault(d => d.EnglishWord.ToLower() == englishWord.ToLower());

            return item != null ? Ok(item.HungarianTranslation) : NotFound("Translation not found");
        }
    }
}

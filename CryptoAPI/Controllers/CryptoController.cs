




using Microsoft.AspNetCore.Mvc;
using CryptoAPI.Services;

namespace CryptoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CryptoController : ControllerBase
    {
        private readonly CryptoService _cryptoService;

        public CryptoController()
        {
            _cryptoService = new CryptoService();
        }

        [HttpGet("encrypt")]
        public IActionResult Encrypt(string text)
        {
            return Ok(_cryptoService.Encrypt(text));
        }

        [HttpGet("decrypt")]
        public IActionResult Decrypt(string text)
        {
            return Ok(_cryptoService.Decrypt(text));
        }
    }
}

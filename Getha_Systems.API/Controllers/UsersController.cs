using AutoMapper;
using Geta_Systems.API.Entities.DTOs;
using Getha_Systems.domain.repositories;
using Microsoft.AspNetCore.Mvc;

namespace Getha_Systems.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        //retorna todos os resultados
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        //retorna o resultado pelo Id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(CreateRequest model)
        {
            _userService.Create(model);
            return Ok(new { message = "Criado" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateRequest model)
        {
            _userService.Update(id, model);
            return Ok(new { message = "Atualizado" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok(new { message = "Deletado" });
        }
        public IActionResult Lista(ListaDTODados listaDTO)
        {
            var teste1 = listaDTO.Nome;
            var teste2 = listaDTO.Idade;
            return Ok(listaDTO);
        }

        public IActionResult buscaPorNumero(ListaDTODados listaDTO)
        {
            var retornaBusca = _userService.GetById(listaDTO.NumeroAcesso);
            return Ok(retornaBusca);
        }
    }
}

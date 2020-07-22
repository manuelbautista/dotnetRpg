using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNET_RPG.Dtos;
using DOTNET_RPG.Services;
using DOTNET_RPG.Services.CharacterSkillService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_RPG.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CharacterSkillController : ControllerBase
    {
        private readonly ICharacterSkillService characterSkillService;

        public CharacterSkillController(ICharacterSkillService characterService)
        {
            this.characterSkillService = characterService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill)
        {
            return Ok(await characterSkillService.AddCharacterSkill(newCharacterSkill));
        }
    }
}

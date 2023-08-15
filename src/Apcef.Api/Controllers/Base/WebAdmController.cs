using Apcef.Api.Attributes;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Abstractions.Repository.General;
using Apcef.Domain.Entities.Base;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers.Base
{
    [ApiKey]
    public abstract class WebAdmController<T> : ControllerBase where T : Entity
    {
        private readonly IRepository<T> _repository;

        public WebAdmController(IRepository<T> repository) 
        {
            ArgumentNullException.ThrowIfNull(repository, nameof(repository));

            _repository = repository;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repository.GetAll(cancellationToken);

            if (!result.Any())
                return NoContent();

            return Ok(result);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await _repository.GetById(id, cancellationToken);

            if (result is null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost("create")]
        
        public async Task<IActionResult> Create([FromBody]T entity, CancellationToken cancellationToken)
        {
            var result = await _repository.Create(entity, cancellationToken);

            if (result is null)
                return NoContent();

            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody]T entity, CancellationToken cancellationToken)
        {
            var result = await _repository.Update(entity, cancellationToken);

            if (result is null)
                return NoContent();

            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _repository.Delete(id, cancellationToken);

            return Ok();
        }

    }
}

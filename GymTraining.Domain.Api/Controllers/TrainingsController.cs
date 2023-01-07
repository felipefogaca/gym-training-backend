using GymTraining.Domain.Trainings.Services.CreateTraining;
using GymTraining.Domain.Trainings.Services.FindTraining;
using GymTraining.Domain.Trainings.Services.UpdateTraining;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymTraining.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class TrainingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TrainingsController(IMediator mediator)
            => _mediator = mediator;


        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateTrainingInput createTrainingInput,
            CancellationToken cancellationToken)
        {
            var output = await _mediator.Send(createTrainingInput, cancellationToken);

            return CreatedAtAction(
                nameof(Create),
                new { output.Data?.Id },
                output);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(
            [FromBody] UpdateTrainingInput input,
            [FromRoute] Guid id,
            CancellationToken cancellationToken)
        {
            input.Id = id;

            var output = await _mediator.Send(input, cancellationToken);
            return Ok(output);
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Find(
            [FromRoute] Guid id,
            CancellationToken cancellationToken)
        {
            var input = new FindTrainingInput();
            input.Id = id;

            var output = await _mediator.Send(input, cancellationToken);

            return Ok(output);
        }
    }
}

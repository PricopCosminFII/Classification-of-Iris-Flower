using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Commands
{
    public class CreateIrisFlowerCommandHandler : IRequestHandler<CreateIrisFlowerCommand, Guid>
    {
        private readonly IApplicationContext context;

        public CreateIrisFlowerCommandHandler(IApplicationContext context)
        {
            this.context = context;
        }
        public async Task<Guid> Handle(CreateIrisFlowerCommand request, CancellationToken cancellationToken)
        {
            var irisFlower = new IrisFlower
            {
                Class = request.Class,
                PetalLength = request.PetalLength,
                PetalWidth = request.PetalWidth,
                SepalLength = request.SepalLength,
                SepalWidth = request.SepalWidth,
            };
            await context.IrisFlowers.AddAsync(irisFlower);
            return irisFlower.Id; 


        }
    }
}

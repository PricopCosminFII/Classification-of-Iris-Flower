using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class CreateIrisFlowerCommand : IRequest<Guid>
    {
        public string Class { get; set; }
        public decimal SepalLength { get; set; }
        public decimal SepalWidth { get; set; }
        public decimal PetalLength { get; set; }
        public decimal PetalWidth { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceiteDigitalApp.Domain.Interfaces;
using MediatR;

namespace AceiteDigital.Application.Documentos.Commands.AdicionarSignatario
{
    public class AdicionarSignatarioCommand : IRequest
    {
        public long DocumentoId { get; set; }

        public long SignatarioId { get; set; }

        public char TipoSignatario { get; set; }

    }
    public class AdicionarSignatarioCommandHandler : IRequestHandler<AdicionarSignatarioCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdicionarSignatarioCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Unit> Handle(AdicionarSignatarioCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

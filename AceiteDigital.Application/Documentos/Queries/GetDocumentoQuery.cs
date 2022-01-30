using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceiteDigitalApp.Domain.Entities;
using AceiteDigitalApp.Domain.Interfaces;
using MediatR;

namespace AceiteDigital.Application.Documentos.Queries
{
    public class GetDocumentoQuery : IRequest<Documento>
    {
        public long DocumentoId { get; set; } 
    }
    public class GetDocumentoQueryHandler : IRequestHandler<GetDocumentoQuery, Documento>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetDocumentoQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<Documento> Handle(GetDocumentoQuery request, CancellationToken cancellationToken)
        {
            var repositoryDocumento = _unitOfWork.GetRepository<Documento>();

            var documento = await repositoryDocumento.GetByIdAsync(request.DocumentoId);

            return documento;
        }
    }
}

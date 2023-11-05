﻿using AutoMapper;
using MediatR;
using ProjectTemplate.Application.DTOs.Cliente.Responses;
using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Services;

namespace ProjectTemplate.Application.Features.Clientes.CadastrarCliente;

internal sealed class CadastrarClienteCommandHandler :
    IRequestHandler<CadastrarClienteCommand, CadastrarClienteResponse?>
{
    private readonly IClienteDomainService _clienteDomainService;
    private readonly IMapper _mapper;

    public CadastrarClienteCommandHandler(
        IClienteDomainService clienteDomainService,
        IMapper mapper)
    {
        _clienteDomainService = clienteDomainService;
        _mapper = mapper;
    }

    public async Task<CadastrarClienteResponse?>
        Handle(CadastrarClienteCommand request, CancellationToken cancellationToken)
    {
        var cliente = _mapper.Map<Cliente>(request);
        var obj = await _clienteDomainService.AddAsync(cliente);
        return _mapper.Map<CadastrarClienteResponse>(obj);
    }
}
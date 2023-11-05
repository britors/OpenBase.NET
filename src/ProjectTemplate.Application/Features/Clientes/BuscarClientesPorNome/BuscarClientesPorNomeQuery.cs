﻿using MediatR;
using ProjectTemplate.Application.DTOs.Cliente.Responses;

namespace ProjectTemplate.Application.Features.Clientes.BuscarClientesPorNome;

public sealed class BuscarClientesPorNomeQuery : IRequest<IEnumerable<BuscaClienteResponse>>
{
    public string Nome { get; set; } = string.Empty;
}
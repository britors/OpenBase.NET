﻿using MediatR;
using ProjectTemplate.Application.DTOs.Cliente;

namespace ProjectTemplate.Application.Features.Clientes.BuscarClientesPorNomeComDapper;

public sealed class BuscarClientesPorNomeComDapperQuery : IRequest<IEnumerable<BuscaClienteResponse>>
{
    public string Nome { get; set; } = string.Empty;
}
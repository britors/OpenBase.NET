﻿using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using OpenBaseNET.Application.DTOs.Customer.Requests;
using OpenBaseNET.Application.Interfaces.Services;

namespace OpenBaseNET.Presentation.Api.Controllers.Customer;

[Route("api/customer")]
[ApiController]
public class UpdateCustomerController(ICustomerApplicationService customerApplicationService): ControllerBase
{
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(
        [FromBody] UpdateCustomerRequest request,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var result
                = await customerApplicationService.UpdateAsync(request, cancellationToken);
            return Ok(result);
        }
        catch (ValidationException ex)
        {
            return BadRequest(ex.Errors);
        }
        catch (OperationCanceledException)
        {
            return StatusCode(499);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message);
        }
    }
}
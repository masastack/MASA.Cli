using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Commands;
using ProjectNameContracts.CqrsEntity;

namespace ProjectNameService.Application.CqrsEntity.Commands;

public record UpdateCqrsEntityCommand(Guid Id, UpdateCqrsEntityDto Dto) : Command
{
}

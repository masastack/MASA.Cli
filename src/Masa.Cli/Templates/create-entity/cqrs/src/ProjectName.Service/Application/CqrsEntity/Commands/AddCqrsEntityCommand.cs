using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Commands;
using ProjectNameContracts.CqrsEntity;

namespace ProjectNameService.Application.CqrsEntity.Commands;

public record AddCqrsEntityCommand(AddCqrsEntityDto Dto) : Command
{
}

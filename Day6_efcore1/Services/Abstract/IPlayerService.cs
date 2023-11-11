using Day6_efcore1.Dtos.Responses;
using Day6_efcore1.Dtos.Reuqests;
using Day6_efcore1.ReturnsModel;

namespace Day6_efcore1.Services.Abstract;

public interface IPlayerService
{
    ReturnModel<List<PlayerResponseDto>> GetList();
    ReturnModel<PlayerResponseDto> Add(CreatePlayerRequestDto requestDto);
    ReturnModel<PlayerResponseDto> Update(UpdatePlayerRequestDto requestDto);
    ReturnModel<PlayerResponseDto> Delete(int id);
    ReturnModel<PlayerResponseDto> GetById(int id);
}

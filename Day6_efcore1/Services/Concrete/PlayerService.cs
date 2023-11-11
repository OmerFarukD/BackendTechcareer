using AutoMapper;
using Day6_efcore1.Dtos.Responses;
using Day6_efcore1.Dtos.Reuqests;
using Day6_efcore1.Exceptions;
using Day6_efcore1.Models;
using Day6_efcore1.Repositories.Abstract;
using Day6_efcore1.ReturnsModel;
using Day6_efcore1.Services.Abstract;

namespace Day6_efcore1.Services.Concrete;
public class PlayerService : IPlayerService
{
    private readonly IPlayerRepository _playerRepository;
    private readonly IMapper _mapper;

    public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
    {
        _playerRepository = playerRepository;
        _mapper = mapper;
    }

    public ReturnModel<PlayerResponseDto> Add(CreatePlayerRequestDto requestDto)
    {
        Player player = _mapper.Map<Player>(requestDto);
        _playerRepository.Add(player);

        PlayerResponseDto response = _mapper.Map<PlayerResponseDto>(player);

        ReturnModel<PlayerResponseDto> result = new ReturnModel<PlayerResponseDto>()
        {
            Data = response,
            Message = "Oyuncu Başarıyla Eklendi.",
            StatusCode = System.Net.HttpStatusCode.Created
        };

        return result;

    }

    public ReturnModel<PlayerResponseDto> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<PlayerResponseDto> GetById(int id)
    {
        try
        {
            var player = _playerRepository.GetById(id);
            PlayerResponseDto response = _mapper.Map<PlayerResponseDto>(player);
            return new ReturnModel<PlayerResponseDto>()
            {
                Data = response,
                Message = "Id ye ait oyuncu getirildi.",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        catch (NotFoundException ex)
        {
            return new ReturnModel<PlayerResponseDto>()
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };

        }

    }

    public ReturnModel<List<PlayerResponseDto>> GetList()
    {
        throw new NotImplementedException();
    }

    public ReturnModel<PlayerResponseDto> Update(UpdatePlayerRequestDto requestDto)
    {
        throw new NotImplementedException();
    }
}

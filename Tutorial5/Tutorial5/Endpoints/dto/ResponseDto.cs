namespace Tutorial5.Endpoints.dto;

public record ResponseDto<T>(T? Data, string? Error)
{
    public ResponseDto(T Data) : this(Data, null) {}
    public ResponseDto(string Error) : this(default, Error) {}
}
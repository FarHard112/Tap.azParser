using TapazParser.Model.TurboAZ;

namespace TapazParser.Turbo.az.Abstract;

public interface ITurboAz
{
    public List<string> CollectAdds(int pageNumber);

    public TurboModel CollectNameAndNumber(string link);
}
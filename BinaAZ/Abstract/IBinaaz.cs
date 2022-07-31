using TapazParser.Model.BinaAZ;

namespace TapazParser.BinaAZ.Abstract;

public interface IBinaaz
{
    public List<string> CollectAdds(int pageNumber);
    public BinaAZModel CollectNumberAndName(string link);

}
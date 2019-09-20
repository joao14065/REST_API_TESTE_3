using System.Collections.Generic;

namespace REST_API_TESTE_3.Data.Converter
{
    public interface IParser<O, D>
    {
        D Parse(O origin);
        List<D> ParseList(List<O> origin);

    }
}

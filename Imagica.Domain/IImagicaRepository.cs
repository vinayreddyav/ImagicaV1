using System;
using System.Collections.Generic;
using System.Text;

namespace Imagica.Domain
{
    public interface IImagicaRepository
    {

        bool SaveAlternativeTitles(RootObject alternativeTitles);

        bool SaveAlternativeValues(RootObjectValues alternativeValues);

        RootObject FetchAlternativeTitles();

        RootObjectValues FetchAlternativeValues();

        
    }
}

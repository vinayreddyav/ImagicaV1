using System;
using System.Collections.Generic;
using System.Text;

namespace Imagica.Domain
{
    public interface IImagicaRepository
    {

        bool SaveAlternativeTitles(AlternativeTitles alternativeTitles);

        bool SaveAlternativeValues(AlternativeValues  alternativeValues);

        AlternativeTitles FetchAlternativeTitles();

        AlternativeValues FetchAlternativeValues();

        
    }
}

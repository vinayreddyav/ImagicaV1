using System;
using System.Collections.Generic;
using System.Text;

namespace PostProcessingRules.Domain
{
    public interface IPostProcessingRulesRepository
    {

        bool SaveAlternativeTitles(AlternativeTitles alternativeTitles);

        bool SaveAlternativeValues(AlternativeValues  alternativeValues);

        AlternativeTitles FetchAlternativeTitles();

        AlternativeValues FetchAlternativeValues();

        
    }
}

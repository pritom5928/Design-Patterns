using Facade.SearchEngineMechanism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SearchEngineFacade
    {
        private readonly DataIndexers dataIndexers;
        private readonly RetrievingDataMechanisms retrievingDataMechanisms;
        private readonly GeneratingSnippetsMechanism generatingSnippetsMechanism;
        private readonly PresentingResultMechanism presentingResultMechanism;

        public SearchEngineFacade()
        {
            dataIndexers = new DataIndexers();
            retrievingDataMechanisms = new RetrievingDataMechanisms();
            generatingSnippetsMechanism = new GeneratingSnippetsMechanism();
            presentingResultMechanism = new PresentingResultMechanism();
        }

        public string GetSearchingResult(string query)
        {
            var indexes = dataIndexers.GetIndexesOfStoredData(query);

            retrievingDataMechanisms.GetData(indexes);
            generatingSnippetsMechanism.GenerateSnippets();
            presentingResultMechanism.PresentResult();

            return $"Searching result for query : {query}: ....";
        }
    }
}

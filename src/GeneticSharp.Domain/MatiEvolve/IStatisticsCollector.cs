using System.Collections.Generic;
using GeneticSharp.Domain.Chromosomes;

namespace GeneticSharp.Domain.MatiEvolve
{
	public interface IStatisticsCollector
	{
		void NoteChromosomesAtPhase(GenerationEvolutionPhase phase, IList<IChromosome> chromosomes);
	}
}
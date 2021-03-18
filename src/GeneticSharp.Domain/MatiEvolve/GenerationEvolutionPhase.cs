using System;

namespace GeneticSharp.Domain.MatiEvolve
{
	[Flags]
	public enum GenerationEvolutionPhase
	{
		BeforeGeneration = 1,
		Beginning = 2,
		SelectedParents = 4,
		Offspring = 8,
		Reinserted = 16,
		NewGenerationCreated = 32,
		GenerationEnded = 64,
		AfterGeneration = 128,
	}
}
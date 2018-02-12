namespace structure_map_sample.Managers
{
	public class WordManager : IWordManager
	{
		public string Name { get; set; }

		public string GetWord() {
			return "word!!!";
		}
	}
}
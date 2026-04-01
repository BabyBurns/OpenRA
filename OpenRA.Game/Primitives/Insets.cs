namespace OpenRA.Primitives
{
	public class Insets(int top = 0, int right = 0, int bottom = 0, int left = 0)
	{
		public static readonly Insets Empty = new();

		public int Top { get; set; } = top;
		public int Right { get; set; } = right;
		public int Bottom { get; set; } = bottom;
		public int Left { get; set; } = left;
	}
}

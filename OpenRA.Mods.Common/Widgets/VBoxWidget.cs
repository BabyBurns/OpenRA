using OpenRA.Primitives;

namespace OpenRA.Mods.Common.Widgets
{
	public class VBoxWidget : BackgroundWidget
	{
		public Insets Padding { get; set; } = Insets.Empty;
		public bool FillWidth { get; set; } = true;
		public int Spacing { get; set; }

		bool NeedsLayout { get; set; } = true;

		void LayoutChildren()
		{
			var width = Bounds.Width - Padding.Left - Padding.Right;
			var lastY = Padding.Top;
			foreach (var child in Children)
			{
				child.Bounds.X = Bounds.X + Padding.Left;
				child.Bounds.Y = lastY;
				lastY += child.Bounds.Height + Spacing;
				if (FillWidth)
					child.Bounds.Width = width;
			}

			NeedsLayout = false;
		}

		public void InvalidateLayout()
		{
			NeedsLayout = true;
		}

		public override void Draw()
		{
			if (NeedsLayout)
				LayoutChildren();
			base.Draw();
		}
	}
}

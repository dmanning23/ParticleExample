using FontBuddyLib;
using MenuBuddy;
using Microsoft.Xna.Framework;
using ResolutionBuddy;

namespace ParticleExample
{
	/// <summary>
	/// The main menu screen is the first thing displayed when the game starts up.
	/// It contains: 
	///		the title of the game
	///		@dannobotgames button that opens a link to a webpage or something
	///		a full screen button that says "Tap anywhere to begin!". This takes the player to the SelectLessonScreen
	/// </summary>
	public class MainScreen : WidgetScreen, IMainMenu
	{
		#region Methods

		/// <summary>
		/// Constructor fills in the menu contents.
		/// </summary>
		public MainScreen()
			: base("Main")
		{
		}

		public override void LoadContent()
		{
			base.LoadContent();

			//add the studio tag
			var dannobotText = new FontBuddy()
			{
				Font = StyleSheet.Instance().SmallNeutralFont.Font
			};
			var dannobot = new Label("@DannobotGames")
			{
				Font = dannobotText,
				ShadowColor = new Color(0.15f, 0.15f, 0.15f),
				TextColor = new Color(0.85f, 0.85f, 0.85f, 0.7f),
				Transition = new WipeTransitionObject(TransitionWipeType.PopRight),
				Horizontal = HorizontalAlignment.Right,
				Vertical = VerticalAlignment.Bottom,
				Position = new Point(Resolution.TitleSafeArea.Right, Resolution.TitleSafeArea.Bottom),
				Highlightable = false
			};
			AddItem(dannobot);

			//Add the button that allows the user to continue to the next screen
			var button = new RelativeLayoutButton()
			{
				Position = new Point(Resolution.ScreenArea.Left, Resolution.ScreenArea.Top),
				Size = new Vector2(Resolution.ScreenArea.Width, Resolution.ScreenArea.Height),
				Horizontal = HorizontalAlignment.Left,
				Vertical = VerticalAlignment.Top,
				Transition = new WipeTransitionObject(TransitionWipeType.SlideLeft)
			};
			button.OnClick += ((onj, e) =>
			{
				//TODO: Create a particle effect
			});
			AddItem(button);

			//use a pulsate font for that button
			var pulsate = new Label("Tap  anywhere  to  create  a  particle!")
			{
				Font = new PulsateBuddy()
				{
					Font = StyleSheet.Instance().SmallNeutralFont.Font
				},
				Horizontal = HorizontalAlignment.Center,
				Vertical = VerticalAlignment.Center,
				Highlightable = false,
				Position = Resolution.ScreenArea.Center,
			};
			AddItem(pulsate);
		}

		#endregion //Methods
	}
}
using UiSystem.Interfaces;

namespace UiSystem.Signals {
	public class SignalCloseWindow {
		public IWindow Window;

		public SignalCloseWindow(IWindow window) {
			Window = window;
		}
	}
}
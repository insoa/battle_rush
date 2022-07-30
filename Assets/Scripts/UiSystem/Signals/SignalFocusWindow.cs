using UiSystem.Interfaces;

namespace UiSystem.Signals {
	public class SignalFocusWindow {
		public IWindow Window;

		public SignalFocusWindow(IWindow window) {
			Window = window;
		}
	}
}
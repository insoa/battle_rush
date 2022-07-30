using UiSystem.Interfaces;

namespace UiSystem.Signals {
	public class SignalActiveWindow {
		public IWindow Window;
		public SignalActiveWindow(IWindow window) => Window = window;
	}
}
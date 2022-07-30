namespace UiSystem.Interfaces {
	public interface IWindow {
		string Name { get; }
		void SetState(UiWindowState state);
		void Back();
	}
}
using System.Collections.Generic;

namespace UiSystem.Interfaces {
	public interface IWindowsController {
		Stack<IWindow> Windows { get; }
		IWindow Current { get; }
	}
}
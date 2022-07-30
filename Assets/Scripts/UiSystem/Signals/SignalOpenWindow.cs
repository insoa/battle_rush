using System;
using UiSystem.Interfaces;

namespace UiSystem.Signals {
	
	public class SignalOpenWindow {
		public readonly Type Type;
		public readonly string Name;
		public readonly Action<IWindow> Argument;

		public SignalOpenWindow(Type type) {
			Type = type;
		}

		public SignalOpenWindow(Type type, Action<IWindow> argument) {
			Type = type;
			Argument = argument;
		}

		public SignalOpenWindow(string name) {
			Name = name;
		}
	}
}
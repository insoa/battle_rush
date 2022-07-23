using System.Collections.Generic;
using UiSystem.Intefaces;
using Zenject;

namespace UiSystem {
	public abstract class UiController<T> : IUiController where T : IUiView {
		
		private readonly UiControllerState DefaultState = new UiControllerState();

		private readonly Stack<UiControllerState> _states = new Stack<UiControllerState>();

		private UiControllerState _currentState;

		[Inject] protected readonly T View;
		public bool IsActive { get; private set; }
		public bool InFocus { get; private set; }

		public void SetState(UiControllerState state) {
			_currentState = state;
			_states.Push(state);
		}

		public void ProcessStateOrder() {
			if (!_currentState.IsActive)
				return;
			SetOrder(_currentState.Order);
		}

		public void ProcessState() {
			IsActive = _currentState.IsActive;
			if (_currentState.IsActive)
				OnShow();
			else
				OnHide();
			if (InFocus == _currentState.InFocus)
				return;
			InFocus = _currentState.InFocus;
			OnHasFocus(_currentState.InFocus);
		}

		public void Back() {
			if (_states.Count > 0)
				_states.Pop();
			if (_states.Count == 0) {
				_currentState = DefaultState;
				return;
			}

			SetState(_states.Pop());
		}

		public void ShowView() => OnShow();
		public void HideView() => OnHide();

		protected virtual void OnShow() => View.Show();

		protected virtual void OnHide() => View.Hide();

		public virtual void OnHasFocus(bool inFocus) { }

		private void SetOrder(int index) {
			View.SetOrder(index);
		}
	}
}
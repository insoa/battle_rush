namespace UiSystem {
	public sealed class UiControllerState {
		public bool IsActive;
		public bool InFocus;
		public int Order;
		public UiControllerState() { }

		public UiControllerState(bool isActive, bool inFocus, int order) {
			IsActive = isActive;
			InFocus = inFocus;
			Order = order;
		}

		public static UiControllerState GetActive(int order) => new UiControllerState(true, true, order);
		public static UiControllerState GetInactive() => Inactive;
		private static readonly UiControllerState Inactive = new UiControllerState(false, false, 0);

	}
}
namespace Databases {
	public abstract class ADataList<T> {
		public readonly T[] List;

		protected ADataList(T[] list) {
			List = list;
		}
	}
}
using System.Collections.Generic;
using UiSystem.Extentions;
using UiSystem.Interfaces;

namespace UiSystem {
	public class UiViewFactory : IUiViewFactory {
  		private readonly List<IUiViewOnCreated> _list;
  
  		public UiViewFactory(List<IUiViewOnCreated> list) {
  			_list = list;
  		}
  
  		public void Process(IUiView view) {
  			foreach (var processor in _list)
  				processor.Process(view);
  		}
  	}
  	public interface IUiViewOnCreated {
  		void Process(IUiView view);
  	}
}
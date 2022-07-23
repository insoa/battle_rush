using Databases;

namespace Interfaces {
	public interface IResourceDatabase {
		ResourceItem Get(ResourceId resourceId);
		bool Has(ResourceId resourceId);
	}
}
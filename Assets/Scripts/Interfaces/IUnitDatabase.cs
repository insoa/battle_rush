using Databases;
using Databases.Id;

namespace Interfaces {
	public interface IUnitDatabase { 
		Unit Get(UnitId unitId);
		bool Has(UnitId unitId);
	}
}
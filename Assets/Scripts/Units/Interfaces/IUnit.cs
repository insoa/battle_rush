namespace Units.Interfaces {
	public interface IUnit { 
		void GetUnitData();
		void FindEnemyTarget(UnitBehaviour target);
		void MoveToTarget(UnitBehaviour target);
		void Attack(float damage);
		void Death();
	}
}
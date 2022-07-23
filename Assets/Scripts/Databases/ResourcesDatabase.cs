using System;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;

namespace Databases {
	[CreateAssetMenu(fileName = "ResourcesDatabase", menuName = "ScriptableObjects/ResourcesDatabase", order = 3)]
	public sealed class ResourcesDatabase : ScriptableObject, IResourceDatabase {
		[SerializeField] private ResourceItem[] _resources;
		private readonly Dictionary<ResourceId, ResourceItem> _database = new();
		public IEnumerable<ResourceItem> All => _resources;

		public ResourcesDatabase(ResourceData data) {
			foreach (var resource in data.List)
				_database.Add(resource.Id, resource);
			_resources = data.List;
		}

		public ResourceItem Get(ResourceId resourceId) {
			if (!_database.ContainsKey(resourceId))
				Debug.Log("[ItemsDatabase]" + $"Can't find item with id {resourceId}");
			return _database[resourceId];
		}

		public bool Has(ResourceId resourceId) => _database.ContainsKey(resourceId);
	}

	[Serializable]
	public class ResourceItem {
		public ResourceId Id;
		public Sprite ResourceIcon;
	}

	[Serializable]
	public class ResourceData : ADataList<ResourceItem> {
		public ResourceData(ResourceItem[] list) : base(list) { }
	}
}
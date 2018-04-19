using UnityEngine;
namespace Pathfinding {
	using Pathfinding.Util;

	/** Helper for #Pathfinding.Examples.LocalSpaceRichAI */
	public class LocalSpaceGraph : VersionedMonoBehaviour {
		Matrix4x4 originalMatrix;
		public GraphTransform transformation { get; private set; }

		void Start () {
			originalMatrix = transform.worldToLocalMatrix;
			transform.hasChanged = true;
			Refresh();
		}

		public void Refresh () {
			// Avoid updating the GraphTransform if the object has not moved
			if (transform.hasChanged) {
				transformation = new GraphTransform(transform.localToWorldMatrix * originalMatrix);
				transform.hasChanged = false;
			}
		}
	}
}

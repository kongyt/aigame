using UnityEngine;

namespace Pathfinding.Examples {
	/** RichAI for local space (pathfinding on moving graphs).
	 *
	 * What this script does is that it fakes graph movement.
	 * It can be seen in the example scene called 'Moving' where
	 * a character is pathfinding on top of a moving ship.
	 * The graph does not actually move in that example
	 * instead there is some 'cheating' going on.
	 *
	 * When requesting a path, we first transform
	 * the start and end positions of the path request
	 * into local space for the object we are moving on
	 * (e.g the ship in the example scene), then when we get the
	 * path back, they will still be in these local coordinates.
	 * When following the path, we will every frame transform
	 * the coordinates of the waypoints in the path to global
	 * coordinates so that we can follow them.
	 *
	 * At the start of the game (when the graph is scanned) the
	 * object we are moving on should be at a valid position on the graph and
	 * you should attach the #Pathfinding.LocalSpaceGraph component to it. The #Pathfinding.LocalSpaceGraph
	 * component will store the position and orientation of the object right there are the start
	 * and then we can use that information to transform coordinates back to that region of the graph
	 * as if the object had not moved at all.
	 *
	 * This functionality is only implemented for the RichAI
	 * script, however it should not be hard to
	 * use the same approach for other movement scripts.
	 *
	 * \astarpro
	 */
	public class LocalSpaceRichAI : RichAI {
		/** Root of the object we are moving on */
		public LocalSpaceGraph graph;

		void RefreshTransform () {
			graph.Refresh();
			richPath.transform = graph.transformation;
			movementPlane = graph.transformation;
		}

		protected override void Start () {
			RefreshTransform();
			base.Start();
		}

		public override void UpdatePath () {
			RefreshTransform();
			CancelCurrentPathRequest();

			waitingForPathCalc = true;
			lastRepath = Time.time;

			// Convert our current position and the target position to positions on the graph
			seeker.StartPath(graph.transformation.InverseTransform(tr.position), graph.transformation.InverseTransform(target.position));
		}

		protected override void Update () {
			RefreshTransform();
			base.Update();
		}
	}
}
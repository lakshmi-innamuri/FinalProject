using UnityEngine;

public static class RendererExtensions
{
	public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
		Debug.Log ("111:"+GeometryUtility.TestPlanesAABB (planes, renderer.bounds));
		return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
	}
}

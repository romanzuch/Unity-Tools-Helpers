private void CheckForPropInNextField()
{
    Ray ray = new Ray(transform.position, playerLookDirection);
    RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, rayLength, layerMask);
    if (hit.collider != null) {
        // do something
    } else {
        // do something else
    }
}
private void CheckForPropInNextField()
{
    Ray ray = new Ray(transform.position, playerLookDirection);
    RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, rayLength, layerMask);
    if (hit.collider != null) {
        if (hit.transform.name == "Chest" || hit.transform.tag == "Container")
            {
                ContainerController containerController = hit.transform.GetComponent<ContainerController>();
                if (containerController != null)
                {
                    containerController.ShowContainerIndicator();
                    previousContainerController = containerController;
                    containerController.InteractWithContainer();
                }
            }
    } 
    else if (hit.collider == null && previousContainerController != null) 
    {
        previousContainerController.HideContainerIndicator();
        previousContainerController = null;
    }
}
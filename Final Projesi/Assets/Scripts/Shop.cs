using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;

    BuildManager buildmanager;

    private void Start()
    {
        buildmanager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildmanager.SelectTurretToBuild(standardTurret);
    }
   public void SelectMissileLauncher()
    {
        Debug.Log("Missile Launcher Selected");
        buildmanager.SelectTurretToBuild(missileLauncher);
    }
    public void SelectlaserBeamer()
    {
        Debug.Log("LaserBeamer Selected");
        buildmanager.SelectTurretToBuild(laserBeamer);
    }

}

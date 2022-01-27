using UnityEngine;

namespace SOLIDPrinciples.DependencyInversion
{
    public class DependencyInversion : MonoBehaviour
    {
        // High-level modules should not depend on low-level modules. Both should depend on abstractions.
        // Abstractions should not depend on details. Details should depend on abstractions.

        private void Start()
        {
            IVehicle tank = new Tank();
            tank.Fire();
            tank.Move();

            IVehicle plane = new Plane();
            plane.Fire();
            plane.Move();

            Commander commander = new Commander();

            commander.Use(tank);
            commander.MoveToArea();
            commander.FireAtTarget();

            commander.Use(plane);
            commander.MoveToArea();
            commander.FireAtTarget();
        }
    }

    public interface IVehicle
    {
        void Move();
        void Fire();
    }

    public class Tank : IVehicle
    {
        public void Move()
        {
            Debug.Log("Tank move!");
        }

        public void Fire()
        {
            Debug.Log("Tank fire!");
        }
    }

    public class Plane : IVehicle
    {
        public void Move()
        {
            Debug.Log("Plane move!");
        }

        public void Fire()
        {
            Debug.Log("Plane fire!");
        }
    }

    public class Commander
    {
        private IVehicle _vehicle;

        public void Use(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void MoveToArea()
        {
            Debug.Log("Area found");
            _vehicle?.Move();
        }

        public void FireAtTarget()
        {
            Debug.Log("Target found");
            _vehicle?.Fire();
        }
    }
}
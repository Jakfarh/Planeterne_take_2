using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne_take_2
{
    class Planetcreator
    {
        private string name;
        private double mass;
        private double diameter;
        private double density;
        private double gravity;
        private double rotation_period;
        private double length_of_day;
        private double distance_from_sun;
        private double orbital_period;
        private double orbital_velocity;
        private int mean_temperature;
        private int number_of_moons;
        private bool ring_system;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public double Density
        {
            get { return density; }
            set { density = value; }
        }
        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }
        public double Rotation_Period
        {
            get { return rotation_period; }
            set { rotation_period = value; }
        }
        public double Length_of_Day
        {
            get { return length_of_day; }
            set { length_of_day = value; }
        }
        public double Distance_from_Sun
        {
            get { return distance_from_sun; }
            set { distance_from_sun = value; }
        }
        public double Orbital_Period
        {
            get { return orbital_period; }
            set { orbital_period = value; }
        }
        public double Orbital_Velocity
        {
            get { return orbital_velocity; }
            set { orbital_velocity = value; }
        }
        public int Mean_Temperature
        {
            get { return mean_temperature; }
            set { mean_temperature = value; }
        }
        public int Number_of_Moons
        {
            get { return number_of_moons; }
            set { number_of_moons = value; }
        }
        public bool Ring_System
        {
            get { return ring_system; }
            set { ring_system = value; }
        }
        public Planetcreator(string _Name, double _Mass, double _Diameter, double _Density, double _Gravity, double _Rotation_Period, double _Length_of_Day, double _Distance_from_Sun, double _Orbital_Period, double _Orbital_Valocity, int _Mean_Temperature, int _Number_of_Moons, bool _Ring_System)
        {
            Name = _Name;
            Mass = _Mass;
            Diameter = _Diameter;
            Density = _Density;
            Gravity = _Gravity;
            Rotation_Period = _Rotation_Period;
            Length_of_Day = _Length_of_Day;
            Distance_from_Sun = _Distance_from_Sun;
            Orbital_Period = _Orbital_Period;
            Orbital_Velocity = _Orbital_Valocity;
            Mean_Temperature = _Mean_Temperature;
            Number_of_Moons = _Number_of_Moons;
            Ring_System = _Ring_System;
        }
    }
}

using Build.Project;
using System.Collections.Generic;
using System.Linq;

namespace Build
{
    public class House
    {
        private HouseProject _project;
        public bool IsBasementBuild
        {
            get => Parts.OfType<Basement>().Any() && _project.BasementNeeded;
        }        
        public bool IsWallsComplete
        {
            get => Parts.OfType<Walls>().Count() == _project.WallCount;
        }
        public bool IsRoofBuild
        {
            get => Parts.OfType<Roof>().Any() && _project.RoofNeeded;
        }
        public bool IsWindowComplete
        {
            get => Parts.OfType<Window>().Count() == _project.WindowCount;
        }
        public bool IsDoorComplete
        {
            get => Parts.OfType<Door>().Any() && _project.DoorNeeded;
        }
        
        public bool IsComplete
        {
            get
            {
                //тут всякие остальные детали по проекту
                return IsBasementBuild && IsWallsComplete && IsRoofBuild && IsWindowComplete && IsDoorComplete;
            }
        }

        public List<IPart> Parts { get; set; } = new List<IPart>();
        public House(HouseProject project)
        {
            _project = project;
        }

    }
}
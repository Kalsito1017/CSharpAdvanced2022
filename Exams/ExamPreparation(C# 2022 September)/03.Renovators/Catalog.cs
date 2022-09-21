using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renovators
{
    public class Catalog
    {
        List<Renovator> renovators;
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public Catalog( string name, int neededRenovators, string project)
        {
            
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            renovators = new List<Renovator>(); 
        }
        public int Count => renovators.Count;
        public string AddRenovator(Renovator renovator)
        {
            if (NeededRenovators > Count)
            {
                if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
                {
                    return "Invalid renovator's information.";
                }
                if (renovator.Rate > 350)
                {
                    return "Invalid renovator's rate.";
                }
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
           
            return "Renovators are no more needed.";
        }
        public bool RemoveRenovator(string name)
        {

            if (renovators.Any(r => r.Name == name))
            {
                renovators.RemoveAll(r => r.Name == name);
                return true;
            }
            return false;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            return renovators.RemoveAll(r => r.Type == type);
        
        }
        public Renovator HireRenovator(string name )
        {
            if (renovators.Any(r => r.Name == name))
            {
                Renovator renovator = renovators.First(r => r.Name == name);
                renovator.Hired = true;
            }

            return renovators.FirstOrDefault(r => r.Name == name);
        }
        public List<Renovator> PayRenovators(int days) => renovators.FindAll(r => r.Days == days);
       
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in renovators.Where(r => r.Hired == false))
            {
                sb.AppendLine(renovator.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}

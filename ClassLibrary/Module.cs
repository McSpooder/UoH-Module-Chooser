using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Module
    {
        private int _moduleId;
        private string _name;
        private string _description;
        private float _rating;
        private List<String> _LecturerReference;
        private List<String> _ReviewReferences;

        public Module(int pModuleId, string pName, float pRating, string pDescription)
        {
            _moduleId = pModuleId;
            _name = pName;
            _rating = pRating;
            _description = pDescription;
        }

        public int GetModuleId()
        {
            return _moduleId;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetModuleDescription()
        {
            return _description;
        }

        public float getRating()
        {
            return _rating;
        }

    }
}

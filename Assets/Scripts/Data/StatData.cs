using UnityEngine;

namespace Data
{
    [System.Serializable]
    public sealed class StatData
    {
       [SerializeField] private string _name;
       [SerializeField] private int _max;
       [SerializeField] private int _min;
       [SerializeField] private string _description;
       public string Name { get { return _name; } }
       public int Max { get { return _max; } }
       public int Min { get { return _min; } }
       public string Description { get { return _description; } }
        public StatData(string name, int max = 0, int min = 0, string description = "")
        {
            _name = name;
            _max = max;
            _min = min;
            _description = description;
        }
        
        public int CheckIfStatInRange(int value)
        {
            return Mathf.Clamp(value, Min, Max);
        }
    }
}
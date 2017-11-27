using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Entity
    {
        public string Name { get; set; }
        public bool HasPriority { get; set; }
        public bool HasIssue { get; set; }

        string[] allEntities = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i" };
        string[] entitiesWithPriority = new[] { "c", "d", "g" };
        string[] entitiesWithIssue = new[] { "d", "h", "i" };

        public List<List<Dictionary<string, dynamic>>> MethodName()
        {
            var list = new List<List<Dictionary<string, dynamic>>>();

            HasPriority = false;
            HasIssue = false;

            foreach (var item in allEntities)
            {
                if (entitiesWithPriority.Contains(item.ToString()))
                    HasPriority = true;
                if (entitiesWithIssue.Contains(item.ToString()))
                    HasIssue = true;
                list.Add(new List<Dictionary<string, dynamic>>()
                {
                    (new Dictionary<string, dynamic>() {
                        { "name", item },
                        { "hasPriority", HasPriority },
                        { "hasIssue", HasIssue }
                    })
                });
            }
            return list;
        }
    }
}

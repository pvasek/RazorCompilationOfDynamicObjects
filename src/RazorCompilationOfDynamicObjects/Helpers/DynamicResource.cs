using System.Dynamic;

namespace RazorCompilationOfDynamicObjects.Helpers
{
    public class DynamicResource : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            // here should be the code loading appropriate resources
            result = binder.Name.Replace('_', ' ');
            return true;
        }

        public string GetString(string key)
        {
            return key.Replace('_', ' ');
        }
    }
}
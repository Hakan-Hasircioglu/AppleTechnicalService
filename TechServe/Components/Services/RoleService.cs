namespace TechServe.Components.Services
{
    public class RoleService
    {
        public string Role { get; set; }

        public void UpdateSharedData(string newData)
        {
            Role = newData;
        }
    }
}

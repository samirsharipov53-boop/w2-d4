using day;

namespace Infrastructure;

public class GroupRepo
{
 List<Group> groups = [];
 public void CreateGroup(int id, string n, string des)
    {
        Group group = new Group();
        groups.Add(group);
    }
    public void GetGroups()
    {
        foreach (var item in groups)
        {
            System.Console.WriteLine(item.Id+" "+item.Name +" "+item.Description);
        }
    }
    public void UpdateGroup(int id, string n, string des)
    {
        foreach (var item in groups)
        {
            if(item.Id==id)
            {
                 item.Name=n;
                 item.Description=des;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in groups)
        {
            if(item.Id==id)
            {
                groups.Remove(item);
            }
        }
    }
    
}

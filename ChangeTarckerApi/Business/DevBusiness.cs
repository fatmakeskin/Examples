using ChangeTarckerApi.DevContext;
using System;
using System.Linq;

namespace ChangeTarckerApi.Business
{
    public class DevBusiness
    {
	    public string Trackerget()
        {
            using (var data=new MasterContext())
            {
                var developer = data.Developers.FirstOrDefault();
                var entries = data.ChangeTracker.Entries();
                foreach (var item in entries)
                {
                   Console.WriteLine("entity state is: "+item.State);
                }

            }
        }
	
        
    }
}

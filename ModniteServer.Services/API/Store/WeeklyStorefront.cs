using System.Collections.Generic;

namespace ModniteServer.API.Store
{
    internal sealed class WeeklyStorefront : Storefront
    {
        public WeeklyStorefront()
        {
            Name = "BRWeeklyStorefront";
            IsWeeklyStore = true;
            Catalog = new List<StoreItem>
            {
                new StoreItem
                {
                    TemplateId = "AthenaCharacter:CID_002_Athena_Commando_F_Default",
                    Priority = -1
                },
                new StoreItem
                {
                    TemplateId = "AthenaCharacter:CID_001_Athena_Commando_F_Default",
                    Priority = -2
                }
            };
        }
    }
}
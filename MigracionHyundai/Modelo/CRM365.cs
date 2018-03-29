using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigracionHyundai.Modelo
{
    public class CRM2011
    {

        public CrmConnection connection { get; private set; }
        public OrganizationService orgService { get; private set; }

        public CRM2011()
        {
            this.connection = CrmConnection.Parse(ConfigurationManager.ConnectionStrings["crmOrigen"].ConnectionString);
            this.orgService = new OrganizationService(connection);

        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Xrm;
using System.Linq;
using Microsoft.Crm.Sdk.Messages;

namespace LTA.CRM.Plugins
{
    public class GlobalPlugin : BasePlugin
    {
        public override IEnumerable<RegisteredEvent> GetRegisteredEvents()
        {
            // Add Registered Events
            var events = new List<RegisteredEvent>
            {
                new RegisteredEvent(PipelineStage.MainOperation, SdkMessageProcessingStepMode.CustomAPI, "jt_CountCreditLimitAboveValue", CountCreditLimitAboveValue)
            };

            return events;
        }

        public override void ExecutePlugin(IExtendedPluginContext context)
        {
            // Plugin logic
        }

        public void CountCreditLimitAboveValue(IExtendedPluginContext context){
            //Count of credit limits over $100
            var accountID = context.PrimaryEntity.Id;
            var amount = Convert.ToDecimal(context.InputParameters["amount"]);
            using(var ctx = new CrmServiceContext(context)){
                var childAccounts = ctx.AccountSet.Where(x=>x.ParentAccountId.Id == accountID && x.CreditLimit != null && x.CreditLimit.Value > amount);
                context.OutputParameters["count"] = childAccounts.ToArray().Length;
            }
        }
    }
}

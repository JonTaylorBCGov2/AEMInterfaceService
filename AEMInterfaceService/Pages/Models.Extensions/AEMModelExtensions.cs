using Gov.Cscp.VictimServices.Public.JsonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEMInterfaceService.Pages.Models.Extensions
{
    public static class AEMModelExtensions
    {
        public static AEMDynamicsModel ToAEMDynamicsModel(this AEMTransaction model)
        {
            AEMDynamicsModel aemTransaction = new AEMDynamicsModel();

            aemTransaction.EventId = model.event_message_id;
            aemTransaction.EventType = model.message_event_type_cd;
            aemTransaction.EventDate = model.event_dtm;
            aemTransaction.DataElement1 = model.event_data[0].data_element_nm;
            aemTransaction.DataValue1 = model.event_data[0].data_value_txt;
            aemTransaction.DataElement2 = model.event_data[1].data_element_nm;
            aemTransaction.DataValue2 = model.event_data[1].data_value_txt;
            aemTransaction.DataElement3 = model.event_data[2].data_element_nm;
            aemTransaction.DataValue3 = model.event_data[2].data_value_txt;
            aemTransaction.DataElement4 = model.event_data[3].data_element_nm;
            aemTransaction.DataValue4 = model.event_data[3].data_value_txt;
            return aemTransaction;
        }
    }
}


﻿using Gov.Cscp.VictimServices.Public.JsonObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AEMInterfaceService.Pages.Models
{
    public class AEMTransaction
    {
        public Int64 EventMessageID;
        [Required]
        public Int64 event_message_id
        {
            get { return EventMessageID; }
            set { EventMessageID = value; }
        }

        String TargetSystemCD;
        [Required]
        public String target_system_cd
        {
            get { return TargetSystemCD; }
            set { TargetSystemCD = value; }
        }

        String MessageEventTypeCD;
        [Required]
        public String message_event_type_cd
        {
            get { return MessageEventTypeCD; }
            set { MessageEventTypeCD = value; }
        }

        DateTime EventDTM;
        [Required]
        public DateTime event_dtm
        {
            get { return EventDTM; }
            set { EventDTM = value; }
        }

        List<AEMTransactionEventData> EventData;
        public List<AEMTransactionEventData> event_data
        {
            get { return EventData; }
            set { EventData = value; }
        }
    }
}

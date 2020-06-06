﻿using System.Collections.Generic;
using MTGAHelper.Entity.OutputLogParsing;
using MTGAHelper.Lib.OutputLogParser.Models.UnityCrossThreadLogger;

namespace MTGAHelper.Lib.OutputLogParser.Readers.UnityCrossThreadLogger
{
    public class GetActiveEventsV2Converter : GenericConverter<GetActiveEventsV2Result, PayloadRaw<ICollection<GetActiveEventsV2Raw>>>, IMessageReaderUnityCrossThreadLogger
    {
        public override string LogTextKey => "<== Event.GetActiveEventsV2";
    }
}

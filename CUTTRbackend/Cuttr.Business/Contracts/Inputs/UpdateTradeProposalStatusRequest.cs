﻿using Cuttr.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuttr.Business.Contracts.Inputs
{
    public class UpdateTradeProposalStatusRequest
    {
        public TradeProposalStatus NewStatus { get; set; }
    }
}

﻿using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.BusinessLogic.Services
{
    public interface iApprovalService
    {
        bool insert(ApprovalParam approvalParam);
        bool update(int? id, ApprovalParam approvalParam);
        Approvals Get(int? id);
        List<Approvals> Get();
    }
}

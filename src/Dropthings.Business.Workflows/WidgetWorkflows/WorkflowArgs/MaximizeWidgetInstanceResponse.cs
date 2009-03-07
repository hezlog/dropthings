﻿namespace Dropthings.Business.Workflows.WidgetWorkflows.WorkflowArgs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Dropthings.DataAccess;

    public class MaximizeWidgetInstanceResponse : UserWorkflowResponseBase
    {
        #region Properties

        public List<WidgetInstance> WidgetInstances
        {
            get; set;
        }

        #endregion Properties
    }
}
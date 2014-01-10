﻿using Orchard;

namespace Lombiq.Hosting.DistributedSignals.Services
{
    public interface IMachineNameAccessor : IDependency
    {
        string GetMachineName();
    }


    public class MachineNameAccessor : IMachineNameAccessor
    {
        public string GetMachineName()
        {
            return System.Environment.MachineName;
        }
    }
}
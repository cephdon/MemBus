﻿using System;

namespace MemBus
{
    public interface IConfigurablePublishing
    {
        void ConfigureWith<T>() where T : ISetupConfigurator<IConfigurablePublishing>, new();
        void DefaultPublishPipeline(params IPublishPipelineMember[] publishPipelineMembers);
        void ForMessageMatching(Func<MessageInfo, bool> match, Action<IConfigurePipeline> configure);
    }

    public interface IConfigurePipeline
    {
        void ConfigureWith<T>() where T : ISetupConfigurator<IConfigurePipeline>, new();
        void PublishPipeline(params IPublishPipelineMember[] publishPipelineMembers);
    }
}